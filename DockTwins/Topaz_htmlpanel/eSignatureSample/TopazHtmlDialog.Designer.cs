using System;

namespace eSignatureSample
{
    partial class TopazHtmlDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopazHtmlDialog));
            this._htmlBoxTopaz = new Wisej.Web.IFramePanel();
            this._btnOKTopazHtml = new Wisej.Web.Button();
            this.javaScript1 = new Wisej.Web.JavaScript();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.javaScript1.SetJavaScriptSource(this._htmlBoxTopaz, "this.addListener(\"click\", function(){\r\n\r\n    alert(\"Hello from JavaScript!\");\r\n  " +
        "  \r\n    App.MainPage.Save2Disk(\"Hello from JavaScript!\");\r\n\r\n});");

            this.SuspendLayout();
            // 
            // _htmlBoxTopaz
            // 
            //this._htmlBoxTopaz.conte = "text/html";
            this._htmlBoxTopaz.Dock = Wisej.Web.DockStyle.Top;
            //this._htmlBoxTopaz.ExcludeFromUniqueId = false;
            //this._htmlBoxTopaz.Html = "<HTML>No content.</HTML>";
            this._htmlBoxTopaz.Location = new System.Drawing.Point(0, 0);
            this._htmlBoxTopaz.Name = "_htmlBoxTopaz";
            //this._htmlBoxTopaz.PerformLayoutEnabled = true;
            this._htmlBoxTopaz.Size = new System.Drawing.Size(537, 200);
            this._htmlBoxTopaz.TabIndex = 0;
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            package1.Name = "Sigweb.js";
            package1.Source = "http://www.sigplusweb.com/SigWebTablet.js";
            
                                                //            t
                                                // 
                                                // _btnOKTopazHtml
                                                // 
                                                //this._btnOKTopazHtml.ExcludeFromUniqueId = false;
                                                this._btnOKTopazHtml.Location = new System.Drawing.Point(418, 219);
            this._btnOKTopazHtml.Name = "_btnOKTopazHtml";
            //this._btnOKTopazHtml.PerformLayoutEnabled = true;
            this._btnOKTopazHtml.Size = new System.Drawing.Size(75, 40);
            this._btnOKTopazHtml.TabIndex = 1;
            this._btnOKTopazHtml.Text = "OK";
            this._btnOKTopazHtml.Click += new System.EventHandler(this._btnOKTopazHtml_Click);
            // 
            // TopazHtmlDialog
            // 
            this.Controls.Add(this._btnOKTopazHtml);
            this.Controls.Add(this._htmlBoxTopaz);
            //this.FormBorderStyle = BorderStyle.Solid;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(537, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(537, 280);
            this.Size = new System.Drawing.Size(537, 280);
            this.Text = "Topaz Signature";
            this.ResumeLayout(false);

        }


        #endregion

        private Wisej.Web.IFramePanel _htmlBoxTopaz;
        private Wisej.Web.Button _btnOKTopazHtml;
        private Wisej.Web.JavaScript javaScript1;

    }
}
