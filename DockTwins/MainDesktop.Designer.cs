namespace DockTwins
{
    partial class MainDesktop
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenTwins = new Wisej.Web.Button();
            this.desktopTaskBarItemControl1 = new Wisej.Web.DesktopTaskBarItemControl();
            this.buttonDockTwins = new Wisej.Web.Button();
            this.desktopTaskBarItemControl2 = new Wisej.Web.DesktopTaskBarItemControl();
            this.SuspendLayout();
            // 
            // buttonOpenTwins
            // 
            this.buttonOpenTwins.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenTwins.Name = "buttonOpenTwins";
            this.buttonOpenTwins.Size = new System.Drawing.Size(100, 32);
            this.buttonOpenTwins.TabIndex = 0;
            this.buttonOpenTwins.Text = "Open Twins";
            this.buttonOpenTwins.Click += new System.EventHandler(this.buttonOpenTwins_Click);
            // 
            // desktopTaskBarItemControl1
            // 
            this.desktopTaskBarItemControl1.Control = this.buttonOpenTwins;
            this.desktopTaskBarItemControl1.Name = "desktopTaskBarItemControl1";
            // 
            // buttonDockTwins
            // 
            this.buttonDockTwins.Location = new System.Drawing.Point(3, 3);
            this.buttonDockTwins.Name = "buttonDockTwins";
            this.buttonDockTwins.Size = new System.Drawing.Size(100, 32);
            this.buttonDockTwins.TabIndex = 0;
            this.buttonDockTwins.Text = "DockTwins";
            this.buttonDockTwins.Click += new System.EventHandler(this.buttonDockTwins_Click);
            // 
            // desktopTaskBarItemControl2
            // 
            this.desktopTaskBarItemControl2.Control = this.buttonDockTwins;
            this.desktopTaskBarItemControl2.Name = "desktopTaskBarItemControl2";
            // 
            // MainDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Items.AddRange(new Wisej.Web.DesktopTaskBarItem[] {
            this.desktopTaskBarItemControl1,
            this.desktopTaskBarItemControl2});
            this.Name = "MainDesktop";
            this.Size = new System.Drawing.Size(806, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button buttonOpenTwins;
        private Wisej.Web.DesktopTaskBarItemControl desktopTaskBarItemControl1;
        private Wisej.Web.Button buttonDockTwins;
        private Wisej.Web.DesktopTaskBarItemControl desktopTaskBarItemControl2;
    }
}
