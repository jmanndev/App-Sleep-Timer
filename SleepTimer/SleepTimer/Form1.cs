using System;
using System.Windows.Forms;

namespace SleepTimer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button10m_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(10 * 60));
        }

        private void button45m_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(45 * 60));
        }

        private void button1h_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(60 * 60));
        }

        private void button1h30m_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(90 * 60));
        }

        private void button2h_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(120 * 60));
        }

        private void button4h_Click(object sender, EventArgs e)
        {
            shutdownAction(Convert.ToString(240 * 60));
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            shutdownAbort();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            try
            {
                double seconds = Convert.ToDouble(text) * 60 * 60;
                shutdownAction(seconds.ToString());
            }
            catch (Exception) { }
            textBox1.Text = "";

        }
        
        private void shutdownAction(string input)
        {
            shutdownAbort();
            string strCmdText;
            strCmdText = "/C shutdown -s -t " + input;
            run(strCmdText);
        }

        private void shutdownAbort()
        {
            run("/C shutdown -a");
        }

        private void run(string strCmdText)
        {
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
