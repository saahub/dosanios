using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.clases
{
    public class tipoEvento
    {
        private int id;
        private string descripcion;
        private int valorBase;
        private int personalBase;

        public tipoEvento()
        {

        }

        public tipoEvento(int id, string descripcion, int valorBase, int personalBase)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.ValorBase = valorBase;
            this.PersonalBase = personalBase;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int ValorBase { get => valorBase; set => valorBase = value; }
        public int PersonalBase { get => personalBase; set => personalBase = value; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
