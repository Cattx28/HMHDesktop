using Org.BouncyCastle.Asn1.Cmp;

namespace Apresentação
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

        }

        public void UpdateProgress(int percent)
        {
            if (blueGradientProgressBar1.InvokeRequired)
            {
                blueGradientProgressBar1.Invoke((MethodInvoker)delegate
                {
                    blueGradientProgressBar1.Value = percent;
                });
            }
            else
            {
                blueGradientProgressBar1.Value = percent;
            }
        }
    }

}
