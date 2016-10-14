using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NotifyIconTest
{
    public partial class NotifyIconWrapper : Component
    {

        public NotifyIconWrapper()
        {
            InitializeComponent();

            // Attach event handlers.
            cmdClose.Click += cmdClose_Click;
            cmdShowWindow.Click += cmdShowWindow_Click;
        }

        // Clean up when this component is released by releasing all
        // contained components (including the NotifyIcon).
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);            
        }

        // Use just one instance of this window.        
        private Window1 win = new Window1();
        private void cmdShowWindow_Click(object sender, EventArgs e)
        {            
            // Show the window (and bring it to the forefront if it's already visible).
            if (win.WindowState == System.Windows.WindowState.Minimized) win.WindowState = System.Windows.WindowState.Normal;
            win.Show();
            win.Activate();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdClose = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdShowWindow,
            this.cmdClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // cmdShowWindow
            // 
            this.cmdShowWindow.Name = "cmdShowWindow";
            this.cmdShowWindow.Size = new System.Drawing.Size(150, 22);
            this.cmdShowWindow.Text = "Show Window";
            // 
            // cmdClose
            // 
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(150, 22);
            this.cmdClose.Text = "Close";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NotifyIcon Test";
            this.notifyIcon1.Visible = true;
            this.contextMenuStrip1.ResumeLayout(false);

        }
    }
}
