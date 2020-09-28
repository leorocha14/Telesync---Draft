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
        public string cpfCliente { get; private set; }
        public string codFormaPagamento { get; private set; }
        public string codStatusPag { get; private set; }
        public string obs { get; private set; }



        public Venda(string codVenda, string cpfCliente, string codFormaPagamento, string qtddPlanos, string dtVenda, string dtVencimento, string obs,string valorTotal, string codStatusPag)
        {
            this.codFormaPagamento = codFormaPagamento;
            this.codVenda = codVenda;
            this.cpfCliente = cpfCliente;
            this.qtddPlanos = qtddPlanos;
            this.dtVenda = dtVenda;
            this.valorTotal = valorTotal;
            this.dtVencimento = dtVencimento;
            this.codStatusPag = codStatusPag;
            this.obs = obs;
        }
    }
}