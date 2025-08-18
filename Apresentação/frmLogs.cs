using Dados;
using Mysqlx.Crud;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentação
{
    public partial class frmLogs : Form
    {
        private readonly LogsService _logsService;

        internal DataTable dt;

        private frmInicial parentfrm;

        public frmLogs(frmInicial parent)
        {
            InitializeComponent();
            parentfrm = parent;

            _logsService = new LogsService();

            ConfiguraDataGridView();
            CarregaGridView();
        }

        private void ConfiguraDataGridView()
        {
            // Configuração do DataGridView em um método separado
            dgLogs.ColumnCount = 4;
            dgLogs.AutoGenerateColumns = false;
            dgLogs.Columns[0].Width = 75;
            dgLogs.Columns[0].HeaderText = "ID Moderador";
            dgLogs.Columns[0].DataPropertyName = "moderador";
            dgLogs.Columns[1].Width = 300;
            dgLogs.Columns[1].HeaderText = "Horário";
            dgLogs.Columns[1].DataPropertyName = "dataHora";
            dgLogs.Columns[2].Width = 325;
            dgLogs.Columns[2].HeaderText = "Ação";
            dgLogs.Columns[2].DataPropertyName = "acao";
            dgLogs.Columns[3].Width = 170;
            dgLogs.Columns[3].HeaderText = "Comentário";
            dgLogs.Columns[3].DataPropertyName = "comentario";

            dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLogs.AllowUserToAddRows = false;
            dgLogs.AllowUserToDeleteRows = false;
            dgLogs.AllowUserToOrderColumns = true;
            dgLogs.ReadOnly = true;
        }

        private void CarregaGridView()
        {
            dgLogs.DataSource = _logsService.getAll();
            dgLogs.Refresh();
        }
    }
}
