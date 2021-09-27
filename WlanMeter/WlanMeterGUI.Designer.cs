
namespace WlanMeter
{
    partial class WlanMeterGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSignal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autostartEnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignal
            // 
            this.lblSignal.BackColor = System.Drawing.Color.Transparent;
            this.lblSignal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignal.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignal.ForeColor = System.Drawing.Color.White;
            this.lblSignal.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSignal.Location = new System.Drawing.Point(0, 0);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(100, 75);
            this.lblSignal.TabIndex = 1;
            this.lblSignal.Text = "...";
            this.lblSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignal.Click += new System.EventHandler(this.lblSignal_Click);
            this.lblSignal.MouseEnter += new System.EventHandler(this.guiMouseEnter);
            this.lblSignal.MouseLeave += new System.EventHandler(this.guiMouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autostartEnabledToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 96);
            // 
            // autostartEnabledToolStripMenuItem
            // 
            this.autostartEnabledToolStripMenuItem.Name = "autostartEnabledToolStripMenuItem";
            this.autostartEnabledToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.autostartEnabledToolStripMenuItem.Text = "Autostart";
            this.autostartEnabledToolStripMenuItem.Click += new System.EventHandler(this.autostartEnabledToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // WlanMeterGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WlanMeter.Properties.Resources.signal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(100, 75);
            this.ControlBox = false;
            this.Controls.Add(this.lblSignal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WlanMeterGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Wlan";
            this.Load += new System.EventHandler(this.WlanMeterGUI_Load);
            this.MouseEnter += new System.EventHandler(this.guiMouseEnter);
            this.MouseLeave += new System.EventHandler(this.guiMouseLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autostartEnabledToolStripMenuItem;
    }
}

