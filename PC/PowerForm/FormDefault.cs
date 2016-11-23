using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ChangKeTec.PowerForm
{
    public partial class FormDefault : Office2007Form
    {

        public FormDefault()
        {
            InitializeComponent();
        }

        private void FormDefault_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FormDefault_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
