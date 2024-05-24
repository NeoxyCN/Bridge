namespace Bridge
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filetransfer = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_inlist_send = new System.Windows.Forms.Button();
            this.button_inlist_download = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_fs_detail = new System.Windows.Forms.Label();
            this.listBox_filelist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_bycode_download = new System.Windows.Forms.Button();
            this.button_bycode_send = new System.Windows.Forms.Button();
            this.textBox_fileCode = new System.Windows.Forms.TextBox();
            this.textpaste = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox_pastelist = new System.Windows.Forms.ListBox();
            this.messagepush = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel_gh = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.TabPage();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.filetransfer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.textpaste.SuspendLayout();
            this.messagepush.SuspendLayout();
            this.settings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.log.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filetransfer);
            this.tabControl1.Controls.Add(this.textpaste);
            this.tabControl1.Controls.Add(this.messagepush);
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Controls.Add(this.log);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 301);
            this.tabControl1.TabIndex = 2;
            // 
            // filetransfer
            // 
            this.filetransfer.Controls.Add(this.groupBox3);
            this.filetransfer.Controls.Add(this.groupBox1);
            this.filetransfer.Location = new System.Drawing.Point(4, 22);
            this.filetransfer.Name = "filetransfer";
            this.filetransfer.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.filetransfer.Size = new System.Drawing.Size(534, 275);
            this.filetransfer.TabIndex = 0;
            this.filetransfer.Text = "File Transfer";
            this.filetransfer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button_inlist_send);
            this.groupBox3.Controls.Add(this.button_inlist_download);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.listBox_filelist);
            this.groupBox3.Location = new System.Drawing.Point(6, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 189);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GetFileInList";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(175, 147);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Transfer is not\r\nsuitable for big file\r\n";
            // 
            // button_inlist_send
            // 
            this.button_inlist_send.Location = new System.Drawing.Point(316, 147);
            this.button_inlist_send.Name = "button_inlist_send";
            this.button_inlist_send.Size = new System.Drawing.Size(97, 33);
            this.button_inlist_send.TabIndex = 3;
            this.button_inlist_send.Text = "Send";
            this.button_inlist_send.UseVisualStyleBackColor = true;
            // 
            // button_inlist_download
            // 
            this.button_inlist_download.Location = new System.Drawing.Point(419, 147);
            this.button_inlist_download.Name = "button_inlist_download";
            this.button_inlist_download.Size = new System.Drawing.Size(97, 33);
            this.button_inlist_download.TabIndex = 2;
            this.button_inlist_download.Text = "Download";
            this.button_inlist_download.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_fs_detail);
            this.groupBox4.Location = new System.Drawing.Point(176, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 121);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File Detail";
            // 
            // label_fs_detail
            // 
            this.label_fs_detail.AutoSize = true;
            this.label_fs_detail.Location = new System.Drawing.Point(5, 17);
            this.label_fs_detail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fs_detail.Name = "label_fs_detail";
            this.label_fs_detail.Size = new System.Drawing.Size(209, 60);
            this.label_fs_detail.TabIndex = 0;
            this.label_fs_detail.Text = "File Name: {filename}\r\nUpload Date: {uploaddate}\r\nSize(KB): {size_kb}\r\nSHA256: {s" +
    "ha256}\r\nNumber of Download: {num_download}";
            // 
            // listBox_filelist
            // 
            this.listBox_filelist.FormattingEnabled = true;
            this.listBox_filelist.ItemHeight = 12;
            this.listBox_filelist.Location = new System.Drawing.Point(6, 20);
            this.listBox_filelist.Name = "listBox_filelist";
            this.listBox_filelist.Size = new System.Drawing.Size(164, 160);
            this.listBox_filelist.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_bycode_download);
            this.groupBox1.Controls.Add(this.button_bycode_send);
            this.groupBox1.Controls.Add(this.textBox_fileCode);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GetFileByCode";
            // 
            // button_bycode_download
            // 
            this.button_bycode_download.Location = new System.Drawing.Point(434, 19);
            this.button_bycode_download.Name = "button_bycode_download";
            this.button_bycode_download.Size = new System.Drawing.Size(82, 35);
            this.button_bycode_download.TabIndex = 6;
            this.button_bycode_download.Text = "Download";
            this.button_bycode_download.UseVisualStyleBackColor = true;
            this.button_bycode_download.Click += new System.EventHandler(this.button_bycode_download_Click);
            // 
            // button_bycode_send
            // 
            this.button_bycode_send.Location = new System.Drawing.Point(346, 19);
            this.button_bycode_send.Name = "button_bycode_send";
            this.button_bycode_send.Size = new System.Drawing.Size(82, 35);
            this.button_bycode_send.TabIndex = 5;
            this.button_bycode_send.Text = "Send";
            this.button_bycode_send.UseVisualStyleBackColor = true;
            // 
            // textBox_fileCode
            // 
            this.textBox_fileCode.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_fileCode.Location = new System.Drawing.Point(5, 19);
            this.textBox_fileCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_fileCode.Name = "textBox_fileCode";
            this.textBox_fileCode.Size = new System.Drawing.Size(336, 35);
            this.textBox_fileCode.TabIndex = 4;
            // 
            // textpaste
            // 
            this.textpaste.Controls.Add(this.groupBox7);
            this.textpaste.Controls.Add(this.textBox2);
            this.textpaste.Controls.Add(this.button6);
            this.textpaste.Controls.Add(this.button5);
            this.textpaste.Controls.Add(this.listBox_pastelist);
            this.textpaste.Location = new System.Drawing.Point(4, 22);
            this.textpaste.Name = "textpaste";
            this.textpaste.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.textpaste.Size = new System.Drawing.Size(534, 275);
            this.textpaste.TabIndex = 1;
            this.textpaste.Text = "Text Paste";
            this.textpaste.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(176, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(350, 73);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 145);
            this.textBox2.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(328, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(431, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox_pastelist
            // 
            this.listBox_pastelist.FormattingEnabled = true;
            this.listBox_pastelist.ItemHeight = 12;
            this.listBox_pastelist.Location = new System.Drawing.Point(6, 6);
            this.listBox_pastelist.Name = "listBox_pastelist";
            this.listBox_pastelist.Size = new System.Drawing.Size(164, 268);
            this.listBox_pastelist.TabIndex = 1;
            // 
            // messagepush
            // 
            this.messagepush.Controls.Add(this.button1);
            this.messagepush.Controls.Add(this.textBox3);
            this.messagepush.Controls.Add(this.textBox1);
            this.messagepush.Location = new System.Drawing.Point(4, 22);
            this.messagepush.Name = "messagepush";
            this.messagepush.Size = new System.Drawing.Size(534, 275);
            this.messagepush.TabIndex = 3;
            this.messagepush.Text = "Message Push";
            this.messagepush.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2, 233);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(405, 49);
            this.textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 229);
            this.textBox1.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.groupBox6);
            this.settings.Controls.Add(this.groupBox5);
            this.settings.Controls.Add(this.groupBox2);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(534, 275);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(6, 107);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(520, 79);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Server Configure";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel_gh);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(6, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 79);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "About";
            // 
            // linkLabel_gh
            // 
            this.linkLabel_gh.AutoSize = true;
            this.linkLabel_gh.LinkVisited = true;
            this.linkLabel_gh.Location = new System.Drawing.Point(6, 29);
            this.linkLabel_gh.Name = "linkLabel_gh";
            this.linkLabel_gh.Size = new System.Drawing.Size(155, 12);
            this.linkLabel_gh.TabIndex = 1;
            this.linkLabel_gh.TabStop = true;
            this.linkLabel_gh.Text = "github.com/neoxycn/Bridge";
            this.linkLabel_gh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_gh_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bridge 1.0.0.0 20240521 @ Neoxy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // log
            // 
            this.log.Controls.Add(this.textBox_log);
            this.log.Location = new System.Drawing.Point(4, 22);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(534, 275);
            this.log.TabIndex = 4;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            // 
            // textBox_log
            // 
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Location = new System.Drawing.Point(3, 3);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(528, 268);
            this.textBox_log.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server Address:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 21);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Token:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 21);
            this.textBox5.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 33);
            this.button7.TabIndex = 5;
            this.button7.Text = "Check Update";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 308);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bridge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.filetransfer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.textpaste.ResumeLayout(false);
            this.textpaste.PerformLayout();
            this.messagepush.ResumeLayout(false);
            this.messagepush.PerformLayout();
            this.settings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.log.ResumeLayout(false);
            this.log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage filetransfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_fileCode;
        private System.Windows.Forms.TabPage textpaste;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage messagepush;
        private System.Windows.Forms.TabPage log;
        private System.Windows.Forms.ListBox listBox_filelist;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_inlist_download;
        private System.Windows.Forms.Button button_bycode_send;
        public System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_bycode_download;
        private System.Windows.Forms.Button button_inlist_send;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox_pastelist;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_gh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_fs_detail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}

