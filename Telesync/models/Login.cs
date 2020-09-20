using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    public class Login
    {
        public string usuarioId { get; private set; }
        public string senha { get; private set; }

        public Login(string usuarioId, string senha)
        {
            this.usuarioId = usuarioId;
            this.senha = senha;
        }
    }
}
