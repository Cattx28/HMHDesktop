using Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DenunciaService
    {
        private DenunciaRepository _repository;

        public DenunciaService() {
            _repository = new DenunciaRepository();
        }
        public string DeleteMensagem(int idMensagem)
        {
            return _repository.DeleteMensagem(idMensagem);
        }

        public string DeleteResposta(int idResposta)
        {
            return _repository.DeleteResposta(idResposta);
        }

        public DataTable getAllMensagem()
        {
            return _repository.getAllMensagem();
        }

        public DataTable getAllResposta()
        {
            return _repository.getAllResposta();
        }

        public DataTable filterByIdMensagem(int? idMensagem)
        {
            return _repository.filterByIdMensagem(idMensagem);
        }

        public DataTable filterByIdResposta(int? idResposta)
        {
            return _repository.filterByIdResposta(idResposta);
        }

    }
}
