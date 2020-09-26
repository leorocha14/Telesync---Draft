using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class Plano
    {
        public string codPlano { get; private set; }
        public string nomePlano { get; private set; }
        public string tipo { get; set; }
        public string valor { get; private set; }
        public Plano(string codPlano)
        {
            this.codPlano = codPlano;
        }
    }
}
