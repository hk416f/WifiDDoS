using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void connect(string wifi)
        {
            foreach (string i in cmd("netsh wlan connect name=" + wifi))
            {
                Console.WriteLine(i);
            }
        }

        private static List<string> cmd(string command)
        {
            List<string> output = new List<String>();

            StringReader sr = new StringReader(getCMDOutPut(command));
            string i;
            while (!string.ReferenceEquals((i = sr.ReadLine()), null))
            {
                output.Add(i);
            }
            return output;
        }
        private static string getCMDOutPut(string cmd)
        {
            ProcessStartInfo pri = new ProcessStartInfo();
            Process pro = new Process();

            pri.FileName = "cmd.exe";
            pri.CreateNoWindow = true;

            pri.UseShellExecute = false;
            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;

            pro.StartInfo = pri;
            pro.Start();

            pro.StandardInput.Write(cmd + Environment.NewLine);
            pro.StandardInput.Close();

            string result = pro.StandardOutput.ReadToEnd();
            pro.WaitForExit();
            pro.Close();
            return result;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string ssid = ssidInput.Text;
            string wrongWifi = "없습니다.";
            if(getCMDOutPut("netsh wlan connect name="+ssid).Contains(wrongWifi))
            {
                this.wrongWifi.Text = "wrong SSID!";
                ssidInput.Clear();
            }

        }
        private void attack_Click(object sender, EventArgs e)
        {

            string ssid = ssidInput.Text;
            string wrongWifi = "없습니다.";
            if (getCMDOutPut("netsh wlan connect name=" + ssid).Contains(wrongWifi))
            {
                this.wrongWifi.Text = "wrong SSID!";
                ssidInput.Clear();
            }
            else
            {
                Form2 newform2 = new Form2();
                newform2.ShowDialog();
                newform2.attackSsid(ssid);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.Close();
        }
    }
}
