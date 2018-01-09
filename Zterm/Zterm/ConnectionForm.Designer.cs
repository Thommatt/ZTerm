namespace Zterm
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTCP = new System.Windows.Forms.Button();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTCP = new System.Windows.Forms.Panel();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelLogging = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSetLogPath = new System.Windows.Forms.Button();
            this.checkBoxEnableLogging = new System.Windows.Forms.CheckBox();
            this.buttonLoggingTab = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSerial.SuspendLayout();
            this.panelTCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelLogging.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 22);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonLoggingTab);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.buttonTCP);
            this.panel2.Controls.Add(this.buttonSerial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 156);
            this.panel2.TabIndex = 1;
            // 
            // buttonTCP
            // 
            this.buttonTCP.BackColor = System.Drawing.Color.White;
            this.buttonTCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTCP.FlatAppearance.BorderSize = 0;
            this.buttonTCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonTCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTCP.Image = ((System.Drawing.Image)(resources.GetObject("buttonTCP.Image")));
            this.buttonTCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTCP.Location = new System.Drawing.Point(0, 46);
            this.buttonTCP.Name = "buttonTCP";
            this.buttonTCP.Size = new System.Drawing.Size(133, 46);
            this.buttonTCP.TabIndex = 1;
            this.buttonTCP.Text = "TCP";
            this.buttonTCP.UseVisualStyleBackColor = false;
            this.buttonTCP.Click += new System.EventHandler(this.buttonTCP_Click);
            // 
            // buttonSerial
            // 
            this.buttonSerial.BackColor = System.Drawing.Color.Orange;
            this.buttonSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSerial.FlatAppearance.BorderSize = 0;
            this.buttonSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerial.ForeColor = System.Drawing.Color.Black;
            this.buttonSerial.Image = ((System.Drawing.Image)(resources.GetObject("buttonSerial.Image")));
            this.buttonSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSerial.Location = new System.Drawing.Point(0, 0);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(133, 46);
            this.buttonSerial.TabIndex = 0;
            this.buttonSerial.Text = "Serial";
            this.buttonSerial.UseVisualStyleBackColor = false;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(135, 87);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(213, 69);
            this.panel3.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(5, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 59);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(105, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 59);
            this.panel4.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(110, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 59);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelSerial
            // 
            this.panelSerial.BackColor = System.Drawing.Color.Transparent;
            this.panelSerial.Controls.Add(this.comboBoxBaud);
            this.panelSerial.Controls.Add(this.label3);
            this.panelSerial.Controls.Add(this.comboBoxCOM);
            this.panelSerial.Controls.Add(this.label2);
            this.panelSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerial.Location = new System.Drawing.Point(135, 0);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Padding = new System.Windows.Forms.Padding(5);
            this.panelSerial.Size = new System.Drawing.Size(213, 87);
            this.panelSerial.TabIndex = 3;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(5, 66);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(203, 21);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(5, 25);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(203, 21);
            this.comboBoxCOM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "COM Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelTCP
            // 
            this.panelTCP.BackColor = System.Drawing.Color.Transparent;
            this.panelTCP.Controls.Add(this.numericUpDownPort);
            this.panelTCP.Controls.Add(this.label5);
            this.panelTCP.Controls.Add(this.textBoxIP);
            this.panelTCP.Controls.Add(this.label4);
            this.panelTCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTCP.Location = new System.Drawing.Point(135, 0);
            this.panelTCP.Name = "panelTCP";
            this.panelTCP.Padding = new System.Windows.Forms.Padding(5);
            this.panelTCP.Size = new System.Drawing.Size(213, 87);
            this.panelTCP.TabIndex = 4;
            this.panelTCP.Visible = false;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownPort.Location = new System.Drawing.Point(5, 65);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(203, 20);
            this.numericUpDownPort.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port #";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxIP.Location = new System.Drawing.Point(5, 25);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(203, 20);
            this.textBoxIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelLogging);
            this.panelMain.Controls.Add(this.panelSerial);
            this.panelMain.Controls.Add(this.panelTCP);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 22);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(350, 158);
            this.panelMain.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(133, 25);
            this.panel5.TabIndex = 2;
            // 
            // panelLogging
            // 
            this.panelLogging.BackColor = System.Drawing.Color.Transparent;
            this.panelLogging.Controls.Add(this.checkBoxEnableLogging);
            this.panelLogging.Controls.Add(this.panel6);
            this.panelLogging.Controls.Add(this.textBoxLogPath);
            this.panelLogging.Controls.Add(this.label7);
            this.panelLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogging.Location = new System.Drawing.Point(135, 0);
            this.panelLogging.Name = "panelLogging";
            this.panelLogging.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogging.Size = new System.Drawing.Size(213, 87);
            this.panelLogging.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Log File Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLogPath.Location = new System.Drawing.Point(5, 25);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(203, 20);
            this.textBoxLogPath.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonSetLogPath);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 20);
            this.panel6.TabIndex = 6;
            // 
            // buttonSetLogPath
            // 
            this.buttonSetLogPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetLogPath.Location = new System.Drawing.Point(178, 0);
            this.buttonSetLogPath.Name = "buttonSetLogPath";
            this.buttonSetLogPath.Size = new System.Drawing.Size(25, 20);
            this.buttonSetLogPath.TabIndex = 0;
            this.buttonSetLogPath.Text = "...";
            this.buttonSetLogPath.UseVisualStyleBackColor = true;
            this.buttonSetLogPath.Click += new System.EventHandler(this.buttonSetLogPath_Click);
            // 
            // checkBoxEnableLogging
            // 
            this.checkBoxEnableLogging.Checked = true;
            this.checkBoxEnableLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxEnableLogging.ForeColor = System.Drawing.Color.White;
            this.checkBoxEnableLogging.Location = new System.Drawing.Point(5, 65);
            this.checkBoxEnableLogging.Name = "checkBoxEnableLogging";
            this.checkBoxEnableLogging.Size = new System.Drawing.Size(203, 17);
            this.checkBoxEnableLogging.TabIndex = 7;
            this.checkBoxEnableLogging.Text = "Enable Capture/Logging";
            this.checkBoxEnableLogging.UseVisualStyleBackColor = true;
            // 
            // buttonLoggingTab
            // 
            this.buttonLoggingTab.BackColor = System.Drawing.Color.White;
            this.buttonLoggingTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoggingTab.FlatAppearance.BorderSize = 0;
            this.buttonLoggingTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonLoggingTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoggingTab.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoggingTab.Image")));
            this.buttonLoggingTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoggingTab.Location = new System.Drawing.Point(0, 92);
            this.buttonLoggingTab.Name = "buttonLoggingTab";
            this.buttonLoggingTab.Size = new System.Drawing.Size(133, 46);
            this.buttonLoggingTab.TabIndex = 3;
            this.buttonLoggingTab.Text = "Logging";
            this.buttonLoggingTab.UseVisualStyleBackColor = false;
            this.buttonLoggingTab.Click += new System.EventHandler(this.buttonLoggingTab_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectionForm";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelSerial.ResumeLayout(false);
            this.panelTCP.ResumeLayout(false);
            this.panelTCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelLogging.ResumeLayout(false);
            this.panelLogging.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTCP;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.Panel panelTCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonLoggingTab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelLogging;
        private System.Windows.Forms.CheckBox checkBoxEnableLogging;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonSetLogPath;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Label label7;

    }
}