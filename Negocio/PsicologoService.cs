using Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PsicologoService
    {
        private PsicologoRepository _repository;

        public PsicologoService()
        {
            _repository = new PsicologoRepository();
        }

        public string Update(int? id, string nome, string cpf, string regiao, string cidade, string email, string senha)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var psicologo = new Psicologo
            {
                id = id,
                nome = nome,
                cpf = cpf,
                regiao = regiao,
                cidade = cidade,
                email = email,
                senha = senha
            };

            if (id == null)
                return _repository.Insert(psicologo);
            else
                return _repository.Update(psicologo);

        }

        public string Insert(Psicologo psicologo)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(psicologo);

        }

        public string Inative(int idPsicologo) { 

            return _repository.Inativar(idPsicologo);
        }

        public string Delete(int idPsicologo)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Delete(idPsicologo);

        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }

        public DataTable GetAllInativos()
        {
            return _repository.getAllInativos();
        }
        public DataTable filterById(int? idPsicologo)
        {
            return _repository.filterById(idPsicologo);
        }
    }
}
