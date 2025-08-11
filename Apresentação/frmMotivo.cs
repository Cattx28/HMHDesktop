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
    public partial class frmMotivo : Form
    {
        private string _motivo;
        public frmMotivo()
        {
            InitializeComponent();
            Motivo = " ";
        }

        public string Motivo { get => _motivo; set => _motivo = value; }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Motivo = txtMotivo.Text;
            (this).Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            (this).Close();
        }
    }
}
