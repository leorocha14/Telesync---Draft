using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class VendaCliente
    {

        public string codVendaCli { get; private set; }
        public string codVenda { get; private set; }
        public string cpfCliente { get; private set; }
        public string ddd { get; private set; }
        public string numero { get; private set; }
        public string numChip { get; set; }

        public VendaCliente(string codVendaCli, string codVenda, string cpfCliente, string ddd, string numero,string numChip)
        {
            this.codVendaCli = codVendaCli;
            this.cpfCliente = cpfCliente;
            this.codVenda = codVenda;
            this.ddd = ddd;
            this.numero = numero;
            this.numChip = numChip;
        }
    }
}
