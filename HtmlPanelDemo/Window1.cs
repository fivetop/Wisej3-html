using System;
using Wisej.Web;

namespace HtmlPanelDemo
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private string htmlCode = @"<form action='http://app.xxx.it/call/default.aspx' method='POST'>
<div>
<label for='Name'>Nome</label>
<input name='Name' id='placeholder1' type='hidden' value='' runat='server'>
<div>
<label for='Lastname'>Cognome</label>
<input name='Lastname' id='placeholder2' type='hidden' value='' runat='server'>
</div>
<div>
<button>SEND</button>
</div>
</form>";

		private void Window1_Load(object sender, EventArgs e)
		{
			string id1 = "actualId1";
			string id2 = "actualId2";

			this.htmlCode = htmlCode.Replace("placeholder1",id1).Replace("placeholder2", id2);

			this.htmlPanel1.Html = htmlCode;

			MessageBox.Show($"{this.htmlPanel1.Html}",allowHtml:false);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.htmlPanel1.Call("clickButton");
		}

		private void htmlPanel1_ElementClick(object sender, HtmlPanelElementClickArgs e)
		{

		}
	}
}