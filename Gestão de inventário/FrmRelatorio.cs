namespace Gestão_de_inventário
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio(List<string> produtos)
        {
            InitializeComponent();
            lbxProdutos.DataSource = produtos;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
