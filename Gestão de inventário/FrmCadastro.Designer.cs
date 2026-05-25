namespace Gestão_de_inventário
{
    partial class FrmCadastro
    {
        private System.ComponentModel.IContainer components = null;
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btAdicionar = new Button();
            SuspendLayout();
            //
            // lblNome
            //
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(20, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(129, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do produto:";
            //
            // txtNome
            //
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(165, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 27);
            txtNome.TabIndex = 1;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F);
            lblCategoria.Location = new Point(20, 80);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(79, 23);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria:";
            //
            // cmbCategoria
            //
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Higiene", "Limpeza" });
            cmbCategoria.Location = new Point(165, 77);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(195, 31);
            cmbCategoria.TabIndex = 3;
            //
            // btAdicionar
            //
            btAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btAdicionar.Location = new Point(110, 140);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(180, 45);
            btAdicionar.TabIndex = 4;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            //
            // FrmCadastro
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 220);
            Controls.Add(btAdicionar);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmCadastro";
            Text = "Cadastro de Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Button btAdicionar;
    }
}
