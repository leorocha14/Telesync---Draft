namespace Telesync
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCadCliente;
            btnCadCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            btnCadCliente.Location = new System.Drawing.Point(13, 13);
            btnCadCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new System.Drawing.Size(128, 63);
            btnCadCliente.TabIndex = 0;
            btnCadCliente.Text = "Cadastrar Clientes";
            btnCadCliente.UseVisualStyleBackColor = true;
            btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(btnCadCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

