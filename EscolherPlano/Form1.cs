using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolherPlano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adcionar_Click(object sender, EventArgs e)
        {
            string[] pl = new string[2];
            pl[0] = cb_lista_opcao.Text;
            pl[1] = "";

            ListViewItem lst = new ListViewItem(pl);

            lt_planos.Items.Add(lst);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lt_planos.Items.Clear();
        }
    }
}
