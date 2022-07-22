namespace WisejWebPageApplication1
{
    partial class Page1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.htmlPanel2 = new Wisej.Web.HtmlPanel();
            this.htmlPanel4 = new Wisej.Web.HtmlPanel();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.htmlPanel3 = new Wisej.Web.HtmlPanel();
            this.label2 = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.widget1 = new Wisej.Web.Widget();
            this.label5 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.label4 = new Wisej.Web.Label();
            this.panel6 = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            this.panel7 = new Wisej.Web.Panel();
            this.button3 = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.HtmlSource = "index2.html";
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1282, 106);
            this.htmlPanel1.TabIndex = 3;
            this.htmlPanel1.TabStop = false;
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.Focusable = false;
            this.htmlPanel2.Html = "<a href=\"#\">Click me!!!</a>\r\n<br>\r\n<a href=\"#\" role=\"test\">Test me!!!</a>\r\n<br>\r\n" +
    "<a href=\"#\" role=\"save\">Save me!!!</a>";
            this.htmlPanel2.Location = new System.Drawing.Point(15, 25);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(143, 91);
            this.htmlPanel2.TabIndex = 2;
            this.htmlPanel2.TabStop = false;
            this.htmlPanel2.ElementClick += new Wisej.Web.HtmlPanelElementClickHandler(this.htmlPanel2_ElementClick);
            // 
            // htmlPanel4
            // 
            this.htmlPanel4.Focusable = false;
            this.htmlPanel4.HtmlSource = "index4.html";
            this.htmlPanel4.Location = new System.Drawing.Point(26, 16);
            this.htmlPanel4.Name = "htmlPanel4";
            this.htmlPanel4.Size = new System.Drawing.Size(520, 305);
            this.htmlPanel4.TabIndex = 1;
            this.htmlPanel4.TabStop = false;
            // 
            // button1
            // 
            this.javaScript1.SetJavaScript(this.button1, "this.addListener(\"click\", function(){\r\n\r\n    alert(\"Hello from JavaScript!\");\r\n  " +
        "  \r\n    App.MainPage.CallbackTheServer(\"Hello from JavaScript!\");\r\n\r\n});");
            this.button1.Location = new System.Drawing.Point(15, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "java Inline";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "java outline";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.htmlPanel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(787, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 282);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.htmlPanel4);
            this.panel2.Location = new System.Drawing.Point(17, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 214);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.htmlPanel3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(270, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 243);
            this.panel3.TabIndex = 7;
            // 
            // htmlPanel3
            // 
            this.htmlPanel3.Focusable = false;
            this.htmlPanel3.HtmlSource = "index3.html";
            this.htmlPanel3.Location = new System.Drawing.Point(17, 82);
            this.htmlPanel3.Name = "htmlPanel3";
            this.htmlPanel3.Size = new System.Drawing.Size(369, 132);
            this.htmlPanel3.TabIndex = 1;
            this.htmlPanel3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.widget1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(80, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 8;
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.FromArgb(191, 63, 134);
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(13, 3);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "particles.js";
            package1.Source = "https://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js";
            this.widget1.Packages.Add(package1);
            this.widget1.Size = new System.Drawing.Size(170, 83);
            this.widget1.TabIndex = 1;
            this.widget1.Text = "widget1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "label4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(315, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "label5";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(554, 385);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "label6";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.htmlPanel1);
            this.panel7.Dock = Wisej.Web.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1282, 106);
            this.panel7.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(770, 404);
            this.Text = "Page1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.HtmlPanel htmlPanel1;
        private Wisej.Web.HtmlPanel htmlPanel2;
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.Button button1;
        private Wisej.Web.HtmlPanel htmlPanel4;
        private Wisej.Web.Button button2;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label label1;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Label label4;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.Label label3;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.HtmlPanel htmlPanel3;
        private Wisej.Web.Button button3;
        private Wisej.Web.Widget widget1;
    }
}

