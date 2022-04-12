using System.Net.WebSockets;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using SampleWpfApp.DataModels;
using SampleWpfApp.Views;
using Services;
using Services.Commands;

namespace SampleWpfApp.ViewModels
{
    public class MainViewModel : PropViewModelBase
    {
        private RdgWebSocket _rdgWebSocket;
        private readonly CommandBindingCollection _commandBindingCollection = new CommandBindingCollection();

        private bool _isConnected = false;

        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                OnPropertyChanged();
            }
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
            protected set
            {
                _mainDataModel = value;
                OnPropertyChanged();
            }
        }
        

        //Commands
        public RoutedUICommand ExecuteActionCommand { get; set; } =
            new RoutedUICommand("SendCommand", "SendCommand", typeof(MainWindow));

        private void OnExecuteActionCommandExecuted(object sender, ExecutedRoutedEventArgs eventArgs)
        {
            WebSocketCommands.SendCommand("EXECUTE_ACTION", eventArgs.Parameter.ToString()!);
        }

        public RoutedUICommand ExecuteConnectCommand { get; set; } =
            new RoutedUICommand("ConnectCommand", "ConnectCommand", typeof(MainWindow));

        private void OnExecuteConnectCommandExecuted(object sender, ExecutedRoutedEventArgs eventArgs)
        {
            if(!IsConnected)
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
            }
        }
        
        public CommandBindingCollection Commands
        {
            get
            {
                _commandBindingCollection.Add(new CommandBinding(ExecuteActionCommand,
                    (o, args) => OnExecuteActionCommandExecuted(o, args)));
                _commandBindingCollection.Add(new CommandBinding(ExecuteConnectCommand,
                    (o, args) => OnExecuteConnectCommandExecuted(o, args)));
                return _commandBindingCollection;
            }
        }
        
        //Performing connection with device
        private void Connect()
        {
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
              
            }
            catch
            {
                MessageBox.Show("Connection to the device has failed.", "Error trying to connect");
            }

            //Message received event
            _rdgWebSocket.MessageReached += (sender, args) =>
            {
                IsConnected = _rdgWebSocket.IsConnected;
                try
                {
                    //Deserialize received data to DataModel
                    DataModel = System.Text.Json.JsonSerializer.Deserialize<DataModel>(args.Message);
                }
                catch
                {
                    IsConnected = _rdgWebSocket.IsConnected;
                }
            };
        }
    }
}