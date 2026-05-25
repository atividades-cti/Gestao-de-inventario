namespace Gestão_de_inventário
{
    partial class Form1
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
            btCadastrar = new Button();
            btRelatorio = new Button();
            SuspendLayout();
            //
            // btCadastrar
            //
            btCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btCadastrar.Location = new Point(90, 70);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(220, 50);
            btCadastrar.TabIndex = 0;
            btCadastrar.Text = "Cadastrar Novo Item";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            //
            // btRelatorio
            //
            btRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btRelatorio.Location = new Point(90, 140);
            btRelatorio.Name = "btRelatorio";
            btRelatorio.Size = new Size(220, 50);
            btRelatorio.TabIndex = 1;
            btRelatorio.Text = "Exibir Relatório";
            btRelatorio.UseVisualStyleBackColor = true;
            btRelatorio.Click += btRelatorio_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(btRelatorio);
            Controls.Add(btCadastrar);
            Name = "Form1";
            Text = "Controle de Estoque";
            ResumeLayout(false);
        }

        #endregion

        private Button btCadastrar;
        private Button btRelatorio;
    }
}
