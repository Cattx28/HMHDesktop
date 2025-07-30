namespace Apresentação
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnModerador_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmModerador>().Count() == 0)
            {
                frmModerador fForn = new frmModerador();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                frmModerador fForn = Application.OpenForms.OfType<frmModerador>().First();
                fForn.BringToFront();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            if (Application.OpenForms.OfType<frmUsuario>().Count() == 0)
            {
                frmUsuario fForn = new frmUsuario();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                frmUsuario fForn = Application.OpenForms.OfType<frmUsuario>().First();
                fForn.BringToFront();
            }
        }

        private void btnPsicologos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPsicologo>().Count() == 0)
            {
                frmPsicologo fForn = new frmPsicologo();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                frmPsicologo fForn = Application.OpenForms.OfType<frmPsicologo>().First();
                fForn.BringToFront();
            }
        }

        private void btnDenuncias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDenuncia>().Count() == 0)
            {
                frmDenuncia fForn = new frmDenuncia();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                frmDenuncia fForn = Application.OpenForms.OfType<frmDenuncia>().First();
                fForn.BringToFront();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
