using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Timers;
using System.Text.RegularExpressions;
using Microsoft.Win32;

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
            this.ClientSize = new Size(100, 75); // Form Size Correction
            this.Opacity = 0.8;
            this.Location = new Point(screenWidth - this.Size.Width, screenHeight - this.Size.Height - taskBarHeight - 0);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyRightMouseButton);
            // Read settings
            if (Properties.Settings.Default.autostart == false)
            {
                autostartEnabledToolStripMenuItem.Checked = false;
            } else
            {
                autostartEnabledToolStripMenuItem.Checked = true;
            }
            Heartbeat();
        }

        private void guiMouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void guiMouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
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
        private void autostartEnabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autostartEnabledToolStripMenuItem.Checked == true)
            {
                autostartEnabledToolStripMenuItem.Checked = false;
                Properties.Settings.Default.autostart = false;
            }
            else
            {
                autostartEnabledToolStripMenuItem.Checked = true;
                Properties.Settings.Default.autostart = true;
            }
            Properties.Settings.Default.Save();
            SetStartup();
        }

        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (Properties.Settings.Default.autostart == true)
            {
                rk.SetValue("Wlan Meter", Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue("Wlan Meter", false);
            }
        }
    }
}