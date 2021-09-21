using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using Microsoft.PowerShell;
using System.IO;
using System.Timers;
using System.Text.RegularExpressions;

namespace WlanMeter
{
    public partial class WlanMeterGUI : Form
    {

        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private int taskBarHeight = 80;
        private static System.Timers.Timer heartbeat;
        public WlanMeterGUI()
        {
            InitializeComponent();
        }

        private void WlanMeterGUI_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            this.Location = new Point(screenWidth - this.Size.Width - 0, screenHeight - this.Size.Height - taskBarHeight - 0);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyRightMouseButton);
            Heartbeat();
        }

        private string getSignalStrength()
        {
            PowerShell ps = PowerShell.Create();
            ps.AddCommand(@"netsh");
            ps.AddArgument(@"wlan");
            ps.AddArgument(@"show");
            ps.AddArgument(@"interfaces");

            Collection<PSObject> results = ps.Invoke();

            foreach (var result in results)
            {
                if (result.ToString().Contains("Signal"))
                {
                    var strenght_percent = Regex.Replace(result.ToString(), @"^\s+Signal\s+:\s+", "");
                    ps.Stop();
                    ps.Dispose();
                    return strenght_percent;
                }
            }
            return "?";
        }

        private void Heartbeat()
        {
            heartbeat = new System.Timers.Timer(1000);
            heartbeat.Elapsed += RefreshSignalStrength;
            heartbeat.AutoReset = true;
            heartbeat.Enabled = true;
        }

        private void RefreshSignalStrength(Object source, ElapsedEventArgs e)
        {
            lblSignal.Invoke(new MethodInvoker(delegate { lblSignal.Text = getSignalStrength(); }));
        }

        private void keyRightMouseButton(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void lblSignal_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs) e;

            if (m.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}