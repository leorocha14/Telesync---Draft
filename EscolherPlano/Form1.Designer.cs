namespace EscolherPlano
{
    partial class F_EscolherPlano
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
            this.lt_planos = new System.Windows.Forms.ListView();
            this.col_plano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_vlrUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_planoTelefonia = new System.Windows.Forms.ComboBox();
            this.cb_qtdeChips = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vlrPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vlrTotal = new System.Windows.Forms.TextBox();
            this.cb_planoInternet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_qtdeChips = new System.Windows.Forms.TextBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lt_planos
            // 
            this.lt_planos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_plano,
            this.col_vlrUnitario});
            this.lt_planos.HideSelection = false;
            this.lt_planos.Location = new System.Drawing.Point(21, 179);
            this.lt_planos.Name = "lt_planos";
            this.lt_planos.Scrollable = false;
            this.lt_planos.Size = new System.Drawing.Size(545, 309);
            this.lt_planos.TabIndex = 0;
            this.lt_planos.UseCompatibleStateImageBehavior = false;
            this.lt_planos.View = System.Windows.Forms.View.Details;
            // 
            // col_plano
            // 
            this.col_plano.Text = "Nome do Plano";
            this.col_plano.Width = 300;
            // 
            // col_vlrUnitario
            // 
            this.col_vlrUnitario.Text = "Valor Unitário";
            this.col_vlrUnitario.Width = 400;
            // 
            // cb_planoTelefonia
            // 
            this.cb_planoTelefonia.FormattingEnabled = true;
            this.cb_planoTelefonia.Items.AddRange(new object[] {
            "",
            "Plano Telefone Controle Smart",
            "Plano Telefone Sem Limites",
            "Plano Familar 4 linhas Sem limites"});
            this.cb_planoTelefonia.Location = new System.Drawing.Point(21, 47);
            this.cb_planoTelefonia.Name = "cb_planoTelefonia";
            this.cb_planoTelefonia.Size = new System.Drawing.Size(422, 24);
            this.cb_planoTelefonia.TabIndex = 1;
            this.cb_planoTelefonia.SelectedIndexChanged += new System.EventHandler(this.btn_adcionar_Click);
            // 
            // cb_qtdeChips
            // 
            this.cb_qtdeChips.FormattingEnabled = true;
            this.cb_qtdeChips.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_qtdeChips.Location = new System.Drawing.Point(460, 47);
            this.cb_qtdeChips.Name = "cb_qtdeChips";
            this.cb_qtdeChips.Size = new System.Drawing.Size(106, 24);
            this.cb_qtdeChips.TabIndex = 2;
            this.cb_qtdeChips.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade Chip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plano Telefonia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Planos selecionados";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(586, 179);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(133, 27);
            this.btn_remover.TabIndex = 7;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(581, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do Plano";
            // 
            // tb_vlrPlano
            // 
            this.tb_vlrPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vlrPlano.Location = new System.Drawing.Point(584, 320);
            this.tb_vlrPlano.Name = "tb_vlrPlano";
            this.tb_vlrPlano.Size = new System.Drawing.Size(135, 30);
            this.tb_vlrPlano.TabIndex = 9;
            this.tb_vlrPlano.TextChanged += new System.EventHandler(this.tb_vlrPlano_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(581, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Total";
            // 
            // tb_vlrTotal
            // 
            this.tb_vlrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vlrTotal.Location = new System.Drawing.Point(586, 391);
            this.tb_vlrTotal.Name = "tb_vlrTotal";
            this.tb_vlrTotal.Size = new System.Drawing.Size(133, 30);
            this.tb_vlrTotal.TabIndex = 11;
            // 
            // cb_planoInternet
            // 
            this.cb_planoInternet.FormattingEnabled = true;
            this.cb_planoInternet.Items.AddRange(new object[] {
            "Pacote Internet 2Gb",
            "Pacote Internet 4 Gb",
            "Pacote Internet 6 Gb",
            "Pacote Internet 10 Gb",
            "Pacote Internet Compartilhado 20 Gb"});
            this.cb_planoInternet.Location = new System.Drawing.Point(21, 109);
            this.cb_planoInternet.Name = "cb_planoInternet";
            this.cb_planoInternet.Size = new System.Drawing.Size(422, 24);
            this.cb_planoInternet.TabIndex = 12;
            this.cb_planoInternet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Plano Internet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(583, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Qtde Chips";
            // 
            // tb_qtdeChips
            // 
            this.tb_qtdeChips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtdeChips.Location = new System.Drawing.Point(586, 248);
            this.tb_qtdeChips.Name = "tb_qtdeChips";
            this.tb_qtdeChips.Size = new System.Drawing.Size(133, 30);
            this.tb_qtdeChips.TabIndex = 15;
            this.tb_qtdeChips.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_comprar.Location = new System.Drawing.Point(588, 453);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(135, 35);
            this.btn_comprar.TabIndex = 16;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            // 
            // F_EscolherPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 509);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.tb_qtdeChips);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_planoInternet);
            this.Controls.Add(this.tb_vlrTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_vlrPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_qtdeChips);
            this.Controls.Add(this.cb_planoTelefonia);
            this.Controls.Add(this.lt_planos);
            this.Name = "F_EscolherPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolher Plano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lt_planos;
        private System.Windows.Forms.ComboBox cb_planoTelefonia;
        private System.Windows.Forms.ComboBox cb_qtdeChips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_plano;
        private System.Windows.Forms.ColumnHeader col_vlrUnitario;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vlrPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vlrTotal;
        private System.Windows.Forms.ComboBox cb_planoInternet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_qtdeChips;
        private System.Windows.Forms.Button btn_comprar;
    }
}

