namespace Telesync.views
{
    partial class frmCadPlano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.cbPlano = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodVendaCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodVendaPlano = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodPlano = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumChip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDtVencimento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQttdPlanos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCodFormaPag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 291);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(164, 291);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(118, 12);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(121, 22);
            this.txtCPF.TabIndex = 2;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(118, 70);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(121, 22);
            this.txtDDD.TabIndex = 4;
            // 
            // cbPlano
            // 
            this.cbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "familia",
            "selfie",
            "controle",
            "casa"});
            this.cbPlano.Location = new System.Drawing.Point(118, 40);
            this.cbPlano.Name = "cbPlano";
            this.cbPlano.Size = new System.Drawing.Size(121, 24);
            this.cbPlano.TabIndex = 5;
            this.cbPlano.SelectedIndexChanged += new System.EventHandler(this.cbPlano_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DDD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plano";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(118, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(121, 22);
            this.txtNumero.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "CodVenda";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(383, 14);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.ReadOnly = true;
            this.txtCodVenda.Size = new System.Drawing.Size(60, 22);
            this.txtCodVenda.TabIndex = 11;
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 320);
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.RowHeadersWidth = 51;
            this.dgvPlanos.RowTemplate.Height = 24;
            this.dgvPlanos.Size = new System.Drawing.Size(645, 150);
            this.dgvPlanos.TabIndex = 13;
            this.dgvPlanos.Tag = "";
            this.dgvPlanos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanos_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "CodVendaCli";
            // 
            // txtCodVendaCli
            // 
            this.txtCodVendaCli.Location = new System.Drawing.Point(383, 40);
            this.txtCodVendaCli.Name = "txtCodVendaCli";
            this.txtCodVendaCli.ReadOnly = true;
            this.txtCodVendaCli.Size = new System.Drawing.Size(60, 22);
            this.txtCodVendaCli.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "CodVendaPlano";
            // 
            // txtCodVendaPlano
            // 
            this.txtCodVendaPlano.Location = new System.Drawing.Point(383, 98);
            this.txtCodVendaPlano.Name = "txtCodVendaPlano";
            this.txtCodVendaPlano.ReadOnly = true;
            this.txtCodVendaPlano.Size = new System.Drawing.Size(60, 22);
            this.txtCodVendaPlano.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "CodPlano";
            // 
            // txtCodPlano
            // 
            this.txtCodPlano.Location = new System.Drawing.Point(383, 68);
            this.txtCodPlano.Name = "txtCodPlano";
            this.txtCodPlano.ReadOnly = true;
            this.txtCodPlano.Size = new System.Drawing.Size(60, 22);
            this.txtCodPlano.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "NumChip";
            // 
            // txtNumChip
            // 
            this.txtNumChip.Location = new System.Drawing.Point(524, 98);
            this.txtNumChip.Name = "txtNumChip";
            this.txtNumChip.ReadOnly = true;
            this.txtNumChip.Size = new System.Drawing.Size(119, 22);
            this.txtNumChip.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "DataVencimento";
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.Location = new System.Drawing.Point(383, 154);
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.txtDtVencimento.ReadOnly = true;
            this.txtDtVencimento.Size = new System.Drawing.Size(60, 22);
            this.txtDtVencimento.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(383, 126);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(60, 22);
            this.txtData.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "QtddPlanos";
            // 
            // txtQttdPlanos
            // 
            this.txtQttdPlanos.Location = new System.Drawing.Point(383, 182);
            this.txtQttdPlanos.Name = "txtQttdPlanos";
            this.txtQttdPlanos.ReadOnly = true;
            this.txtQttdPlanos.Size = new System.Drawing.Size(60, 22);
            this.txtQttdPlanos.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "ValorTotal";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(524, 73);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(60, 22);
            this.txtValorTotal.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(383, 210);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(60, 22);
            this.txtValor.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 169);
            this.txtObs.MaxLength = 37273;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(227, 108);
            this.txtObs.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(524, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "FormaPagamento";
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Items.AddRange(new object[] {
            "Debito",
            "Boleto"});
            this.cbFormaPag.Location = new System.Drawing.Point(524, 43);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(120, 24);
            this.cbFormaPag.TabIndex = 34;
            this.cbFormaPag.SelectedIndexChanged += new System.EventHandler(this.cbFormaPag_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(274, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "codFormaPag";
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.Location = new System.Drawing.Point(383, 238);
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.ReadOnly = true;
            this.txtCodFormaPag.Size = new System.Drawing.Size(60, 22);
            this.txtCodFormaPag.TabIndex = 36;
            // 
            // frmCadPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 467);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbFormaPag);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQttdPlanos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDtVencimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumChip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodVendaPlano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodPlano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodVendaCli);
            this.Controls.Add(this.dgvPlanos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlano);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmCadPlano";
            this.Text = "frmCadPlano";
            this.Load += new System.EventHandler(this.frmCadPlano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.ComboBox cbPlano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodVendaCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodVendaPlano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodPlano;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumChip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDtVencimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQttdPlanos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbFormaPag;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCodFormaPag;
    }
}