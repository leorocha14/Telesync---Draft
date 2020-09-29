﻿namespace Telesync.views
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
            this.components = new System.ComponentModel.Container();
            this.btnAdicionar = new System.Windows.Forms.Button();
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEncVenda = new System.Windows.Forms.Button();
            this.btnGerarVenda = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(456, 237);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(89, 53);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.txtDDD.Location = new System.Drawing.Point(521, 36);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.ReadOnly = true;
            this.txtDDD.Size = new System.Drawing.Size(121, 22);
            this.txtDDD.TabIndex = 4;
            // 
            // cbPlano
            // 
            this.cbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlano.Enabled = false;
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "familia",
            "selfie",
            "controle",
            "casa"});
            this.cbPlano.Location = new System.Drawing.Point(521, 6);
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
            this.label2.Location = new System.Drawing.Point(453, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DDD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plano";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(523, 92);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(119, 22);
            this.txtNumero.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "CodVenda";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(118, 38);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(60, 22);
            this.txtCodVenda.TabIndex = 11;
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Location = new System.Drawing.Point(12, 305);
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.RowHeadersWidth = 51;
            this.dgvPlanos.RowTemplate.Height = 24;
            this.dgvPlanos.Size = new System.Drawing.Size(645, 150);
            this.dgvPlanos.TabIndex = 13;
            this.dgvPlanos.Tag = "";
            this.dgvPlanos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "CodVendaPlano";
            // 
            // txtCodVendaPlano
            // 
            this.txtCodVendaPlano.Location = new System.Drawing.Point(373, 125);
            this.txtCodVendaPlano.Name = "txtCodVendaPlano";
            this.txtCodVendaPlano.ReadOnly = true;
            this.txtCodVendaPlano.Size = new System.Drawing.Size(60, 22);
            this.txtCodVendaPlano.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "CodPlano";
            // 
            // txtCodPlano
            // 
            this.txtCodPlano.Location = new System.Drawing.Point(373, 98);
            this.txtCodPlano.Name = "txtCodPlano";
            this.txtCodPlano.ReadOnly = true;
            this.txtCodPlano.Size = new System.Drawing.Size(60, 22);
            this.txtCodPlano.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "NumChip";
            // 
            // txtNumChip
            // 
            this.txtNumChip.Location = new System.Drawing.Point(523, 64);
            this.txtNumChip.Name = "txtNumChip";
            this.txtNumChip.ReadOnly = true;
            this.txtNumChip.Size = new System.Drawing.Size(119, 22);
            this.txtNumChip.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "DataVencimento";
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.Location = new System.Drawing.Point(373, 181);
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.txtDtVencimento.ReadOnly = true;
            this.txtDtVencimento.Size = new System.Drawing.Size(60, 22);
            this.txtDtVencimento.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(373, 153);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(60, 22);
            this.txtData.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "QtddPlanos";
            // 
            // txtQttdPlanos
            // 
            this.txtQttdPlanos.Location = new System.Drawing.Point(373, 209);
            this.txtQttdPlanos.Name = "txtQttdPlanos";
            this.txtQttdPlanos.ReadOnly = true;
            this.txtQttdPlanos.Size = new System.Drawing.Size(60, 22);
            this.txtQttdPlanos.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "ValorTotal";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(373, 70);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(60, 22);
            this.txtValorTotal.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(373, 237);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(60, 22);
            this.txtValor.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 191);
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
            this.label16.Location = new System.Drawing.Point(264, 6);
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
            this.cbFormaPag.Location = new System.Drawing.Point(267, 26);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(120, 24);
            this.cbFormaPag.TabIndex = 34;
            this.cbFormaPag.SelectedIndexChanged += new System.EventHandler(this.cbFormaPag_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(264, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "codFormaPag";
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.Location = new System.Drawing.Point(373, 265);
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.ReadOnly = true;
            this.txtCodFormaPag.Size = new System.Drawing.Size(60, 22);
            this.txtCodFormaPag.TabIndex = 36;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(553, 237);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 53);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnEncVenda
            // 
            this.btnEncVenda.Location = new System.Drawing.Point(15, 85);
            this.btnEncVenda.Name = "btnEncVenda";
            this.btnEncVenda.Size = new System.Drawing.Size(89, 53);
            this.btnEncVenda.TabIndex = 39;
            this.btnEncVenda.Text = "Encontrar Venda";
            this.btnEncVenda.UseVisualStyleBackColor = true;
            this.btnEncVenda.Click += new System.EventHandler(this.btnEncVenda_Click);
            // 
            // btnGerarVenda
            // 
            this.btnGerarVenda.Location = new System.Drawing.Point(150, 85);
            this.btnGerarVenda.Name = "btnGerarVenda";
            this.btnGerarVenda.Size = new System.Drawing.Size(89, 53);
            this.btnGerarVenda.TabIndex = 40;
            this.btnGerarVenda.Text = "Gerar Venda";
            this.btnGerarVenda.UseVisualStyleBackColor = true;
            this.btnGerarVenda.Click += new System.EventHandler(this.btnGerarVenda_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(674, 343);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 53);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(674, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 53);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 467);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGerarVenda);
            this.Controls.Add(this.btnEncVenda);
            this.Controls.Add(this.btnAlterar);
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
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmCadPlano";
            this.Text = "frmCadPlano";
            this.Load += new System.EventHandler(this.frmCadPlano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
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
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEncVenda;
        private System.Windows.Forms.Button btnGerarVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}