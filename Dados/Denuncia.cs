using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Denuncia
    {
        public int id { get; set; }
        public Denuncia() { }

        public Denuncia(int id) { this.id = id; }

        public override bool Equals(object? obj)
        {
            return obj is Denuncia denuncia &&
                   id == denuncia.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
