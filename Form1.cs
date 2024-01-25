using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AT_Commands_Control
{
    public partial class Form1 : Form
    {
        string dataOut;
        string dataIn;
        string BLName;
        string BLPassword;
        string BLParameters;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VScrollBar vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.Scroll += (s, ev) => { txtReceiver.SelectionStart = (int)((VScrollBar)s).Value; };
            Controls.Add(vScrollBar);
            txtReceiver.ScrollBars = ScrollBars.None;

            String[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);


            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            cbComPort.Enabled = true;
            prgStatusBar.Value = 0;
            grpTransmitReceiver.Enabled = false;
            grpATCommands.Enabled = false;
            grpChangeParameters.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cbComPort.Text;
            serialPort1.BaudRate = 38400;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;

            try 
            { 
                serialPort1.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                cbComPort.Enabled = false;
                lblStatus.Text = "SUCCESSFUL";
                prgStatusBar.Value = 100;

                grpTransmitReceiver.Enabled = true;
                grpATCommands.Enabled = true;
                grpChangeParameters.Enabled = true;




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                lblStatus.Text = "UNSUCCESSFUL";

            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cbComPort.Enabled = true;
                lblStatus.Text = "UNSUCCESSFUL";
                prgStatusBar.Value = 0;

                grpTransmitReceiver.Enabled = false;
                grpATCommands.Enabled = false;
                grpChangeParameters.Enabled = false;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = txtTransmit.Text + "\r\n";
                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { 
            int bytesToRead = serialPort1.BytesToRead;

            byte[] buffer = new byte[bytesToRead];

            serialPort1.Read(buffer, 0, bytesToRead);

            dataIn = Encoding.ASCII.GetString(buffer);

            this.Invoke(new Action(()=>{

                txtReceiver.Text += dataIn + Environment.NewLine;
                txtReceiver.SelectionStart = txtReceiver.TextLength;
                txtReceiver.ScrollToCaret();


            }));
            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceiver.Text = string.Empty; 

        }


        private void btnAT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }

        }

        private void btnVERSION_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+VERSION?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnADDRESS_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+ADDR?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnNAME_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+NAME?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnPASSWORD_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+PSWD?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnUART_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+UART?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnROLE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+ROLE?" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnRESTORE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+ORGL" + "\r\n";

                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);

                serialPort1.Write(byteData, 0, byteData.Length);
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            BLName = txtBLName.Text;
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+NAME=" + BLName + "\r\n";
                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);
                serialPort1.Write(byteData, 0, byteData.Length);
            }

            txtBLName.Text = String.Empty;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            BLPassword = txtBLPassword.Text;
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+PSWD=" + BLPassword + "\r\n";
                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);
                serialPort1.Write(byteData, 0, byteData.Length);
            }
            txtBLPassword.Text = String.Empty;
        }

        private void btnChangeParameters_Click(object sender, EventArgs e)
        {
            BLParameters = txtBLUARTParameters.Text;
            if (serialPort1.IsOpen)
            {
                dataOut = "AT+UART=" + BLParameters + "\r\n";
                byte[] byteData = Encoding.ASCII.GetBytes(dataOut);
                serialPort1.Write(byteData, 0, byteData.Length);
            }

            txtBLUARTParameters.Text = String.Empty;
        }
    }
}
