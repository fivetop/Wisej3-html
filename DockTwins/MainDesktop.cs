using System;
using Wisej.Web;

namespace DockTwins
{
    public partial class MainDesktop : Desktop
    {
        private int _twinCounter = 1;

        public MainDesktop()
        {
            InitializeComponent();
        }

        private void buttonOpenTwins_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2)
            {
                var twin1 = new Twin(_twinCounter++);
                twin1.Show();
            }

            if (Application.OpenForms.Count < 2)
            {
                var twin1 = new Twin(_twinCounter++);
                twin1.Show();
            }
        }

        private void buttonDockTwins_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Call("window.dockTwins");
            }
            else
            {
                MessageBox.Show("You need two windows.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}