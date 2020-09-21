using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class Pedido
    {
        public string nomePlano { get; private set; }
        public string ddd { get; private set; }
        public string numero { get; private set; }
        public string  numPedido{ get; private set; }
        public string cpfCliente { get; private set; }


        public Pedido(string nomePlano, string ddd, string numero, string cpfCliente)
        {
            this.nomePlano = nomePlano;
            this.ddd = ddd;
            this.numero = numero;
            this.cpfCliente = cpfCliente;
        }
    }
}
