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
        public string dtVenda { get; set; }
        public string dtVencimento { get; private set; }
        public string valorTotal { get; private set; }
        public string obs { get; private set; }



        public Venda(string codVenda, string qtddPlanos, string dtVenda, string dtVencimento, string obs,string valorTotal)
        {
            this.codVenda = codVenda;
            this.qtddPlanos = qtddPlanos;
            this.dtVenda = dtVenda;
            this.valorTotal = valorTotal;
            this.dtVencimento = dtVencimento;
            this.obs = obs;
        }
    }
}