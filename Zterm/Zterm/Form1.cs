using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Zterm
{
    public partial class Form1 : Form
    {
        public const int WM_VSCROLL = 0x0115;
        public const int SB_BOTTOM = 7;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int HT_CLIENT = 0x1;
        public const int WM_NCHITTEST = 0x0084;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        TimeSpan currentTS = new TimeSpan();

        private SendType currentConnectionType = SendType.Serial;
        private MetLogger mlogger = new MetLogger();

        private enum SendType
        {
            TCP,
            Serial
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HT_CLIENT)
                    {
                        m.Result = (IntPtr)HT_CAPTION;
                    }
                    break;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x40000;
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFont.BackColor = Color.SkyBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFont.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClearText.BackColor = Color.SkyBlue;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClearText.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSettings.BackColor = Color.SkyBlue;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSettings.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            labelAbout.BackColor = Color.SkyBlue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            labelAbout.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.SkyBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            labelMaximize.BackColor = Color.SkyBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelMaximize.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.LightPink;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ConnectionForm cf = new ConnectionForm();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                DisconnectPorts();

                if (Zterm.Properties.Settings.Default.isTCP)
                {
                    currentConnectionType = SendType.TCP;
                }
                else
                {
                    currentConnectionType = SendType.Serial;
                }

                do_conn_status();
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //scroll terminal to latest char
                richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
                SendMessage(richTextBoxConsole.Handle, WM_VSCROLL, SB_BOTTOM, 0);

                //Send character to port
                SendCommand(currentConnectionType, e.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();

            toolStripStatusLabel2.Text = assemName.Name;
            toolStripStatusLabel2.Text = "Version " + assemName.Version.Major + "." + assemName.Version.Minor + "." + assemName.Version.Build;

            pictureBoxBackColor.BackColor = Zterm.Properties.Settings.Default.BackColor;
            richTextBoxConsole.BackColor = Zterm.Properties.Settings.Default.BackColor;

            pictureBoxForeColor.BackColor = Zterm.Properties.Settings.Default.ForeColor;
            richTextBoxConsole.ForeColor = Zterm.Properties.Settings.Default.ForeColor;
            richTextBoxConsole.Font = Zterm.Properties.Settings.Default.Font;

            if (string.IsNullOrEmpty(Zterm.Properties.Settings.Default.LogSavePath))
            {
                Zterm.Properties.Settings.Default.LogSavePath = Path.Combine(Application.StartupPath, "log.txt");
            }

            do_conn_status();

            toolTip1.SetToolTip(pictureBoxFont, "Set Font");
            toolTip1.SetToolTip(pictureBoxWordWrap, "Word Wrap");
            toolTip1.SetToolTip(pictureBoxClearText, "Clear Terminal");
            toolTip1.SetToolTip(pictureBoxBackColor, "Set Back Color");
            toolTip1.SetToolTip(pictureBoxForeColor, "Set Fore Color");
            toolTip1.SetToolTip(pictureBoxSettings, "Settings");
            toolTip1.SetToolTip(labelAbout, "About");
            toolTip1.SetToolTip(labelMinimize, "Minimize");
            toolTip1.SetToolTip(labelMaximize, "Maximize");
            toolTip1.SetToolTip(labelClose, "Exit");
        }

        private void do_conn_status()
        {
            if (Zterm.Properties.Settings.Default.isTCP)
            {
                toolStripStatusLabelConnection.Text = string.Format("{0}, {1}", Zterm.Properties.Settings.Default.ipaddress, Zterm.Properties.Settings.Default.ipPort);
            }
            else
            {
                toolStripStatusLabelConnection.Text = string.Format("{0}, {1}", Zterm.Properties.Settings.Default.COMPort, Zterm.Properties.Settings.Default.Baud);
            }
        }

        private void SendCommand(SendType st, string s)
        {
            ConnectPorts(st);

            if (Zterm.Properties.Settings.Default.LogEnabled)
            {
                //do_logging(s, true);
            }

            if (st == SendType.Serial)
            {
                serialPort1.Write(s);
            }
            else
            {
                clientSocketControl1.WriteAsync(s);
            }
        }

        //private void do_logging(string s, bool newLine)
        //{
        //    string d = Path.GetDirectoryName(Zterm.Properties.Settings.Default.LogSavePath);

        //    if (!Directory.Exists(d))
        //    {
        //        Directory.CreateDirectory(d);
        //        Thread.Sleep(100);
        //    }

        //    StreamWriter sw = File.AppendText(Zterm.Properties.Settings.Default.LogSavePath);

        //    if (newLine)
        //        sw.WriteLine(s);
        //    else
        //        sw.Write(s);

        //    sw.Close();
        //}

        private void ConnectPorts(SendType st)
        {
            switch (st)
            {
                case SendType.Serial:
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.BaudRate = Zterm.Properties.Settings.Default.Baud;
                        serialPort1.PortName = Zterm.Properties.Settings.Default.COMPort;

                        serialPort1.Open();
                        toolStripStatusLabel1.Text = "Connected";
                        toolStripSplitButtonConnect.Visible = false;
                        toolStripSplitButtonDisc.Visible = true;
                    }
                    break;
                case SendType.TCP:
                    if (!clientSocketControl1.IsConnected)
                    {
                        clientSocketControl1.RemoteIpAddress = Zterm.Properties.Settings.Default.ipaddress;
                        clientSocketControl1.IpPortNumber = Zterm.Properties.Settings.Default.ipPort;

                        clientSocketControl1.Connect();
                        toolStripStatusLabel1.Text = "Connected";
                        toolStripSplitButtonConnect.Visible = false;
                        toolStripSplitButtonDisc.Visible = true;
                    }
                    break;
            }
        }

        MetLogger ML = new MetLogger();
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting();
            //Console.WriteLine(data);

            this.Invoke((MethodInvoker)delegate
            {
                //richTextBoxConsole.Text += data;
                //do_logging(data, false);

                foreach (char c in data)
                {
                    //do_logging(c + "", false);
                    mlogger.do_logger(c);
                    richTextBoxConsole.AppendText(c + "");

                    if (c == '\b')
                    {
                        richTextBoxConsole.Text = richTextBoxConsole.Text.Substring(0, richTextBoxConsole.Text.Length - 2);
                    }
                }
                richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
                SendMessage(richTextBoxConsole.Handle, WM_VSCROLL, SB_BOTTOM, 0);
            });
        }

        private void clientSocketControl1_OnDataAvailable(object sender, WindowsFormsApplication1.SocketPortDataEventArgs e)
        {
            Byte[] Data = new Byte[e.Argument.ClientSocketCtrl.Available];
            e.Argument.ClientSocketCtrl.Read(Data);

            this.Invoke((MethodInvoker)delegate
            {
                foreach (char c in Data)
                {
                    //do_logging(c + "", false);
                    mlogger.do_logger(c);
                    richTextBoxConsole.AppendText(c + "");

                    if (c == '\b')
                    {
                        richTextBoxConsole.Text = richTextBoxConsole.Text.Substring(0, richTextBoxConsole.Text.Length - 2);
                    }
                }
                richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
                SendMessage(richTextBoxConsole.Handle, WM_VSCROLL, SB_BOTTOM, 0);
            });

            e.Argument.ClientSocketCtrl.ResetDataAvailableNotification();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure you want to close all connections and quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DR == System.Windows.Forms.DialogResult.Yes)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();

                if (clientSocketControl1.IsConnected)
                    clientSocketControl1.Disconnect();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void labelAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.StartPosition = FormStartPosition.CenterScreen;
            ab.Show();
        }

        private void pictureBoxFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxConsole.Font = fd.Font;

                Zterm.Properties.Settings.Default.Font = fd.Font;
                Zterm.Properties.Settings.Default.Save();
            }
        }

        private void pictureBoxClearText_Click(object sender, EventArgs e)
        {
            richTextBoxConsole.Clear();
        }

        private void pictureBoxBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxConsole.BackColor = cd.Color;
                pictureBoxBackColor.BackColor = cd.Color;

                Zterm.Properties.Settings.Default.BackColor = cd.Color;
                Zterm.Properties.Settings.Default.Save();
            }
        }

        private void pictureBoxForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxConsole.ForeColor = cd.Color;
                pictureBoxForeColor.BackColor = cd.Color;

                Zterm.Properties.Settings.Default.ForeColor = cd.Color;
                Zterm.Properties.Settings.Default.Save();
            }
        }

        private void timerConnected_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || clientSocketControl1.IsConnected)
            {
                currentTS = currentTS.Add(TimeSpan.FromSeconds(1));
                toolStripStatusLabel1.Text = string.Format("Connected: {0}", currentTS.ToString());
            }
            else
            {
                currentTS = TimeSpan.Zero;
                toolStripStatusLabel1.Text = "Disconnected";
            }
        }

        private void DisconnectPorts()
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            if (clientSocketControl1.IsConnected)
                clientSocketControl1.Disconnect();

            toolStripSplitButtonDisc.Text = "Disconnected";
            toolStripSplitButtonConnect.Visible = true;
            toolStripSplitButtonDisc.Visible = false;
        }

        private void pictureBoxWordWrap_Click(object sender, EventArgs e)
        {
            richTextBoxConsole.WordWrap = !richTextBoxConsole.WordWrap;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBoxWordWrap_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxWordWrap.BackColor = Color.RoyalBlue;
        }

        private void pictureBoxWordWrap_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxWordWrap.BackColor = Color.FromArgb(47, 47, 47);
        }

        private void toolStripSplitButtonConnect_Click(object sender, EventArgs e)
        {
            if (Zterm.Properties.Settings.Default.isTCP)
            {
                ConnectPorts(SendType.TCP);
            }
            else
            {
                ConnectPorts(SendType.Serial);
            }
        }

        private void toolStripSplitButtonDisc_Click(object sender, EventArgs e)
        {
            DisconnectPorts();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ////(char)13
            //try
            //{
            //    string s;

            //    //scroll terminal to latest char
            //    richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
            //    SendMessage(richTextBoxConsole.Handle, WM_VSCROLL, SB_BOTTOM, 0);

            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        s = (char)13 + "";
            //    }
            //    else
            //    {
            //        s = e.KeyData.ToString();
            //    }

            //    //Send character to port
            //    SendCommand(currentConnectionType, s);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void richTextBoxConsole_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    //scroll terminal to latest char
            //    richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
            //    SendMessage(richTextBoxConsole.Handle, WM_VSCROLL, SB_BOTTOM, 0);
            //}
        }

        private void toolStripStatusLabelConnection_Click(object sender, EventArgs e)
        {
            ConnectionForm cf = new ConnectionForm();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                DisconnectPorts();

                if (Zterm.Properties.Settings.Default.isTCP)
                {
                    currentConnectionType = SendType.TCP;
                }
                else
                {
                    currentConnectionType = SendType.Serial;
                }

                do_conn_status();
            }
        }

        private void toolStripStatusLabelConnection_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelConnection.BorderSides = ToolStripStatusLabelBorderSides.All;
        }

        private void toolStripStatusLabelConnection_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelConnection.BorderSides = ToolStripStatusLabelBorderSides.None;
        }

        private void toolStripSplitButtonOpenLog_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(Zterm.Properties.Settings.Default.LogSavePath));
        }
    }
}
