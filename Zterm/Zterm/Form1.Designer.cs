namespace Zterm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButtonOpenLog = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonDisc = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxForeColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxClearText = new System.Windows.Forms.PictureBox();
            this.pictureBoxWordWrap = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelMaximize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxFont = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxConsole = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.clientSocketControl1 = new WindowsFormsApplication1.ClientSocketControl(this.components);
            this.timerConnected = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWordWrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFont)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonOpenLog,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelConnection,
            this.toolStripSplitButtonDisc,
            this.toolStripSplitButtonConnect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButtonOpenLog
            // 
            this.toolStripSplitButtonOpenLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonOpenLog.DropDownButtonWidth = 0;
            this.toolStripSplitButtonOpenLog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonOpenLog.Image")));
            this.toolStripSplitButtonOpenLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonOpenLog.Name = "toolStripSplitButtonOpenLog";
            this.toolStripSplitButtonOpenLog.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButtonOpenLog.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonOpenLog.ToolTipText = "Open Log Folder";
            this.toolStripSplitButtonOpenLog.Click += new System.EventHandler(this.toolStripSplitButtonOpenLog_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Disconnected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(510, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 17);
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelConnection.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabelConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelConnection.Text = "COM1, 9600";
            this.toolStripStatusLabelConnection.Click += new System.EventHandler(this.toolStripStatusLabelConnection_Click);
            this.toolStripStatusLabelConnection.MouseEnter += new System.EventHandler(this.toolStripStatusLabelConnection_MouseEnter);
            this.toolStripStatusLabelConnection.MouseLeave += new System.EventHandler(this.toolStripStatusLabelConnection_MouseLeave);
            // 
            // toolStripSplitButtonDisc
            // 
            this.toolStripSplitButtonDisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonDisc.DropDownButtonWidth = 0;
            this.toolStripSplitButtonDisc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonDisc.Image")));
            this.toolStripSplitButtonDisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonDisc.Name = "toolStripSplitButtonDisc";
            this.toolStripSplitButtonDisc.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButtonDisc.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonDisc.ToolTipText = "Disconnect";
            this.toolStripSplitButtonDisc.Visible = false;
            this.toolStripSplitButtonDisc.Click += new System.EventHandler(this.toolStripSplitButtonDisc_Click);
            // 
            // toolStripSplitButtonConnect
            // 
            this.toolStripSplitButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonConnect.DropDownButtonWidth = 0;
            this.toolStripSplitButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonConnect.Image")));
            this.toolStripSplitButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonConnect.Name = "toolStripSplitButtonConnect";
            this.toolStripSplitButtonConnect.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButtonConnect.Text = "toolStripSplitButton2";
            this.toolStripSplitButtonConnect.ToolTipText = "Connect";
            this.toolStripSplitButtonConnect.Click += new System.EventHandler(this.toolStripSplitButtonConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxSettings);
            this.panel1.Controls.Add(this.pictureBoxForeColor);
            this.panel1.Controls.Add(this.pictureBoxBackColor);
            this.panel1.Controls.Add(this.pictureBoxClearText);
            this.panel1.Controls.Add(this.pictureBoxWordWrap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelAbout);
            this.panel1.Controls.Add(this.labelMinimize);
            this.panel1.Controls.Add(this.labelMaximize);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.pictureBoxFont);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 22);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Met One Instruments, Inc.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(100, 0);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSettings.TabIndex = 4;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBoxSettings.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBoxSettings.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // pictureBoxForeColor
            // 
            this.pictureBoxForeColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForeColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxForeColor.Location = new System.Drawing.Point(80, 0);
            this.pictureBoxForeColor.Name = "pictureBoxForeColor";
            this.pictureBoxForeColor.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxForeColor.TabIndex = 3;
            this.pictureBoxForeColor.TabStop = false;
            this.pictureBoxForeColor.Click += new System.EventHandler(this.pictureBoxForeColor_Click);
            // 
            // pictureBoxBackColor
            // 
            this.pictureBoxBackColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBackColor.Location = new System.Drawing.Point(60, 0);
            this.pictureBoxBackColor.Name = "pictureBoxBackColor";
            this.pictureBoxBackColor.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxBackColor.TabIndex = 2;
            this.pictureBoxBackColor.TabStop = false;
            this.pictureBoxBackColor.Click += new System.EventHandler(this.pictureBoxBackColor_Click);
            // 
            // pictureBoxClearText
            // 
            this.pictureBoxClearText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClearText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClearText.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxClearText.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClearText.Image")));
            this.pictureBoxClearText.Location = new System.Drawing.Point(40, 0);
            this.pictureBoxClearText.Name = "pictureBoxClearText";
            this.pictureBoxClearText.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxClearText.TabIndex = 1;
            this.pictureBoxClearText.TabStop = false;
            this.pictureBoxClearText.Click += new System.EventHandler(this.pictureBoxClearText_Click);
            this.pictureBoxClearText.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBoxClearText.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBoxWordWrap
            // 
            this.pictureBoxWordWrap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWordWrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWordWrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWordWrap.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWordWrap.Image")));
            this.pictureBoxWordWrap.Location = new System.Drawing.Point(20, 0);
            this.pictureBoxWordWrap.Name = "pictureBoxWordWrap";
            this.pictureBoxWordWrap.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxWordWrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWordWrap.TabIndex = 17;
            this.pictureBoxWordWrap.TabStop = false;
            this.pictureBoxWordWrap.Click += new System.EventHandler(this.pictureBoxWordWrap_Click);
            this.pictureBoxWordWrap.MouseEnter += new System.EventHandler(this.pictureBoxWordWrap_MouseEnter);
            this.pictureBoxWordWrap.MouseLeave += new System.EventHandler(this.pictureBoxWordWrap_MouseLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(645, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(665, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 15;
            // 
            // labelAbout
            // 
            this.labelAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAbout.Image = ((System.Drawing.Image)(resources.GetObject("labelAbout.Image")));
            this.labelAbout.Location = new System.Drawing.Point(685, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(20, 20);
            this.labelAbout.TabIndex = 14;
            this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
            this.labelAbout.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.labelAbout.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // labelMinimize
            // 
            this.labelMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(705, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(20, 20);
            this.labelMinimize.TabIndex = 13;
            this.labelMinimize.Text = "_";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // labelMaximize
            // 
            this.labelMaximize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximize.ForeColor = System.Drawing.Color.White;
            this.labelMaximize.Location = new System.Drawing.Point(725, 0);
            this.labelMaximize.Name = "labelMaximize";
            this.labelMaximize.Size = new System.Drawing.Size(20, 20);
            this.labelMaximize.TabIndex = 12;
            this.labelMaximize.Text = "□";
            this.labelMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMaximize.Click += new System.EventHandler(this.labelMaximize_Click);
            this.labelMaximize.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.labelMaximize.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(745, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(20, 20);
            this.labelClose.TabIndex = 11;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // pictureBoxFont
            // 
            this.pictureBoxFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxFont.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFont.Image")));
            this.pictureBoxFont.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFont.Name = "pictureBoxFont";
            this.pictureBoxFont.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxFont.TabIndex = 0;
            this.pictureBoxFont.TabStop = false;
            this.pictureBoxFont.Click += new System.EventHandler(this.pictureBoxFont_Click);
            this.pictureBoxFont.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxFont.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.richTextBoxConsole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(767, 472);
            this.panel2.TabIndex = 2;
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsole.Location = new System.Drawing.Point(10, 10);
            this.richTextBoxConsole.Multiline = true;
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.ReadOnly = true;
            this.richTextBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.richTextBoxConsole.Size = new System.Drawing.Size(747, 452);
            this.richTextBoxConsole.TabIndex = 0;
            this.richTextBoxConsole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxConsole_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // clientSocketControl1
            // 
            this.clientSocketControl1.RemoteIpAddress = "127.0.0.1";
            this.clientSocketControl1.SocketClient = null;
            this.clientSocketControl1.OnDataAvailable += new System.EventHandler<WindowsFormsApplication1.SocketPortDataEventArgs>(this.clientSocketControl1_OnDataAvailable);
            // 
            // timerConnected
            // 
            this.timerConnected.Enabled = true;
            this.timerConnected.Interval = 1000;
            this.timerConnected.Tick += new System.EventHandler(this.timerConnected_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWordWrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFont)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBoxForeColor;
        private System.Windows.Forms.PictureBox pictureBoxBackColor;
        private System.Windows.Forms.PictureBox pictureBoxClearText;
        private System.Windows.Forms.PictureBox pictureBoxFont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelMaximize;
        private System.Windows.Forms.Label labelClose;
        private System.IO.Ports.SerialPort serialPort1;
        private WindowsFormsApplication1.ClientSocketControl clientSocketControl1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timerConnected;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonDisc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.PictureBox pictureBoxWordWrap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonConnect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
        private System.Windows.Forms.TextBox richTextBoxConsole;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonOpenLog;
    }
}

