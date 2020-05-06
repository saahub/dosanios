using modelo.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelo.colecciones
{
    public class clienteCollection
    {
        private List<cliente> listaClientes;

        public clienteCollection()
        {
            listaClientes = new List<cliente>();
        }

        public clienteCollection(List<cliente> listaClientes)
        {
            this.ListaClientes = listaClientes;
        }

        public List<cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }




        public void RegistrarCliente(cliente cliente)
        {
            bool validador = false;

            foreach (cliente c in listaClientes)
            {
                if (c.Rut.Equals(cliente.Rut))
                {
                    validador = true;
                }
            }

            if (validador)
            {
                throw new Exception("EL CLIENTE YA SE ENCUENTRA REGISTRADO");
            }
            else
            {
                listaClientes.Add(cliente);

            }

        }

        public void GuardarModifCliente(cliente cliente)
        {
            int indice = -1;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Rut == (cliente.Rut))
                {
                    indice = i;
                }
            }
            if (indice == -1)
            {
                throw new Exception("CLIENTE NO EXISTE EN SISTEMA");
            }
            else
            {
                listaClientes[indice].Rut = cliente.Rut;
                listaClientes[indice].RazonSocial = cliente.RazonSocial;
                listaClientes[indice].NombreContacto = cliente.NombreContacto;
                listaClientes[indice].MailContacto = cliente.MailContacto;
                listaClientes[indice].Direccion = cliente.Direccion;
                listaClientes[indice].Telefono = cliente.Telefono;
                listaClientes[indice].Actividad = cliente.Actividad;
                listaClientes[indice].Tipo = cliente.Tipo;
            }


        }


        public cliente BuscarClienteRut(string rut)
        {

            cliente cliente = new cliente();

            int indice = -1;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Rut.Equals(rut))
                { indice = i; }
                
            }

            if (indice == -1)
            {
                throw new Exception("NO EXISTEN CLIENTES REGISTRADOS");
            }
            else
            {
                cliente = listaClientes[indice];

            }

            return cliente;

        }

        public List<cliente> BuscarClienteActividad(actividadEmpresa actividad)
        {
            List<cliente> listaFiltroActividad = new List<cliente>();
           
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Actividad.Id.Equals(actividad.Id))
                {
                    listaFiltroActividad.Add(listaClientes[i]);
                    
                }

            }

            

            return listaFiltroActividad;

        }

        public List<cliente> BuscarClienteTipo(tipoEmpresa tipo)
        {
            List<cliente> listaFiltroTipo = new List<cliente>();
            
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Tipo.Id.Equals(tipo.Id))
                {
                    listaFiltroTipo.Add(listaClientes[i]);
                   
                }
                
            }
           
            return listaFiltroTipo;

        }
































































































    }
















































































}
   




