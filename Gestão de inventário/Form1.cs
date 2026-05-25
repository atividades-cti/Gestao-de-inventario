namespace Gestão_de_inventário
{
    public partial class Form1 : Form
    {
        public List<string> produtos = new List<string>();

        public static readonly string arquivoPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "dados.txt");

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        void CarregarDados()
        {
            if (!File.Exists(arquivoPath))
            {
                File.WriteAllText(arquivoPath, "");
                return;
            }
            foreach (string linha in File.ReadAllLines(arquivoPath))
            {
                if (!string.IsNullOrWhiteSpace(linha))
                    produtos.Add(linha);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro(this);
            frm.ShowDialog();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio frm = new FrmRelatorio(produtos);
            frm.ShowDialog();
        }
    }
}
