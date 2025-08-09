using Dados;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Apresentação
{
    public partial class frmLogin : Form
    {
        private readonly ModeradorService _moderadorService;
        public frmLogin()
        {
            InitializeComponent();
            _moderadorService = new ModeradorService();
            imgLogo.Image = Properties.Resources.olho;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (_moderadorService.acessar(login, senha)) // Envia a senha em texto puro
            {
                this.DialogResult = DialogResult.OK;
                var mainForm = new frmInicial();
                mainForm.FormClosed += (s, args) => Application.Exit();
                this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!", "ERRO!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgOlho_Click(object sender, EventArgs e)
        {
            if (imgLogo.Image == Properties.Resources.olho) {
                }
        }
    }
}

