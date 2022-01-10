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
    public partial class Form2 : Form
    {
        public void attackSsid(string attackerSsid)
        {
            string attackSsid = attackerSsid;
            int attackStack = 0;
            while (true)
            { 
                attackStack++;
                string attackWifiStack = attackStack.ToString();
                connect(attackSsid);
                attackCount.Text = attackWifiStack;
            }
        }
        
        public Form2()
        {
            InitializeComponent();
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
    }
}
