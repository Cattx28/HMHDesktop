using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Psicologo
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string regiao { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Psicologo() { }

        public Psicologo(int id, string nome, string cpf, string regiao, string cidade, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.regiao = regiao;
            this.cidade = cidade;
            this.email = email;
            this.senha = senha;
        }

        public override bool Equals(object? obj)
        {
            return obj is Psicologo psicologo &&
                   id == psicologo.id &&
                   nome == psicologo.nome &&
                   cpf == psicologo.cpf &&
                   regiao == psicologo.regiao &&
                   cidade == psicologo.cidade &&
                   email == psicologo.email &&
                   senha == psicologo.senha;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, nome, cpf, regiao, cidade, email, senha);
        }
    }
}
