namespace Apresentação
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelProgress.Width += 3;

            if (panelProgress.Width >= panel1.Width) {

                timer1.Stop();
                this.Close();
            }
        }
    }

}
