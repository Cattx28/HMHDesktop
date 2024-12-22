using Dados;
using Negocio;

namespace Apresentação
{
    public partial class frmLogin : Form
    {
        private readonly ModeradorService _moderadorService;
        public frmLogin()
        {
            InitializeComponent();
            _moderadorService = new ModeradorService();

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_moderadorService.acessar(txtLogin.Text, txtSenha.Text))
                this.Close();
            else
                MessageBox.Show("Usuário e/ou senha incorretos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
