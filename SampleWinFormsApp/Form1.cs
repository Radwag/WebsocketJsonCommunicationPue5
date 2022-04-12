using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SampleWinFormsApp.DataModels;
using SampleWinFormsApp.Properties;
using Services;
using Services.Commands;

namespace SampleWinFormsApp
{
    public partial class Form1 : Form
    {
        private RdgWebSocket _rdgWebSocket;

        private bool _isConnected = false;

        public bool IsConnected
        {
            get { return _isConnected; }
            set { _isConnected = value; }
        }

        private string _ipAddress = null;

        public string IPAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        //Datamodel for storing receive data
        private DataModel _mainDataModel = new DataModel();

        public DataModel DataModel
        {
            get => _mainDataModel;
            protected set { _mainDataModel = value; }
        }
        
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            IPAddress = textBoxIpAddress.Text;
            if (!IsConnected)
            {
                if (IPAddress != null && Regex.IsMatch(IPAddress,
                    @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
                {
                    Connect();
                }
                else
                {
                    MessageBox.Show("Invalid address IP", "Warning");
                }
            }
            else
            {
                _rdgWebSocket.CloseAsync()?.Wait();
                IsConnected = _rdgWebSocket.IsConnected;
                buttonActionTarring.Enabled = false;
                buttonActionChangePlatform.Enabled = false;
                buttonActionZeroing.Enabled = false;
                buttonConnect.BeginInvoke(new Action(delegate { buttonConnect.Text = "Connect"; }));
            }
        }
        
        //Performing connection with device
        private void Connect()
        {
            //Preparing connection
            try
            {
                //Initializing websocket
                _rdgWebSocket = new RdgWebSocket();
                //Connect to websocket
                _rdgWebSocket.ConnectAsync(IPAddress, 4101)?.Wait();
                //Initialize websocket data listner
                _rdgWebSocket.Listen();
                //Sent a command to register a listener for mod info data
                WebSocketCommands.SendCommand("REGISTER_LISTENER", "MOD_INFO");
                //Enabling buttons after connect
                buttonActionTarring.Enabled = true;
                buttonActionChangePlatform.Enabled = true;
                buttonActionZeroing.Enabled = true;
                buttonConnect.BeginInvoke(new Action(delegate { buttonConnect.Text = "Disconnect"; }));
            }
            catch
            {
                MessageBox.Show("Connection to the device has failed.", "Error trying to connect");
            }

            //Message received event
            _rdgWebSocket.MessageReached += (sender, args) =>
            {
                JsonDocument? jsonElement = null;
                try
                {
                    //Parsing message to json document and checking received command
                    jsonElement = JsonDocument.Parse(args.Message);
                    if (jsonElement.RootElement.GetProperty("COMMAND").ToString().Equals("MOD_INFO"))
                    {
                        //Deserialize received data to DataModel
                        DataModel = System.Text.Json.JsonSerializer.Deserialize<DataModel>(args.Message);
                        IsConnected = _rdgWebSocket.IsConnected;

                        //Set active platform image
                        buttonActionChangePlatform.Invoke(new Action(delegate()
                        {
                            switch (DataModel.RECORD.ActivePlatformIndex)
                            {
                                case 0:
                                    buttonActionChangePlatform.BackgroundImage = Resources.Platform_1;
                                    break;
                                case 1:
                                    buttonActionChangePlatform.BackgroundImage = Resources.Platform_2;
                                    break;
                                case 2:
                                    buttonActionChangePlatform.BackgroundImage = Resources.Platform_3;
                                    break;
                                case 3:
                                    buttonActionChangePlatform.BackgroundImage = Resources.Platform_4;
                                    break;
                            }
                        }));
                        //Set active platform mass value
                        labelMass.Invoke(new Action(delegate()
                        {
                            labelMass.Text = DataModel.RECORD.ActivePlatformMass.NetAct.Value;
                        }));
                        //Set active platform unit
                        labelUnit.Invoke(new Action(delegate()
                        {
                            labelUnit.Text = DataModel.RECORD.ActivePlatformMass.NetAct.Unit;
                        }));  
                        //Set date and time from scale
                        labelOfDate.Invoke(new Action(delegate()
                        {
                            labelOfDate.Text = DataModel.RECORD.Date;
                        }));
                        //Set progressbar
                        progressBarMass.Invoke(new Action(delegate()
                        {
                            progressBarMass.Minimum = 0;
                            var max = Convert.ToInt32(DataModel?.RECORD?.ActivePlatformMass?.MaxAct);
                            if (max < 0) max = 0;
                                progressBarMass.Maximum = max;
                                
                            var value = Convert.ToInt32(DataModel?.RECORD?.ActivePlatformMass?.NetAct?.Value!);
                            if (value < 0) value = 0;
                                progressBarMass.Value = value;

                        }));
                        //Set icons Stability, Zero, Tare
                        pictureBoxStability.Invoke(new Action(delegate()
                        {
                        pictureBoxStability.Image = DataModel.RECORD.ActivePlatformMass.IsStab ? Resources.Stability : SetImageOpacity(Resources.Stability, 0.5F);
                        }));
                        pictureBoxZero.Invoke(new Action(delegate()
                        {
                        pictureBoxZero.Image = DataModel.RECORD.ActivePlatformMass.IsZero ? Resources.Zeroing : SetImageOpacity(Resources.Zeroing, 0.5F);
                        }));
                        pictureBoxTare.Invoke(new Action(delegate()
                        {
                        pictureBoxTare.Image = DataModel.RECORD.ActivePlatformMass.IsTare ? Resources.Net : SetImageOpacity(Resources.Net, 0.5F);
                        }));

                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    IsConnected = _rdgWebSocket.IsConnected;
                }
            };
        }

        //Commands
        private void buttonActionChangePlatform_Click(object sender, EventArgs e)
        {
            WebSocketCommands.SendCommand("EXECUTE_ACTION", "ActionChangePlatform");
        }

        private void buttonActionTarring_Click(object sender, EventArgs e)
        {
            WebSocketCommands.SendCommand("EXECUTE_ACTION", "ActionTarring");
        }

        private void buttonActionZeroing_Click(object sender, EventArgs e)
        {
            WebSocketCommands.SendCommand("EXECUTE_ACTION", "ActionZeroing");
        }
        
        //Others
        public Image SetImageOpacity(Image image, float opacity) {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp)) {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                    ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
        
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }
    }
}