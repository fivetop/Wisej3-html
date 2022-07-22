
using System;
using Wisej.Core;
using Wisej.Web;

namespace WisejWebPageApplication1
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        [WebMethod]
        public void CallbackTheServer(string text)
        {
            this.button1.Text = text;
        }

        private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {

            if (e.Role != null)
            {
                AlertBox.Show($"{e.Element} is captured and it's role is - {e.Role}", allowHtml: false);
            }
            else
            {
                AlertBox.Show($"{e.Element} element is captured", allowHtml: false);
            }

        }

        private void htmlPanel2_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {
            if (e.Role != null)
            {
                AlertBox.Show($"{e.Element} is captured and it's role is - {e.Role}", allowHtml: false);
            }
            else
            {
                AlertBox.Show($"{e.Element} element is captured", allowHtml: false);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Call("window.show");
            Application.Call("show");
        }
    }
}
