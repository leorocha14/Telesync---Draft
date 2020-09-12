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
            lt_planos.Items.Clear();
            
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
            tb_qtdeChips.Text = cb_qtdeChips.SelectedItem.ToString();
        }

        private void tb_vlrPlano_TextChanged(object sender, EventArgs e)
        {
          
            
        }
    }
}
