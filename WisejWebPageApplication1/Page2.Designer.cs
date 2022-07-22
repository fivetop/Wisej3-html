namespace WisejWebPageApplication1
{
    partial class Page2
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
            this.components = new System.ComponentModel.Container();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.htmlPanel2 = new Wisej.Web.HtmlPanel();
            this.htmlPanel3 = new Wisej.Web.HtmlPanel();
            this.htmlPanel4 = new Wisej.Web.HtmlPanel();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Top;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "index2.html";
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(806, 114);
            this.htmlPanel1.TabIndex = 3;
            this.htmlPanel1.TabStop = false;
            this.htmlPanel1.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel1_ElementClick);
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.Focusable = false;
            this.htmlPanel2.Html = "<a href=\"#\">Click me!!!</a>\r\n<br>\r\n<a href=\"#\" role=\"test\">Test me!!!</a>\r\n<br>\r\n" +
    "<a href=\"#\" role=\"save\">Save me!!!</a>";
            this.htmlPanel2.Location = new System.Drawing.Point(18, 206);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(143, 91);
            this.htmlPanel2.TabIndex = 2;
            this.htmlPanel2.TabStop = false;
            this.htmlPanel2.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel2_ElementClick);
            // 
            // htmlPanel3
            // 
            this.htmlPanel3.Dock = Wisej.Web.DockStyle.Top;
            this.htmlPanel3.Focusable = false;
            this.htmlPanel3.HtmlSource = "index3.html";
            this.htmlPanel3.Location = new System.Drawing.Point(0, 114);
            this.htmlPanel3.Name = "htmlPanel3";
            this.htmlPanel3.Size = new System.Drawing.Size(806, 72);
            this.htmlPanel3.TabIndex = 0;
            this.htmlPanel3.TabStop = false;
            this.htmlPanel3.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel2_ElementClick);
            // 
            // htmlPanel4
            // 
            this.htmlPanel4.Focusable = false;
            this.htmlPanel4.HtmlSource = "index4.html";
            this.htmlPanel4.Location = new System.Drawing.Point(222, 206);
            this.htmlPanel4.Name = "htmlPanel4";
            this.htmlPanel4.Size = new System.Drawing.Size(520, 305);
            this.htmlPanel4.TabIndex = 1;
            this.htmlPanel4.TabStop = false;
            // 
            // button1
            // 
            this.javaScript1.SetJavaScript(this.button1, "this.addListener(\"click\", function(){\r\n\r\n    alert(\"Hello from JavaScript!\");\r\n  " +
        "  \r\n    App.MainPage.CallbackTheServer(\"Hello from JavaScript!\");\r\n\r\n});");
            this.button1.Location = new System.Drawing.Point(18, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "java Inline";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "java outline";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.htmlPanel3);
            this.Controls.Add(this.htmlPanel4);
            this.Controls.Add(this.htmlPanel2);
            this.Controls.Add(this.htmlPanel1);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(789, 472);
            this.Text = "Page1";
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.HtmlPanel htmlPanel2;
        private Wisej.Web.HtmlPanel htmlPanel3;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.Button button1;
        private Wisej.Web.HtmlPanel htmlPanel4;
        private Wisej.Web.Button button2;
    }
}

