using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace Zterm
{
    public partial class ConnectionForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //private string connType = "";
        private bool isTCP = true;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonSerial_Click(object sender, EventArgs e)
        {
            panelTCP.Visible = false;
            panelLogging.Visible = false;

            panelSerial.Visible = true;
            panelSerial.Dock = DockStyle.Fill;

            buttonSerial.BackColor = Color.Orange;
            buttonTCP.BackColor = Color.White;
            buttonLoggingTab.BackColor = Color.White;

            isTCP = false;
        }

        private void buttonTCP_Click(object sender, EventArgs e)
        {
            panelSerial.Visible = false;
            panelLogging.Visible = false;

            panelTCP.Visible = true;
            panelTCP.Dock = DockStyle.Fill;

            buttonSerial.BackColor = Color.White;
            buttonTCP.BackColor = Color.Orange;
            buttonLoggingTab.BackColor = Color.White;

            isTCP = true;
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            GetCOMPorts();
            ReadConfig();
        }

        private void ReadConfig()
        {
            try
            {
                textBoxIP.Text = Zterm.Properties.Settings.Default.ipaddress;
                numericUpDownPort.Value = Zterm.Properties.Settings.Default.ipPort;
                comboBoxCOM.SelectedIndex = comboBoxCOM.FindStringExact(Zterm.Properties.Settings.Default.COMPort);
                comboBoxBaud.SelectedIndex = comboBoxBaud.FindStringExact(Zterm.Properties.Settings.Default.Baud.ToString());
                textBoxLogPath.Text = Zterm.Properties.Settings.Default.LogSavePath;

                if (Zterm.Properties.Settings.Default.LogEnabled)
                    checkBoxEnableLogging.Checked = true;
                else
                    checkBoxEnableLogging.Checked = false;

                if (Zterm.Properties.Settings.Default.isTCP)
                {
                    buttonTCP.PerformClick();
                }
                else
                {
                    buttonSerial.PerformClick();
                }
            }
            catch
            {

            }
        }

        private void GetCOMPorts()
        {
            comboBoxCOM.Items.Clear();

            string[] theSerialPortNames = System.IO.Ports.SerialPort.GetPortNames();

            foreach (String s in theSerialPortNames)
            {
                comboBoxCOM.Items.Add(s);
            }

            comboBoxCOM.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WriteConfig();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void WriteConfig()
        {
            try
            {
                if (isTCP)
                {
                    Zterm.Properties.Settings.Default.isTCP = true;
                }
                else
                {
                    Zterm.Properties.Settings.Default.isTCP = false;
                }

                Zterm.Properties.Settings.Default.ipaddress = textBoxIP.Text;
                Zterm.Properties.Settings.Default.ipPort = (int)numericUpDownPort.Value;
                Zterm.Properties.Settings.Default.COMPort = comboBoxCOM.SelectedItem.ToString();
                Zterm.Properties.Settings.Default.Baud = int.Parse(comboBoxBaud.SelectedItem.ToString());

                if (checkBoxEnableLogging.Checked)
                {
                    Zterm.Properties.Settings.Default.LogEnabled = true;
                }
                else
                {
                    Zterm.Properties.Settings.Default.LogEnabled = false;
                }

                Zterm.Properties.Settings.Default.LogSavePath = textBoxLogPath.Text;

                Zterm.Properties.Settings.Default.Save();
            }
            catch
            {

            }
        }

        private void buttonSetLogPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text (.txt)|*.txt|Log (.log)|*.log";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                textBoxLogPath.Text = sd.FileName;
            }
        }

        private void buttonLoggingTab_Click(object sender, EventArgs e)
        {
            panelSerial.Visible = false;
            panelTCP.Visible = false;

            panelLogging.Visible = true;
            panelLogging.Dock = DockStyle.Fill;

            buttonSerial.BackColor = Color.White;
            buttonLoggingTab.BackColor = Color.Orange;
            buttonTCP.BackColor = Color.White;
        }
    }
}
