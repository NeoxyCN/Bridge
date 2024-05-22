using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bridge
{
    public partial class MainForm : Form
    {
        public enum LogType
        {
            Info,
            Warning,
            Error
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void Log(LogType type,string output)
        {
            switch (type)
            {
                case LogType.Info:
                    textBox_log.AppendText($"[INFO]{output}\r\n");
                    break;
                case LogType.Warning:
                    textBox_log.AppendText($"[WARNING]{output}\r\n");
                    break;
                case LogType.Error:
                    textBox_log.AppendText($"[ERROR]{output}\r\n");
                    break;
            }

        }

        private void button_bycode_download_Click(object sender, EventArgs e)
        {
            Log(LogType.Info,"button_bycode_download_Click");
        }

        private void linkLabel_gh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/neoxycn/Bridge");
        }
    }
}
