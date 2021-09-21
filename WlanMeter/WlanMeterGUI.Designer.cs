
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
            this.imgSignal = new System.Windows.Forms.PictureBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgSignal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSignal
            // 
            this.imgSignal.BackgroundImage = global::WlanMeter.Properties.Resources.signal;
            this.imgSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSignal.Location = new System.Drawing.Point(10, 10);
            this.imgSignal.Name = "imgSignal";
            this.imgSignal.Size = new System.Drawing.Size(65, 50);
            this.imgSignal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSignal.TabIndex = 0;
            this.imgSignal.TabStop = false;
            // 
            // lblSignal
            // 
            this.lblSignal.BackColor = System.Drawing.Color.Transparent;
            this.lblSignal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignal.ForeColor = System.Drawing.Color.White;
            this.lblSignal.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSignal.Location = new System.Drawing.Point(95, 10);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(155, 57);
            this.lblSignal.TabIndex = 1;
            this.lblSignal.Text = "100%";
            this.lblSignal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSignal.Click += new System.EventHandler(this.lblSignal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 50);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // WlanMeterGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 75);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.imgSignal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WlanMeterGUI";
            this.Text = "Wlan";
            this.Load += new System.EventHandler(this.WlanMeterGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSignal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSignal;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

