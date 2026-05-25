namespace Gestão_de_inventário
{
    partial class FrmRelatorio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lbxProdutos = new ListBox();
            btVoltar = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(460, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Itens cadastrados:";
            //
            // lbxProdutos
            //
            lbxProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbxProdutos.Font = new Font("Segoe UI", 10F);
            lbxProdutos.FormattingEnabled = true;
            lbxProdutos.Location = new Point(12, 45);
            lbxProdutos.Name = "lbxProdutos";
            lbxProdutos.Size = new Size(460, 320);
            lbxProdutos.TabIndex = 1;
            //
            // btVoltar
            //
            btVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btVoltar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btVoltar.Location = new Point(337, 382);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(135, 40);
            btVoltar.TabIndex = 2;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            //
            // FrmRelatorio
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 435);
            Controls.Add(btVoltar);
            Controls.Add(lbxProdutos);
            Controls.Add(lblTitulo);
            Name = "FrmRelatorio";
            Text = "Relatório de Estoque";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private ListBox lbxProdutos;
        private Button btVoltar;
    }
}
