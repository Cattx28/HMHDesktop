namespace Apresentação
{
    public partial class frmBusca : Form
    {
        private int _busca;
        public frmBusca()
        {
            InitializeComponent();
            Busca = 0;
        }

        public int Busca { get => _busca; set => _busca = value; }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusca.Text, out int busca))
            {
                Busca = busca;
            }
            else
                MessageBox.Show("Por favor, insira um número válido.");

            this.Close();
        }
    }
}
