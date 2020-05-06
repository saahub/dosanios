using Negocio.Reglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Negocio
{
    public class ReglaAdministradorCliente
    {
        public void ValidarCliente(string rut)
        {
            RutRule rutR = new RutRule();
            rutR.ValidarFormatoRut(rut);
            

        }

       
       
        
    }
}
