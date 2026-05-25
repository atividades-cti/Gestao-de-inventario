namespace Gestão_de_inventário
{
    public partial class FrmCadastro : Form
    {
        Form1 formPrincipal;

        public FrmCadastro(Form1 f)
        {
            formPrincipal = f;
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o nome do produto.");
                return; 
            }
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }
            string item = txtNome.Text + " | " + cmbCategoria.SelectedItem.ToString();

            formPrincipal.produtos.Add(item);
            File.AppendAllText(Form1.arquivoPath, item + Environment.NewLine);

            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Item adicionado com sucesso!");
        }
    }
}
