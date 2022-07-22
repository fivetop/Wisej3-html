using Wisej.Web;

namespace DockTwins
{
    public partial class Twin : Form
    {
        public Twin(int twinNumber)
        {
            InitializeComponent();

            this.Text = $"Twin {twinNumber}";
        }
    }
}
