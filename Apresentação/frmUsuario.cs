using Dados;
using Negocio;
using System.Data;

namespace Apresentação
{
    public partial class frmUsuario : Form
    {
        private readonly UsuarioService _usuarioService;
        private DataTable tblUsuario = new DataTable();

        private int modo = 0;
        internal DataTable dt;


        public frmUsuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();

            ConfiguraDataGridView();
            carregaGridView();
            Habilita();
        }

        private void ConfiguraDataGridView()
        {
            // Configuração do DataGridView em um método separado
            dgUsuario.ColumnCount = 5;
            dgUsuario.AutoGenerateColumns = false;
            dgUsuario.Columns[0].Width = 55;
            dgUsuario.Columns[0].HeaderText = "ID";
            dgUsuario.Columns[0].DataPropertyName = "idUsuario";
            dgUsuario.Columns[1].Width = 300;
            dgUsuario.Columns[1].HeaderText = "NOME";
            dgUsuario.Columns[1].DataPropertyName = "nome";
            dgUsuario.Columns[2].Width = 55;
            dgUsuario.Columns[2].HeaderText = "IDADE";
            dgUsuario.Columns[2].DataPropertyName = "idade";
            dgUsuario.Columns[3].Width = 310;
            dgUsuario.Columns[3].HeaderText = "EMAIL";
            dgUsuario.Columns[3].DataPropertyName = "email";
            dgUsuario.Columns[4].Width = 150;
            dgUsuario.Columns[4].HeaderText = "SENHA";
            dgUsuario.Columns[4].DataPropertyName = "senha";

            dgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuario.AllowUserToAddRows = false;
            dgUsuario.AllowUserToDeleteRows = false;
            dgUsuario.AllowUserToOrderColumns = true;
            dgUsuario.ReadOnly = true;
        }

        // Método para limpar os campos do formulário
        public void LimpaForm()
        {
            txtId?.Clear();
            txtNome?.Clear();
            txtIdade?.Clear();
            txtEmail?.Clear();
            txtSenha?.Clear();

            txtNome?.Focus();
        }

        private void carregaGridView()
        {
            dgUsuario.DataSource = _usuarioService.getAll();
            dgUsuario.Refresh();
        }

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    btnInativar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnVoltar.Enabled = true;
                    grpDados.Enabled = false;
                    dgUsuario.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInativar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnVoltar.Enabled = true;
                    grpDados.Enabled = true;
                    dgUsuario.Enabled = false;
                    break;
                case 2:
                    btnInativar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnVoltar.Enabled = true;
                    grpDados.Enabled = true;
                    dgUsuario.Enabled = false;
                    break;
            }
        }

        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuario.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[1].Value);
            txtIdade.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[2].Value);
            txtEmail.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[3].Value);
            txtSenha.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[4].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (idBusca.HasValue)
            {
                DataTable tblUsuario = _usuarioService.filterById(idBusca.Value); // Método para buscar por ID
                if (tblUsuario != null)
                {
                    dgUsuario.DataSource = tblUsuario;
                    dgUsuario.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nenhum ID foi informado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = 2;
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome;
            int idade = 0;
            string email;
            string senha;

            string resultado;
            string msg;

            Usuario usuario = new Usuario();

            int regAtual = 0;


            if (string.IsNullOrEmpty(txtId.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            try
            {
                idade = Convert.ToInt32(txtIdade.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
           email = txtEmail.Text;
            senha = txtSenha.Text;

            usuario.nome = nome;
            usuario.idade = idade;
            usuario.email = email;
            usuario.senha = senha;

            //Validator
            /*if (moderador != null)
            {
                FornecedorValidator validator = new FornecedorValidator();
                ValidationResult results = validator.Validate(fornecedor);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
            }*/


            /*if (modo == 1)
            {
                resultado = _usuarioService.Update(null, nome, email, senha);


                if (resultado == "SUCESSO")
                {
                    msg = "MODERADOR cadastrado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao cadastrar MODERADOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else*/
            if (modo == 2)
            {
                resultado = _usuarioService.Update(id,nome, idade, email, senha);
                if (resultado == "SUCESSO")
                {
                    msg = "USUÁRIO atualizado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao atualizar USUÁRIO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            modo = 0;
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {

                int.TryParse(txtId.Text, out int id);

                resultado = _usuarioService.Delete(id);

                if (resultado == "SUCESSO")
                {
                    msg = "USUÁRIO excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir USUÁRIO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            carregaGridView();
            modo = 0;
            Habilita();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma inativação?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {

                int.TryParse(txtId.Text, out int id);

                resultado = _usuarioService.Inative(id);

                if (resultado == "SUCESSO")
                {
                    msg = "USUÁRIO inativado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao inativar USUÁRIO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostraInativos_Click(object sender, EventArgs e)
        {
            dgUsuario.DataSource = _usuarioService.GetAllInativos();
            dgUsuario.Refresh();
        }
    }
}
