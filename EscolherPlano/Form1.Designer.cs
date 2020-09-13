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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vlrPlano = new System.Windows.Forms.TextBox();
            this.cb_planoInternet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.rb_Portabilidade = new System.Windows.Forms.RadioButton();
            this.rb_Novo = new System.Windows.Forms.RadioButton();
            this.cb_NumNovo = new System.Windows.Forms.ComboBox();
            this.cb_dddPort = new System.Windows.Forms.ComboBox();
            this.cb_dddNovo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_NumPort = new System.Windows.Forms.MaskedTextBox();
            this.btn_ProxNum = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_VerPlanos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.lt_planos.Size = new System.Drawing.Size(545, 192);
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
            "Plano Telefone Controle Smart",
            "Plano Telefone Sem Limites",
            "Plano Familar 4 linhas Sem limites"});
            this.cb_planoTelefonia.Location = new System.Drawing.Point(21, 47);
            this.cb_planoTelefonia.Name = "cb_planoTelefonia";
            this.cb_planoTelefonia.Size = new System.Drawing.Size(545, 24);
            this.cb_planoTelefonia.TabIndex = 1;
            this.cb_planoTelefonia.SelectedIndexChanged += new System.EventHandler(this.btn_adcionar_Click);
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
            this.btn_remover.Location = new System.Drawing.Point(595, 47);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(129, 27);
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
            this.label4.Location = new System.Drawing.Point(588, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do Plano";
            // 
            // tb_vlrPlano
            // 
            this.tb_vlrPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vlrPlano.Location = new System.Drawing.Point(593, 283);
            this.tb_vlrPlano.Name = "tb_vlrPlano";
            this.tb_vlrPlano.Size = new System.Drawing.Size(137, 30);
            this.tb_vlrPlano.TabIndex = 9;
            this.tb_vlrPlano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_vlrPlano.TextChanged += new System.EventHandler(this.tb_vlrPlano_TextChanged);
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
            this.cb_planoInternet.Size = new System.Drawing.Size(545, 24);
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
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_comprar.Location = new System.Drawing.Point(593, 406);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(135, 35);
            this.btn_comprar.TabIndex = 16;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // rb_Portabilidade
            // 
            this.rb_Portabilidade.AutoSize = true;
            this.rb_Portabilidade.Location = new System.Drawing.Point(15, 34);
            this.rb_Portabilidade.Name = "rb_Portabilidade";
            this.rb_Portabilidade.Size = new System.Drawing.Size(112, 21);
            this.rb_Portabilidade.TabIndex = 17;
            this.rb_Portabilidade.Text = "Portabilidade";
            this.rb_Portabilidade.UseVisualStyleBackColor = true;
            this.rb_Portabilidade.CheckedChanged += new System.EventHandler(this.rb_Portabilidade_CheckedChanged);
            // 
            // rb_Novo
            // 
            this.rb_Novo.AutoSize = true;
            this.rb_Novo.Checked = true;
            this.rb_Novo.Location = new System.Drawing.Point(15, 73);
            this.rb_Novo.Name = "rb_Novo";
            this.rb_Novo.Size = new System.Drawing.Size(62, 21);
            this.rb_Novo.TabIndex = 18;
            this.rb_Novo.TabStop = true;
            this.rb_Novo.Text = "Novo";
            this.rb_Novo.UseVisualStyleBackColor = true;
            this.rb_Novo.CheckedChanged += new System.EventHandler(this.rb_Novo_CheckedChanged);
            // 
            // cb_NumNovo
            // 
            this.cb_NumNovo.FormattingEnabled = true;
            this.cb_NumNovo.Items.AddRange(new object[] {
            "99752-2532",
            "99785-1245",
            "99452-1423",
            "99781-2423",
            "98812-3645"});
            this.cb_NumNovo.Location = new System.Drawing.Point(250, 70);
            this.cb_NumNovo.Name = "cb_NumNovo";
            this.cb_NumNovo.Size = new System.Drawing.Size(118, 24);
            this.cb_NumNovo.TabIndex = 20;
            this.cb_NumNovo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cb_dddPort
            // 
            this.cb_dddPort.FormattingEnabled = true;
            this.cb_dddPort.Items.AddRange(new object[] {
            "11",
            "15",
            "19",
            "41",
            "51"});
            this.cb_dddPort.Location = new System.Drawing.Point(151, 31);
            this.cb_dddPort.Name = "cb_dddPort";
            this.cb_dddPort.Size = new System.Drawing.Size(72, 24);
            this.cb_dddPort.TabIndex = 22;
            this.cb_dddPort.SelectedIndexChanged += new System.EventHandler(this.cb_dddPort_SelectedIndexChanged);
            // 
            // cb_dddNovo
            // 
            this.cb_dddNovo.FormattingEnabled = true;
            this.cb_dddNovo.Items.AddRange(new object[] {
            "11",
            "15",
            "19",
            "41",
            "51"});
            this.cb_dddNovo.Location = new System.Drawing.Point(151, 70);
            this.cb_dddNovo.Name = "cb_dddNovo";
            this.cb_dddNovo.Size = new System.Drawing.Size(72, 24);
            this.cb_dddNovo.TabIndex = 23;
            this.cb_dddNovo.SelectedIndexChanged += new System.EventHandler(this.cb_dddNovo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "DDD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Número";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_NumPort);
            this.groupBox1.Controls.Add(this.rb_Portabilidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rb_Novo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_NumNovo);
            this.groupBox1.Controls.Add(this.cb_dddNovo);
            this.groupBox1.Controls.Add(this.cb_dddPort);
            this.groupBox1.Location = new System.Drawing.Point(21, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 116);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolher Número";
            // 
            // tb_NumPort
            // 
            this.tb_NumPort.Location = new System.Drawing.Point(250, 34);
            this.tb_NumPort.Mask = "00000-0000";
            this.tb_NumPort.Name = "tb_NumPort";
            this.tb_NumPort.Size = new System.Drawing.Size(118, 22);
            this.tb_NumPort.TabIndex = 27;
            // 
            // btn_ProxNum
            // 
            this.btn_ProxNum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ProxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProxNum.ForeColor = System.Drawing.Color.White;
            this.btn_ProxNum.Location = new System.Drawing.Point(593, 158);
            this.btn_ProxNum.Name = "btn_ProxNum";
            this.btn_ProxNum.Size = new System.Drawing.Size(135, 38);
            this.btn_ProxNum.TabIndex = 27;
            this.btn_ProxNum.Text = "Novo Chip";
            this.btn_ProxNum.UseVisualStyleBackColor = false;
            this.btn_ProxNum.Click += new System.EventHandler(this.btn_ProxNum_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(595, 465);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(133, 23);
            this.btn_Sair.TabIndex = 28;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Location = new System.Drawing.Point(595, 217);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(131, 29);
            this.btn_Finalizar.TabIndex = 29;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            // 
            // btn_VerPlanos
            // 
            this.btn_VerPlanos.Location = new System.Drawing.Point(593, 105);
            this.btn_VerPlanos.Name = "btn_VerPlanos";
            this.btn_VerPlanos.Size = new System.Drawing.Size(131, 28);
            this.btn_VerPlanos.TabIndex = 30;
            this.btn_VerPlanos.Text = "Ver Planos";
            this.btn_VerPlanos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(595, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 30);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(590, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Valor Total";
            // 
            // F_EscolherPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VerPlanos);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_ProxNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_planoInternet);
            this.Controls.Add(this.tb_vlrPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_planoTelefonia);
            this.Controls.Add(this.lt_planos);
            this.Name = "F_EscolherPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolher Plano";
            this.Load += new System.EventHandler(this.F_EscolherPlano_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lt_planos;
        private System.Windows.Forms.ComboBox cb_planoTelefonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_plano;
        private System.Windows.Forms.ColumnHeader col_vlrUnitario;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vlrPlano;
        private System.Windows.Forms.ComboBox cb_planoInternet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.RadioButton rb_Portabilidade;
        private System.Windows.Forms.RadioButton rb_Novo;
        private System.Windows.Forms.ComboBox cb_NumNovo;
        private System.Windows.Forms.ComboBox cb_dddPort;
        private System.Windows.Forms.ComboBox cb_dddNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tb_NumPort;
        private System.Windows.Forms.Button btn_ProxNum;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_VerPlanos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

