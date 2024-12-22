using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Usuario
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, int idade, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.senha = senha;
        }

        public override bool Equals(object? obj)
        {
            return obj is Usuario usuario &&
                   id == usuario.id &&
                   nome == usuario.nome &&
                   idade == usuario.idade &&
                   email == usuario.email &&
                   senha == usuario.senha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, nome, idade, email, senha);
        }
    }
}
