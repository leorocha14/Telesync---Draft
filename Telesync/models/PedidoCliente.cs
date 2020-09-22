using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class PedidoCliente
    {

        public string numPedCli { get; private set; }
        public string cpfCliente { get; private set; }
        public string numPed { get; set; }
        public string nomePlano { get; private set; }
        public string ddd { get; private set; }
        public string numero { get; private set; }

        public PedidoCliente(string numPedCli, string cpfCliente, string numPed, string nomePlano, string ddd, string numero)
        {
            this.numPed = numPed;
            this.cpfCliente = cpfCliente;
            this.numPedCli = numPedCli;
            this.nomePlano = nomePlano;
            this.ddd = ddd;
            this.numero = numero;
        }
    }
}
