
using System;
using Wisej.Core;
using Wisej.Web;

namespace WisejWebPageApplication1
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        [WebMethod]
        public void CallbackTheServer(int text)
        {
            this.button1.Text = text.ToString();

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;


            switch (text)
            {
                case 1:
                    panel1.Visible = true;
                    panel1.Dock = DockStyle.Fill;
                    break;
                case 2:
                    panel2.Visible = true;
                    panel2.Dock = DockStyle.Fill;
                    break;
                case 3:
                    panel3.Visible = true;
                    panel3.Dock = DockStyle.Fill;
                    break;
                case 4:
                    panel4.Visible = true;
                    panel4.Dock = DockStyle.Fill;
                    break;
                case 5:
                    panel5.Visible = true;
                    panel5.Dock = DockStyle.Fill;
                    break;
                case 6:
                    panel6.Visible = true;
                    panel6.Dock = DockStyle.Fill;
                    break;
                default:
                    panel1.Visible = true;
                    panel1.Dock = DockStyle.Fill;
                    break;
            }

        }

        private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
        {

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
