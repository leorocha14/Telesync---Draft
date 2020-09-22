using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class Venda
    {

        public string codVenda { get; private set; }
        public string qtddPlanos { get; private set; }
        public string dataVenda { get; set; }
        public string dataVencimento { get; private set; }
        public string valorTotal { get; private set; }
        public string obs { get; private set; }



        public Venda(string codVenda, string qtddPlanos, string dataVenda, string dataVencimento, string obs,string valorTotal)
        {
            this.codVenda = codVenda;
            this.qtddPlanos = qtddPlanos;
            this.dataVenda = dataVenda;
            this.valorTotal = valorTotal;
            this.dataVencimento = dataVencimento;
            this.obs = obs;
        }
    }
}