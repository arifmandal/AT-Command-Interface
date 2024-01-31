namespace AT_Commands_Control
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prgStatusBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpTransmitReceiver = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtTransmit = new System.Windows.Forms.TextBox();
            this.grpATCommands = new System.Windows.Forms.GroupBox();
            this.btnRESTORE = new System.Windows.Forms.Button();
            this.btnROLE = new System.Windows.Forms.Button();
            this.btnUART = new System.Windows.Forms.Button();
            this.btnPASSWORD = new System.Windows.Forms.Button();
            this.btnNAME = new System.Windows.Forms.Button();
            this.btnADDRESS = new System.Windows.Forms.Button();
            this.btnVERSION = new System.Windows.Forms.Button();
            this.btnAT = new System.Windows.Forms.Button();
            this.grpChangeParameters = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChangeParameters = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.txtBLUARTParameters = new System.Windows.Forms.TextBox();
            this.txtBLPassword = new System.Windows.Forms.TextBox();
            this.txtBLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpTransmitReceiver.SuspendLayout();
            this.grpATCommands.SuspendLayout();
            this.grpChangeParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.prgStatusBar);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bluetooth Connection";
            // 
            // prgStatusBar
            // 
            this.prgStatusBar.Location = new System.Drawing.Point(218, 232);
            this.prgStatusBar.Name = "prgStatusBar";
            this.prgStatusBar.Size = new System.Drawing.Size(188, 23);
            this.prgStatusBar.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(238, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(141, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "UNSUCCESSFUL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(11, 213);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(107, 42);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(11, 149);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 42);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Enabled = false;
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(99, 86);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(180, 28);
            this.cbBaudrate.TabIndex = 3;
            this.cbBaudrate.Text = "38400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate:";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(99, 33);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(180, 28);
            this.cbComPort.TabIndex = 1;
            this.cbComPort.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port: ";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grpTransmitReceiver
            // 
            this.grpTransmitReceiver.Controls.Add(this.btnClear);
            this.grpTransmitReceiver.Controls.Add(this.label5);
            this.grpTransmitReceiver.Controls.Add(this.label4);
            this.grpTransmitReceiver.Controls.Add(this.btnSend);
            this.grpTransmitReceiver.Controls.Add(this.txtReceiver);
            this.grpTransmitReceiver.Controls.Add(this.txtTransmit);
            this.grpTransmitReceiver.Location = new System.Drawing.Point(24, 351);
            this.grpTransmitReceiver.Name = "grpTransmitReceiver";
            this.grpTransmitReceiver.Size = new System.Drawing.Size(466, 311);
            this.grpTransmitReceiver.TabIndex = 1;
            this.grpTransmitReceiver.TabStop = false;
            this.grpTransmitReceiver.Text = "Transmit and Receiver";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Receiver";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transmit";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(51, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(218, 61);
            this.txtReceiver.Multiline = true;
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceiver.Size = new System.Drawing.Size(242, 143);
            this.txtReceiver.TabIndex = 1;
            // 
            // txtTransmit
            // 
            this.txtTransmit.Location = new System.Drawing.Point(11, 61);
            this.txtTransmit.Multiline = true;
            this.txtTransmit.Name = "txtTransmit";
            this.txtTransmit.Size = new System.Drawing.Size(175, 143);
            this.txtTransmit.TabIndex = 0;
            // 
            // grpATCommands
            // 
            this.grpATCommands.Controls.Add(this.btnRESTORE);
            this.grpATCommands.Controls.Add(this.btnROLE);
            this.grpATCommands.Controls.Add(this.btnUART);
            this.grpATCommands.Controls.Add(this.btnPASSWORD);
            this.grpATCommands.Controls.Add(this.btnNAME);
            this.grpATCommands.Controls.Add(this.btnADDRESS);
            this.grpATCommands.Controls.Add(this.btnVERSION);
            this.grpATCommands.Controls.Add(this.btnAT);
            this.grpATCommands.Location = new System.Drawing.Point(565, 36);
            this.grpATCommands.Name = "grpATCommands";
            this.grpATCommands.Size = new System.Drawing.Size(330, 272);
            this.grpATCommands.TabIndex = 2;
            this.grpATCommands.TabStop = false;
            this.grpATCommands.Text = "AT Commands";
            // 
            // btnRESTORE
            // 
            this.btnRESTORE.Location = new System.Drawing.Point(191, 197);
            this.btnRESTORE.Name = "btnRESTORE";
            this.btnRESTORE.Size = new System.Drawing.Size(121, 37);
            this.btnRESTORE.TabIndex = 7;
            this.btnRESTORE.Text = "RESTORE";
            this.btnRESTORE.UseVisualStyleBackColor = true;
            this.btnRESTORE.Click += new System.EventHandler(this.btnRESTORE_Click);
            // 
            // btnROLE
            // 
            this.btnROLE.Location = new System.Drawing.Point(191, 141);
            this.btnROLE.Name = "btnROLE";
            this.btnROLE.Size = new System.Drawing.Size(121, 37);
            this.btnROLE.TabIndex = 6;
            this.btnROLE.Text = "ROLE";
            this.btnROLE.UseVisualStyleBackColor = true;
            this.btnROLE.Click += new System.EventHandler(this.btnROLE_Click);
            // 
            // btnUART
            // 
            this.btnUART.Location = new System.Drawing.Point(191, 89);
            this.btnUART.Name = "btnUART";
            this.btnUART.Size = new System.Drawing.Size(121, 37);
            this.btnUART.TabIndex = 5;
            this.btnUART.Text = "UART";
            this.btnUART.UseVisualStyleBackColor = true;
            this.btnUART.Click += new System.EventHandler(this.btnUART_Click);
            // 
            // btnPASSWORD
            // 
            this.btnPASSWORD.Location = new System.Drawing.Point(191, 37);
            this.btnPASSWORD.Name = "btnPASSWORD";
            this.btnPASSWORD.Size = new System.Drawing.Size(121, 37);
            this.btnPASSWORD.TabIndex = 4;
            this.btnPASSWORD.Text = "PASSWORD";
            this.btnPASSWORD.UseVisualStyleBackColor = true;
            this.btnPASSWORD.Click += new System.EventHandler(this.btnPASSWORD_Click);
            // 
            // btnNAME
            // 
            this.btnNAME.Location = new System.Drawing.Point(22, 197);
            this.btnNAME.Name = "btnNAME";
            this.btnNAME.Size = new System.Drawing.Size(121, 37);
            this.btnNAME.TabIndex = 3;
            this.btnNAME.Text = "NAME";
            this.btnNAME.UseVisualStyleBackColor = true;
            this.btnNAME.Click += new System.EventHandler(this.btnNAME_Click);
            // 
            // btnADDRESS
            // 
            this.btnADDRESS.Location = new System.Drawing.Point(22, 141);
            this.btnADDRESS.Name = "btnADDRESS";
            this.btnADDRESS.Size = new System.Drawing.Size(121, 37);
            this.btnADDRESS.TabIndex = 2;
            this.btnADDRESS.Text = "ADDRESS";
            this.btnADDRESS.UseVisualStyleBackColor = true;
            this.btnADDRESS.Click += new System.EventHandler(this.btnADDRESS_Click);
            // 
            // btnVERSION
            // 
            this.btnVERSION.Location = new System.Drawing.Point(22, 86);
            this.btnVERSION.Name = "btnVERSION";
            this.btnVERSION.Size = new System.Drawing.Size(121, 37);
            this.btnVERSION.TabIndex = 1;
            this.btnVERSION.Text = "VERSION";
            this.btnVERSION.UseVisualStyleBackColor = true;
            this.btnVERSION.Click += new System.EventHandler(this.btnVERSION_Click);
            // 
            // btnAT
            // 
            this.btnAT.Location = new System.Drawing.Point(22, 37);
            this.btnAT.Name = "btnAT";
            this.btnAT.Size = new System.Drawing.Size(121, 37);
            this.btnAT.TabIndex = 0;
            this.btnAT.Text = "AT";
            this.btnAT.UseVisualStyleBackColor = true;
            this.btnAT.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // grpChangeParameters
            // 
            this.grpChangeParameters.Controls.Add(this.label9);
            this.grpChangeParameters.Controls.Add(this.btnChangeParameters);
            this.grpChangeParameters.Controls.Add(this.btnChangePassword);
            this.grpChangeParameters.Controls.Add(this.btnChangeName);
            this.grpChangeParameters.Controls.Add(this.txtBLUARTParameters);
            this.grpChangeParameters.Controls.Add(this.txtBLPassword);
            this.grpChangeParameters.Controls.Add(this.txtBLName);
            this.grpChangeParameters.Controls.Add(this.label8);
            this.grpChangeParameters.Controls.Add(this.label7);
            this.grpChangeParameters.Controls.Add(this.label6);
            this.grpChangeParameters.Location = new System.Drawing.Point(565, 351);
            this.grpChangeParameters.Name = "grpChangeParameters";
            this.grpChangeParameters.Size = new System.Drawing.Size(537, 311);
            this.grpChangeParameters.TabIndex = 3;
            this.grpChangeParameters.TabStop = false;
            this.grpChangeParameters.Text = "Change Name or Password or Parameters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "(UART Baudrate, Stop Bit, Parity) ex: 115200,0,0";
            // 
            // btnChangeParameters
            // 
            this.btnChangeParameters.Location = new System.Drawing.Point(360, 174);
            this.btnChangeParameters.Name = "btnChangeParameters";
            this.btnChangeParameters.Size = new System.Drawing.Size(171, 33);
            this.btnChangeParameters.TabIndex = 8;
            this.btnChangeParameters.Text = "Change Parameters";
            this.btnChangeParameters.UseVisualStyleBackColor = true;
            this.btnChangeParameters.Click += new System.EventHandler(this.btnChangeParameters_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(360, 114);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(171, 33);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(360, 62);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(171, 33);
            this.btnChangeName.TabIndex = 6;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtBLUARTParameters
            // 
            this.txtBLUARTParameters.Location = new System.Drawing.Point(169, 177);
            this.txtBLUARTParameters.Name = "txtBLUARTParameters";
            this.txtBLUARTParameters.Size = new System.Drawing.Size(175, 26);
            this.txtBLUARTParameters.TabIndex = 5;
            // 
            // txtBLPassword
            // 
            this.txtBLPassword.Location = new System.Drawing.Point(169, 117);
            this.txtBLPassword.Name = "txtBLPassword";
            this.txtBLPassword.Size = new System.Drawing.Size(175, 26);
            this.txtBLPassword.TabIndex = 4;
            // 
            // txtBLName
            // 
            this.txtBLName.Location = new System.Drawing.Point(169, 65);
            this.txtBLName.Name = "txtBLName";
            this.txtBLName.Size = new System.Drawing.Size(175, 26);
            this.txtBLName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "UART Parameters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name: ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::AT_Commands_Control.Properties.Resources.refresh_icon_transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(285, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 31);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(431, 672);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(202, 20);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "AT Commands Control v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 701);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.grpChangeParameters);
            this.Controls.Add(this.grpATCommands);
            this.Controls.Add(this.grpTransmitReceiver);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AT Commands Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTransmitReceiver.ResumeLayout(false);
            this.grpTransmitReceiver.PerformLayout();
            this.grpATCommands.ResumeLayout(false);
            this.grpChangeParameters.ResumeLayout(false);
            this.grpChangeParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgStatusBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpTransmitReceiver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtTransmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpATCommands;
        private System.Windows.Forms.Button btnNAME;
        private System.Windows.Forms.Button btnADDRESS;
        private System.Windows.Forms.Button btnVERSION;
        private System.Windows.Forms.Button btnAT;
        private System.Windows.Forms.Button btnRESTORE;
        private System.Windows.Forms.Button btnROLE;
        private System.Windows.Forms.Button btnUART;
        private System.Windows.Forms.Button btnPASSWORD;
        private System.Windows.Forms.GroupBox grpChangeParameters;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox txtBLUARTParameters;
        private System.Windows.Forms.TextBox txtBLPassword;
        private System.Windows.Forms.TextBox txtBLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangeParameters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblVersion;
    }
}

