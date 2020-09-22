using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class Pedido
    {
        
        public string numPedido { get; private set; }



        public Pedido(string  numPedido)
        {
            this.numPedido = numPedido;
        }
    }
}