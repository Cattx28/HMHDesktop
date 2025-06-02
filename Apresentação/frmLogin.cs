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

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_moderadorService.acessar(txtLogin.Text, txtSenha.Text))
            {
                // 1. Definir que o login foi bem-sucedido
                this.DialogResult = DialogResult.OK;

                // 2. Criar e mostrar o formulário principal
                var mainForm = new frmInicial();

                // 3. Configurar para que quando fechar o mainForm, encerre a aplicação
                mainForm.FormClosed += (s, args) => Application.Exit();

                // 4. Fechar o login
                this.Close();

                // 5. Mostrar o mainForm
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!", "ERRO!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

