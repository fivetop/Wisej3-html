namespace HtmlPanelDemo
{
    partial class Window1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
			this.htmlPanel1 = new Wisej.Web.HtmlPanel();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// htmlPanel1
			// 
			this.htmlPanel1.Focusable = false;
			this.htmlPanel1.Html = "<button>test</button>";
			this.htmlPanel1.InitScript = resources.GetString("htmlPanel1.InitScript");
			this.htmlPanel1.Location = new System.Drawing.Point(38, 81);
			this.htmlPanel1.Name = "htmlPanel1";
			this.htmlPanel1.Size = new System.Drawing.Size(800, 580);
			this.htmlPanel1.TabIndex = 0;
			this.htmlPanel1.TabStop = false;
			this.htmlPanel1.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel1_ElementClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(299, 676);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(217, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 743);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.htmlPanel1);
			this.Name = "Window1";
			this.Text = "Window1";
			this.Load += new System.EventHandler(this.Window1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.HtmlPanel htmlPanel1;
		private Wisej.Web.Button button1;
	}
}

