using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.clases
{
    public class cliente
    {
        private string rut;
        private string razonSocial;
        private string nombreContacto;
        private string mailContacto;
        private string direccion;
        private string telefono;
        private actividadEmpresa actividad;
        private tipoEmpresa tipo;

        public cliente()
        {

        }

        public cliente(string rut, string razonSocial, string nombreContacto, string mailContacto, string direccion, string telefono, actividadEmpresa actividad, tipoEmpresa tipo)
        {
            this.Rut = rut;
            this.RazonSocial = razonSocial;
            this.NombreContacto = nombreContacto;
            this.MailContacto = mailContacto;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Actividad = actividad;
            this.Tipo = tipo;
        }

        public string Rut { get => rut; set => rut = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string MailContacto { get => mailContacto; set => mailContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public actividadEmpresa Actividad { get => actividad; set => actividad = value; }
        public tipoEmpresa Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return rut;
        }

    }
}
