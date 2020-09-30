namespace Telesync.views
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adquirirUmPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceleSeuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceleSeuPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tables1 = new Telesync.resources.script.tables();
            this.cadastrarPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adquirirUmPlanoToolStripMenuItem,
            this.verPerfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adquirirUmPlanoToolStripMenuItem
            // 
            this.adquirirUmPlanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPlanoToolStripMenuItem,
            this.alterarPlanoToolStripMenuItem});
            this.adquirirUmPlanoToolStripMenuItem.Name = "adquirirUmPlanoToolStripMenuItem";
            this.adquirirUmPlanoToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.adquirirUmPlanoToolStripMenuItem.Text = "Adquirir um plano";
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarCadastroToolStripMenuItem,
            this.canceleSeuPerfilToolStripMenuItem,
            this.canceleSeuPlanoToolStripMenuItem});
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            this.verPerfilToolStripMenuItem.Click += new System.EventHandler(this.verPerfilToolStripMenuItem_Click);
            // 
            // acessarCadastroToolStripMenuItem
            // 
            this.acessarCadastroToolStripMenuItem.Name = "acessarCadastroToolStripMenuItem";
            this.acessarCadastroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acessarCadastroToolStripMenuItem.Text = "Alterar cadastro";
            this.acessarCadastroToolStripMenuItem.Click += new System.EventHandler(this.alterarCadastroToolStripMenuItem_Click);
            // 
            // canceleSeuPerfilToolStripMenuItem
            // 
            this.canceleSeuPerfilToolStripMenuItem.Name = "canceleSeuPerfilToolStripMenuItem";
            this.canceleSeuPerfilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.canceleSeuPerfilToolStripMenuItem.Text = "Cancele seu perfil";
            this.canceleSeuPerfilToolStripMenuItem.Click += new System.EventHandler(this.canceleSeuPerfilToolStripMenuItem_Click);
            // 
            // canceleSeuPlanoToolStripMenuItem
            // 
            this.canceleSeuPlanoToolStripMenuItem.Name = "canceleSeuPlanoToolStripMenuItem";
            this.canceleSeuPlanoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.canceleSeuPlanoToolStripMenuItem.Text = "Cancele seu plano";
            // 
            // tables1
            // 
            this.tables1.DataSetName = "tables";
            this.tables1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrarPlanoToolStripMenuItem
            // 
            this.cadastrarPlanoToolStripMenuItem.Name = "cadastrarPlanoToolStripMenuItem";
            this.cadastrarPlanoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrarPlanoToolStripMenuItem.Text = "Cadastrar Plano";
            this.cadastrarPlanoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPlanoToolStripMenuItem_Click);
            // 
            // alterarPlanoToolStripMenuItem
            // 
            this.alterarPlanoToolStripMenuItem.Name = "alterarPlanoToolStripMenuItem";
            this.alterarPlanoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alterarPlanoToolStripMenuItem.Text = "Alterar Plano";
            this.alterarPlanoToolStripMenuItem.Click += new System.EventHandler(this.alterarPlanoToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adquirirUmPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceleSeuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceleSeuPlanoToolStripMenuItem;
        private resources.script.tables tables1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarPlanoToolStripMenuItem;
    }
}