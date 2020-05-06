using modelo.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelo.colecciones
{
    public class contratoCollection
    {
        private List<contrato> listaContratos;

        public contratoCollection()
        {
            listaContratos = new List<contrato>();
        }

        public contratoCollection(List<contrato> listaContratos)
        {
            this.ListaContratos = listaContratos;
        }

        public List<contrato> ListaContratos { get => listaContratos; set => listaContratos = value; }

        public void RegistrarContrato(contrato contrato)
        {
            bool validador = false;

            foreach (contrato c in listaContratos)
            {
                if (c.NumeroContrato.Equals(contrato.NumeroContrato))
                {
                    validador = true;
                }
            }

            if (validador)
            {
                throw new Exception("CONTRATO YA SE ENCUENTRA REGISTRADO");
            }
            else
            {
                listaContratos.Add(contrato);

            }

        }

        public List<contrato> BuscarContratoRutLista(string rut)
        {

            List<contrato> contratos = new List<contrato>();

            int indice = -1;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].Cliente.Rut.Equals(rut))
                {
                    indice = i;
                    contratos.Add(listaContratos[indice]);
                }
            }

            if (indice == -1)
            {
                throw new Exception("NO SE HA ENCONTRADO CONTRATO EN SISTEMA");
            }

            return contratos;

        }

        public contrato BuscarContratonumero(string numero)
        {

            contrato contrato = new contrato();

            int indice = -1;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].NumeroContrato.Equals(numero))
                { indice = i; }
            }

            if (indice == -1)
            {
                throw new Exception("NO SE HA ENCONTRADO CONTRATO EN SISTEMA");
            }
            else
            {
                contrato = listaContratos[indice];

            }

            return contrato;

        }

        public List<contrato> BuscarContratoTipo(tipoEvento tipo)
        {
            List<contrato> listaFiltroTipo = new List<contrato>();

            contrato contrato = new contrato();

            int indice = -1;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].Evento.Id.Equals(tipo.Id))
                {
                    indice = i;
                    listaFiltroTipo.Add(listaContratos[i]);
                }
            }

            return listaFiltroTipo;

        }

        public void GuardarModifContrato(contrato contrato)
        {
            int indice = -1;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].NumeroContrato == (contrato.NumeroContrato))
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
                listaContratos[indice].NumeroContrato = contrato.NumeroContrato;
                listaContratos[indice].CreacionContrato =contrato.CreacionContrato;
                listaContratos[indice].TerminoContrato = contrato.TerminoContrato;
                listaContratos[indice].FechaHorarioInicio = contrato.FechaHorarioInicio;
                listaContratos[indice].FechaHorarioTermino = contrato.FechaHorarioTermino;
                listaContratos[indice].Asistentes = contrato.Asistentes;
                listaContratos[indice].PersonalAdicional = contrato.PersonalAdicional;
                listaContratos[indice].Vigencia= contrato.Vigencia;
                listaContratos[indice].ValorContrato = contrato.ValorContrato;
                listaContratos[indice].Observaciones = contrato.Observaciones;
                listaContratos[indice].Cliente = contrato.Cliente;
                listaContratos[indice].Evento = contrato.Evento;


            }


        }

        public void GuardarConfirmContrato(contrato contrato)
        {
            int indice = -1;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].NumeroContrato == (contrato.NumeroContrato))
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
                listaContratos[indice].NumeroContrato = contrato.NumeroContrato;
                listaContratos[indice].CreacionContrato = contrato.CreacionContrato;
                listaContratos[indice].TerminoContrato = contrato.TerminoContrato;
                listaContratos[indice].FechaHorarioInicio = contrato.FechaHorarioInicio;
                listaContratos[indice].FechaHorarioTermino = contrato.FechaHorarioTermino;
                listaContratos[indice].Asistentes = contrato.Asistentes;
                listaContratos[indice].PersonalAdicional = contrato.PersonalAdicional;
                listaContratos[indice].Vigencia = contrato.Vigencia;
                listaContratos[indice].ValorContrato = contrato.ValorContrato;
                listaContratos[indice].Observaciones = contrato.Observaciones;
                listaContratos[indice].Cliente = contrato.Cliente;
                listaContratos[indice].Evento = contrato.Evento;


            }


        }


    }













}

