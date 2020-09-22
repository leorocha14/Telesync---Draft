using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class VendaPlano
    {
        public string codVendaPlano { get; private set; }
        public string codVenda { get; private set; }
        public string codPlano { get; private set; }
        public VendaPlano(string codPlano, string codVendaPlano, string codVenda)
        {
            this.codPlano = codPlano;
            this.codVendaPlano = codVendaPlano;
            this.codVenda = codVenda;
        }
    }
}
