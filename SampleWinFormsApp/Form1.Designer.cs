using System.Windows.Forms;

namespace SampleWinFormsApp
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxStability = new System.Windows.Forms.PictureBox();
            this.pictureBoxZero = new System.Windows.Forms.PictureBox();
            this.pictureBoxTare = new System.Windows.Forms.PictureBox();
            this.buttonActionChangePlatform = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonActionTarring = new System.Windows.Forms.Button();
            this.buttonActionZeroing = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOfDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarMass = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTare)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonActionChangePlatform, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelOfDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelMass, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelUnit, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 176);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelMass
            // 
            this.labelMass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMass.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.labelMass.Location = new System.Drawing.Point(3, 0);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(310, 176);
            this.labelMass.TabIndex = 0;
            this.labelMass.Text = "------";
            this.labelMass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.Location = new System.Drawing.Point(316, 0);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(79, 176);
            this.labelUnit.TabIndex = 0;
            this.labelUnit.Text = "g";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxStability, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxZero, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxTare, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 176);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pictureBoxStability
            // 
            this.pictureBoxStability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxStability.ErrorImage = global::SampleWinFormsApp.Properties.Resources.Stability;
            this.pictureBoxStability.Image = global::SampleWinFormsApp.Properties.Resources.Stability;
            this.pictureBoxStability.ImageLocation = "";
            this.pictureBoxStability.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStability.InitialImage")));
            this.pictureBoxStability.Location = new System.Drawing.Point(9, 78);
            this.pictureBoxStability.Name = "pictureBoxStability";
            this.pictureBoxStability.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxStability.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStability.TabIndex = 0;
            this.pictureBoxStability.TabStop = false;
            // 
            // pictureBoxZero
            // 
            this.pictureBoxZero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxZero.Image = global::SampleWinFormsApp.Properties.Resources.Zeroing;
            this.pictureBoxZero.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxZero.InitialImage")));
            this.pictureBoxZero.Location = new System.Drawing.Point(67, 38);
            this.pictureBoxZero.Name = "pictureBoxZero";
            this.pictureBoxZero.Size = new System.Drawing.Size(58, 100);
            this.pictureBoxZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxZero.TabIndex = 1;
            this.pictureBoxZero.TabStop = false;
            // 
            // pictureBoxTare
            // 
            this.pictureBoxTare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxTare.Image = global::SampleWinFormsApp.Properties.Resources.Net;
            this.pictureBoxTare.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTare.InitialImage")));
            this.pictureBoxTare.Location = new System.Drawing.Point(131, 63);
            this.pictureBoxTare.Name = "pictureBoxTare";
            this.pictureBoxTare.Size = new System.Drawing.Size(60, 50);
            this.pictureBoxTare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTare.TabIndex = 2;
            this.pictureBoxTare.TabStop = false;
            // 
            // buttonActionChangePlatform
            // 
            this.buttonActionChangePlatform.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonActionChangePlatform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActionChangePlatform.BackgroundImage = global::SampleWinFormsApp.Properties.Resources.Platform_1;
            this.buttonActionChangePlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActionChangePlatform.Enabled = false;
            this.buttonActionChangePlatform.Location = new System.Drawing.Point(604, 112);
            this.buttonActionChangePlatform.Name = "buttonActionChangePlatform";
            this.buttonActionChangePlatform.Padding = new System.Windows.Forms.Padding(1);
            this.buttonActionChangePlatform.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonActionChangePlatform.Size = new System.Drawing.Size(59, 47);
            this.buttonActionChangePlatform.TabIndex = 3;
            this.buttonActionChangePlatform.UseVisualStyleBackColor = true;
            this.buttonActionChangePlatform.Click += new System.EventHandler(this.buttonActionChangePlatform_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonActionTarring, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonActionZeroing, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(203, 321);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(395, 131);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonActionTarring
            // 
            this.buttonActionTarring.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonActionTarring.BackColor = System.Drawing.Color.Transparent;
            this.buttonActionTarring.BackgroundImage = global::SampleWinFormsApp.Properties.Resources.ActionTarring;
            this.buttonActionTarring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonActionTarring.Enabled = false;
            this.buttonActionTarring.Location = new System.Drawing.Point(18, 13);
            this.buttonActionTarring.Name = "buttonActionTarring";
            this.buttonActionTarring.Size = new System.Drawing.Size(160, 104);
            this.buttonActionTarring.TabIndex = 0;
            this.buttonActionTarring.UseVisualStyleBackColor = false;
            this.buttonActionTarring.Click += new System.EventHandler(this.buttonActionTarring_Click);
            // 
            // buttonActionZeroing
            // 
            this.buttonActionZeroing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonActionZeroing.BackColor = System.Drawing.Color.Transparent;
            this.buttonActionZeroing.BackgroundImage = global::SampleWinFormsApp.Properties.Resources.ActionZeroing;
            this.buttonActionZeroing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonActionZeroing.Enabled = false;
            this.buttonActionZeroing.Location = new System.Drawing.Point(216, 13);
            this.buttonActionZeroing.Name = "buttonActionZeroing";
            this.buttonActionZeroing.Size = new System.Drawing.Size(160, 104);
            this.buttonActionZeroing.TabIndex = 1;
            this.buttonActionZeroing.UseVisualStyleBackColor = false;
            this.buttonActionZeroing.Click += new System.EventHandler(this.buttonActionZeroing_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxIpAddress, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonConnect, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(595, 39);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter scale IP address:";
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIpAddress.Location = new System.Drawing.Point(201, 3);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(192, 23);
            this.textBoxIpAddress.TabIndex = 6;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(399, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SampleWinFormsApp.Properties.Resources.logo_rw;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::SampleWinFormsApp.Properties.Resources.logo_rw;
            this.pictureBox1.Location = new System.Drawing.Point(604, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelOfDate
            // 
            this.labelOfDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOfDate.AutoSize = true;
            this.labelOfDate.Location = new System.Drawing.Point(604, 0);
            this.labelOfDate.Name = "labelOfDate";
            this.labelOfDate.Size = new System.Drawing.Size(196, 45);
            this.labelOfDate.TabIndex = 8;
            this.labelOfDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel6, 3);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.progressBarMass, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 230);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(797, 85);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // progressBarMass
            // 
            this.progressBarMass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.progressBarMass, 2);
            this.progressBarMass.Location = new System.Drawing.Point(40, 40);
            this.progressBarMass.Margin = new System.Windows.Forms.Padding(40);
            this.progressBarMass.MinimumSize = new System.Drawing.Size(0, 10);
            this.progressBarMass.Name = "progressBarMass";
            this.progressBarMass.RightToLeftLayout = true;
            this.progressBarMass.Size = new System.Drawing.Size(717, 10);
            this.progressBarMass.Step = 100;
            this.progressBarMass.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarMass.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "0%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(736, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 30, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Sample WinFormsApp. Scale json communication via websocket";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTare)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progressBarMass;
        private Label labelMass;
        private Label labelUnit;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxStability;
        private PictureBox pictureBoxZero;
        private PictureBox pictureBoxTare;
        private Button buttonActionChangePlatform;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonActionTarring;
        private Button buttonActionZeroing;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBoxIpAddress;
        private Button buttonConnect;
        private PictureBox pictureBox1;
        private Label labelOfDate;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private Label label3;
    }
}