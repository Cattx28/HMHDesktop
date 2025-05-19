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

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            panelProgress.Width += 3;

            if (panelProgress.Width >= panel1.Width)
            {

                timer1.Stop();
                this.Close();
            }
        }*/
    }

}
