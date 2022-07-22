
using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using Wisej.Core;

namespace eSignatureSample
{
    public partial class TopazHtmlDialog : Form
    {
        public string SessionVariable;
        private string _signatureID;
        private int _height;
        private int _width;
        private object arr = new object[2];

        public TopazHtmlDialog( int height, int width)
        {
            InitializeComponent();
            //_signatureID = signatureID;
            this.ControlBox = false;
            _height = height;
            _width = width;
            this._htmlBoxTopaz.Url = "/HtmlPage1.html"; // Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\HtmlPage1.html");
        }
        private string SignatureString { get; set; }
        private int Height { get => _height; set => _height = value; }
        private int Width { get => _width; set => _width = value; }
        //private void _btnOKTopazHtml_Click(object sender, EventArgs e)
        private void _btnOKTopazHtml_Click(object sender, EventArgs e)
        {
            
            //Eval("this._htmlBoxTopaz.getWindow().onDone()");
            //this._htmlBoxTopaz.Call("OkButtonClick");           
            this.Close();
        }
     
        //Register the WebMethod
        protected override void OnWebRender(dynamic config)
        {
            base.OnWebRender((object)config);

            config.webMethods = new[] { "GetSigString" };
            config.wiredEvents.Add("changeSig(Text");
        }
       
        [Wisej.Core.WebMethod]
        public static void GetSigString(string sigString)
        {
            //// System.IO.File.WriteAllText(@"C:\temp\TEST_Filled_FORM.html", CKData);
            AlertBox.Show(sigString);
            //SignatureString = sigString;
        }

        
    }
}
