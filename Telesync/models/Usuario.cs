using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telesync.models
{
    class Usuario
    {
        public string cpf { get; }
        public string nome { get; }
        public string nomeMae { get; }
        public string sexo { get; }
        public string email { get; }
        public string bairro { get; }
        public string cep { get; }
        public string logradouro { get; }
        public string numero { get; }
        public string uf { get; }
        public string cidade { get; }
        public string complemento { get; }
        public string senha { get; }
        public Usuario(string cpf, string nome, string nomeMae, string sexo, string email, string bairro, string cep, string logradouro, string numero, string uf, string cidade, string complemento, string senha)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.nomeMae = nomeMae;
            this.sexo = sexo;
            this.email = email;
            this.bairro = bairro;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.cidade = cidade;
            this.uf = uf;
            this.complemento = complemento;
            this.senha = senha;
        }
    }
}
