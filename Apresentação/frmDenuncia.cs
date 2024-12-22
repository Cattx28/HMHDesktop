using Dados;
using Negocio;
using Org.BouncyCastle.Asn1.Cmp;
using System.Data;

namespace Apresentação
{
    public partial class frmDenuncia : Form
    {
        private readonly DenunciaService _denunciaService;
        private DataTable tblDenuncia = new DataTable();

        private int modo = 0;
        internal DataTable dt;


        public frmDenuncia()
        {
            InitializeComponent();
            _denunciaService = new DenunciaService();
            //ConfiguraDataGridViewMensagem();
            //ConfiguraDataGridViewResposta();
        }

        private void ConfiguraDataGridViewMensagem()
        {
            // Configuração do DataGridView em um método separado
            dgDenuncia.ColumnCount = 5;
            dgDenuncia.AutoGenerateColumns = false;
            dgDenuncia.Columns[0].Width = 75;
            dgDenuncia.Columns[0].HeaderText = "ID";
            dgDenuncia.Columns[0].DataPropertyName = "idDenuncia_Mensagem";
            dgDenuncia.Columns[1].Width = 300;
            dgDenuncia.Columns[1].HeaderText = "MOTIVO";
            dgDenuncia.Columns[1].DataPropertyName = "motivo";
            dgDenuncia.Columns[2].Width = 75;
            dgDenuncia.Columns[2].HeaderText = "ID MENSAGEM";
            dgDenuncia.Columns[2].DataPropertyName = "mensagem";
            dgDenuncia.Columns[3].Width = 170;
            dgDenuncia.Columns[3].HeaderText = "CONTEÚDO";
            dgDenuncia.Columns[3].DataPropertyName = "conteudoMensagem";
            dgDenuncia.Columns[4].Width = 75;
            dgDenuncia.Columns[4].HeaderText = "ID USUÁRIO";
            dgDenuncia.Columns[4].DataPropertyName = "usuario";

            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;
        }

        public void ConfiguraDataGridViewResposta()
        {
            dgDenuncia.AutoGenerateColumns = false;
            dgDenuncia.Columns[0].Width = 75;
            dgDenuncia.Columns[0].HeaderText = "ID";
            dgDenuncia.Columns[0].DataPropertyName = "idDenuncia_Resposta";
            dgDenuncia.Columns[1].Width = 300;
            dgDenuncia.Columns[1].HeaderText = "MOTIVO";
            dgDenuncia.Columns[1].DataPropertyName = "motivo";
            dgDenuncia.Columns[2].Width = 75;
            dgDenuncia.Columns[2].HeaderText = "ID RESPOSTA";
            dgDenuncia.Columns[2].DataPropertyName = "resposta";
            dgDenuncia.Columns[3].Width = 170;
            dgDenuncia.Columns[3].HeaderText = "CONTEÚDO";
            dgDenuncia.Columns[3].DataPropertyName = "conteudoResposta";
            dgDenuncia.Columns[4].Width = 75;
            dgDenuncia.Columns[4].HeaderText = "ID PSICOLOGO";
            dgDenuncia.Columns[4].DataPropertyName = "psicologo";

        }
        private void carregaGridViewMensagem()
        { 
            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;

            dgDenuncia.DataSource = _denunciaService.getAllMensagem();
            dgDenuncia.Refresh();
        }
        private void carregaGridViewResposta()

        {
            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;

            dgDenuncia.DataSource = _denunciaService.getAllResposta();
            dgDenuncia.Refresh();
        }

        private void dgDenuncia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDenuncia.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgDenuncia.CurrentRow.Cells[3].Value);
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

                if (modo == 1)
                {
                    resultado = _denunciaService.DeleteMensagem(id);

                    if (resultado == "SUCESSO")
                    {
                        msg = "MENSAGEM excluida com sucesso!";
                        carregaGridViewMensagem();
                    }
                    else
                    {
                        msg = "Falha ao excluir MENSAGEM!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (modo == 2)
                {

                    resultado = _denunciaService.DeleteResposta(id);

                    if (resultado == "SUCESSO")
                    {
                        msg = "MENSAGEM excluida com sucesso!";
                        carregaGridViewResposta();
                    }
                    else
                    {
                        msg = "Falha ao excluir MENSAGEM!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
           ConfiguraDataGridViewMensagem();
            modo = 1;
            carregaGridViewMensagem();
        }

        private void btnRespostas_Click(object sender, EventArgs e)
        {
           ConfiguraDataGridViewResposta();
            modo = 2;
            carregaGridViewResposta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (modo == 1)
            {
                if (idBusca.HasValue)
                {
                    DataTable tblDenuncia = _denunciaService.filterByIdMensagem(idBusca.Value); // Método para buscar por ID
                    if (tblDenuncia != null)
                    {
                        dgDenuncia.DataSource = tblDenuncia;
                        dgDenuncia.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum ID foi informado.");
                }
            }
            else if (modo == 2)
            {
                if (idBusca.HasValue)
                {
                    DataTable tblDenuncia = _denunciaService.filterByIdResposta(idBusca.Value); // Método para buscar por ID
                    if (tblDenuncia != null)
                    {
                        dgDenuncia.DataSource = tblDenuncia;
                        dgDenuncia.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum ID foi informado.");
                }
            }
        }
    }
}
