using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RCLL_Degital_Clock
{
    public partial class MainAR : Form
    {
        public MainAR()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Lime;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDlg.Color;
            }
    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.Font = fontDialog1.Font;
            }
    }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Analog_Clock;
            pictureBox1.Refresh();

            Analog_Clock AnalogClockDemo = new Analog_Clock();
            AnalogClockDemo.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Digital_Clock;
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/YoussefSalah842/RCLL-Digital-Clock");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youssefpro986.blogspot.com/p/privacy-policy.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youssefpro986.blogspot.com/p/usage-agreement.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Analog_Clock;
            pictureBox1.Refresh();

            Analog_Clock AnalogClockDemo = new Analog_Clock();
            AnalogClockDemo.Show();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Analog_Clock_Theme2;
            pictureBox1.Refresh();

            Analog_Clock2 AnalogClockDemo2 = new Analog_Clock2();
            AnalogClockDemo2.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main MianEN = new Main();
            MianEN.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("أداة الساعة الرقمية RCLL، الإصدار 1.6، YoussefSalah842، جميع الحقوق محفوظة", "حول البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
