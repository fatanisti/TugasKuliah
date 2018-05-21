namespace FrameProcessing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.streamLocCam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseVid = new System.Windows.Forms.Button();
            this.streamLocVid = new System.Windows.Forms.RadioButton();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.streamIPCam = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Camera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(434, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 302);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "No Video Selected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // streamLocCam
            // 
            this.streamLocCam.AutoSize = true;
            this.streamLocCam.Checked = true;
            this.streamLocCam.Location = new System.Drawing.Point(15, 28);
            this.streamLocCam.Name = "streamLocCam";
            this.streamLocCam.Size = new System.Drawing.Size(97, 17);
            this.streamLocCam.TabIndex = 10;
            this.streamLocCam.TabStop = true;
            this.streamLocCam.Text = "Local Webcam";
            this.streamLocCam.UseVisualStyleBackColor = true;
            this.streamLocCam.CheckedChanged += new System.EventHandler(this.streamLocCam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseVid);
            this.groupBox1.Controls.Add(this.streamLocVid);
            this.groupBox1.Controls.Add(this.inputIP);
            this.groupBox1.Controls.Add(this.streamIPCam);
            this.groupBox1.Controls.Add(this.streamLocCam);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Stream";
            // 
            // browseVid
            // 
            this.browseVid.Location = new System.Drawing.Point(690, 25);
            this.browseVid.Name = "browseVid";
            this.browseVid.Size = new System.Drawing.Size(75, 23);
            this.browseVid.TabIndex = 14;
            this.browseVid.Text = "Browse...";
            this.browseVid.UseVisualStyleBackColor = true;
            this.browseVid.Click += new System.EventHandler(this.browseVid_Click);
            // 
            // streamLocVid
            // 
            this.streamLocVid.AutoSize = true;
            this.streamLocVid.Location = new System.Drawing.Point(585, 28);
            this.streamLocVid.Name = "streamLocVid";
            this.streamLocVid.Size = new System.Drawing.Size(99, 17);
            this.streamLocVid.TabIndex = 13;
            this.streamLocVid.TabStop = true;
            this.streamLocVid.Text = "Video from Disk";
            this.streamLocVid.UseVisualStyleBackColor = true;
            this.streamLocVid.CheckedChanged += new System.EventHandler(this.streamLocVid_CheckedChanged);
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(365, 27);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(150, 20);
            this.inputIP.TabIndex = 12;
            this.inputIP.Text = "192.168.43.1:8080";
            // 
            // streamIPCam
            // 
            this.streamIPCam.AutoSize = true;
            this.streamIPCam.Location = new System.Drawing.Point(285, 28);
            this.streamIPCam.Name = "streamIPCam";
            this.streamIPCam.Size = new System.Drawing.Size(74, 17);
            this.streamIPCam.TabIndex = 11;
            this.streamIPCam.TabStop = true;
            this.streamIPCam.Text = "IP Camera";
            this.streamIPCam.UseVisualStyleBackColor = true;
            this.streamIPCam.CheckedChanged += new System.EventHandler(this.streamIPCam_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Threshold (Auto)",
            "Sepia",
            "Channel Filtering",
            "Red Object Saturation Update"});
            this.comboBox2.Location = new System.Drawing.Point(478, 409);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Frame Processing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton streamLocCam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.RadioButton streamIPCam;
        private System.Windows.Forms.Button browseVid;
        private System.Windows.Forms.RadioButton streamLocVid;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}

