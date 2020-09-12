namespace EscolherPlano
{
    partial class Form1
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
            this.cb_lista_opcao = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_adcionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vlrPlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vlrTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lt_planos
            // 
            this.lt_planos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_plano,
            this.col_vlrUnitario});
            this.lt_planos.HideSelection = false;
            this.lt_planos.Location = new System.Drawing.Point(21, 109);
            this.lt_planos.Name = "lt_planos";
            this.lt_planos.Size = new System.Drawing.Size(545, 250);
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
            // cb_lista_opcao
            // 
            this.cb_lista_opcao.FormattingEnabled = true;
            this.cb_lista_opcao.Items.AddRange(new object[] {
            "",
            "Plano Telefone Controle Smart",
            "Plano Telefone Sem Limites",
            "Plano Familar 4 linhas Sem limites",
            "Pacote Internet 2Gb",
            "Pacote Internet 4 Gb",
            "Pacote Internet 6 Gb",
            "Pacote Internet 10 Gb",
            "Pacote Internet Compartilhado 20 Gb"});
            this.cb_lista_opcao.Location = new System.Drawing.Point(21, 47);
            this.cb_lista_opcao.Name = "cb_lista_opcao";
            this.cb_lista_opcao.Size = new System.Drawing.Size(422, 24);
            this.cb_lista_opcao.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(460, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 24);
            this.comboBox2.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Planos selecionados";
            // 
            // btn_adcionar
            // 
            this.btn_adcionar.Location = new System.Drawing.Point(586, 109);
            this.btn_adcionar.Name = "btn_adcionar";
            this.btn_adcionar.Size = new System.Drawing.Size(108, 23);
            this.btn_adcionar.TabIndex = 6;
            this.btn_adcionar.Text = "Escolher";
            this.btn_adcionar.UseVisualStyleBackColor = true;
            this.btn_adcionar.Click += new System.EventHandler(this.btn_adcionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(586, 168);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(108, 23);
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
            this.label4.Location = new System.Drawing.Point(581, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do Plano";
            // 
            // tb_vlrPlano
            // 
            this.tb_vlrPlano.Location = new System.Drawing.Point(586, 257);
            this.tb_vlrPlano.Name = "tb_vlrPlano";
            this.tb_vlrPlano.Size = new System.Drawing.Size(108, 22);
            this.tb_vlrPlano.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(587, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Total";
            // 
            // tb_vlrTotal
            // 
            this.tb_vlrTotal.Location = new System.Drawing.Point(588, 337);
            this.tb_vlrTotal.Name = "tb_vlrTotal";
            this.tb_vlrTotal.Size = new System.Drawing.Size(106, 22);
            this.tb_vlrTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 371);
            this.Controls.Add(this.tb_vlrTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_vlrPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adcionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cb_lista_opcao);
            this.Controls.Add(this.lt_planos);
            this.Name = "Form1";
            this.Text = "Escolher Plano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lt_planos;
        private System.Windows.Forms.ComboBox cb_lista_opcao;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_plano;
        private System.Windows.Forms.ColumnHeader col_vlrUnitario;
        private System.Windows.Forms.Button btn_adcionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vlrPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vlrTotal;
    }
}

