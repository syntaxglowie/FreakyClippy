using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreakyClippy.Properties;

namespace FreakyClippy
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value >= numericUpDown3.Value)
            {
                MessageBox.Show("Min value cannot be bigger than max value, dummy!");
            }
            else
            {
                Properties.Settings.Default.maxSeconds = (int)numericUpDown3.Value;
                Properties.Settings.Default.minSeconds = (int)numericUpDown2.Value;
                Properties.Settings.Default.timeBetweenFrames = (int)numericUpDown1.Value;
                Properties.Settings.Default.speechBubbleX = (int)numericUpDown5.Value;
                Properties.Settings.Default.speechBubbleY = (int)numericUpDown4.Value;
                Properties.Settings.Default.minFontSize = (int)numericUpDown6.Value;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            numericUpDown3.Value = Properties.Settings.Default.maxSeconds;
            numericUpDown2.Value = Properties.Settings.Default.minSeconds;
            numericUpDown1.Value = Properties.Settings.Default.timeBetweenFrames;
            numericUpDown5.Value = Properties.Settings.Default.speechBubbleX;
            numericUpDown4.Value = Properties.Settings.Default.speechBubbleY;
            numericUpDown6.Value = Properties.Settings.Default.minFontSize;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.maxSeconds = 600;
            Properties.Settings.Default.minSeconds = 120;
            Properties.Settings.Default.timeBetweenFrames = 200;
            Properties.Settings.Default.speechBubbleX = 240;
            Properties.Settings.Default.speechBubbleY = 100;
            Properties.Settings.Default.minFontSize = 10;
            numericUpDown5.Value = Properties.Settings.Default.speechBubbleX;
            numericUpDown4.Value = Properties.Settings.Default.speechBubbleY;
            numericUpDown6.Value = Properties.Settings.Default.minFontSize;
            numericUpDown3.Value = Properties.Settings.Default.maxSeconds;
            numericUpDown2.Value = Properties.Settings.Default.minSeconds;
            numericUpDown1.Value = Properties.Settings.Default.timeBetweenFrames;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("explorer", "https://www.syntaxglow.com");
            Process.Start(sInfo);
        }
    }
}
