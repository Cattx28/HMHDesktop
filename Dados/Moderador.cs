using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Moderador
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
         public string senha { get; set; }

        public Moderador() { }

        public Moderador(int id, string nome, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public override bool Equals(object? obj)
        {
            return obj is Moderador moderador &&
                   id == moderador.id &&
                   nome == moderador.nome &&
                   email == moderador.email &&
                   senha == moderador.senha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, nome, email, senha);
        }
    }
}
