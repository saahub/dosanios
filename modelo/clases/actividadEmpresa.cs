using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.clases
{
    public class actividadEmpresa
    {
        private int id;
        private string descripcion;

        public actividadEmpresa()
        {

        }

        public actividadEmpresa(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return descripcion;
        }

    }
}
