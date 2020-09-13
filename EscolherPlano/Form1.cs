using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace EscolherPlano
{
    public partial class F_EscolherPlano : Form
    {

         public F_EscolherPlano()
        {
            InitializeComponent();
        }

        private void btn_adcionar_Click(object sender, EventArgs e)
        {
            
            ComboBox cmb = (ComboBox)sender;
            int selectedindex = cmb.SelectedIndex;
                        
            double[] vlrUnitTel = new double[3];
            vlrUnitTel[0] = 123.10;
            vlrUnitTel[1] = 300.10;
            vlrUnitTel[2] = 400.10;
            
            string[] tel = new string[2];
            tel[0] = cb_planoTelefonia.Text;
            tel[1] = String.Format(CultureInfo.GetCultureInfo("pt-BR"),"{0:C}",vlrUnitTel[selectedindex]);
            
            ListViewItem lst = new ListViewItem(tel);
            lt_planos.Items.Add(lst);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cmb = (ComboBox)sender;
            int selectedindex = cmb.SelectedIndex;

            double[] vlrUnitInt = new double[5];
            vlrUnitInt[0] = 223.10;
            vlrUnitInt[1] = 500.10;
            vlrUnitInt[2] = 700.10;
            vlrUnitInt[3] = 800.10;
            vlrUnitInt[4] = 900.10;

            string[] net = new string[2];
            net[0] = cb_planoInternet.Text;
            net[1] = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", vlrUnitInt[selectedindex]);

            ListViewItem lst = new ListViewItem(net);
            lt_planos.Items.Add(lst);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_vlrPlano_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cb_dddPort.Text = "";
            tb_NumPort.Text = "";
            rb_Novo.Checked = true;
        }

        private void rb_Novo_CheckedChanged(object sender, EventArgs e)
        {
            cb_dddPort.Text = "";
            tb_NumPort.Text = "";
        }

        private void rb_Portabilidade_CheckedChanged(object sender, EventArgs e)
        {
            cb_dddNovo.Text = "";
            cb_NumNovo.Text = "";
        }

        public void Limpar()
        {
            lt_planos.Items.Clear();
            cb_dddNovo.Text = "";
            cb_dddPort.Text = "";
            cb_NumNovo.Text = "";
            tb_NumPort.Text = "";
            cb_planoTelefonia.Text = "";
            cb_planoInternet.Text = "";
            tb_vlrPlano.Text = "";
            tb_vlrTotal.Text = "";
            cb_planoTelefonia.Focus();
            rb_Novo.Checked = true;
        }

        private void btn_ProxNum_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            
            if (tb_vlrPlano.Text == "")
            {
                MessageBox.Show("Um plano deve ser escolhido.");
            }
        }
        
        private void cb_dddPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_dddNovo.Text = "";
            cb_NumNovo.Text = "";
            rb_Portabilidade.Checked = true;
            
        }

        private void cb_dddNovo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_dddPort.Text = "";
            tb_NumPort.Text = "";
            rb_Novo.Checked = true;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_EscolherPlano_Load(object sender, EventArgs e)
        {

        }
    }
}
