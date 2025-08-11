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
    public partial class frmPerfil : Form
    {
        private frmInicial parentFrm;

        public frmPerfil(frmInicial parent)
        {
            InitializeComponent();
            parentFrm = parent;
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
        }
    }
}
