using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.clases
{
    public class contrato
    {
        private string numeroContrato;
        private string creacionContrato;
        private DateTime terminoContrato;
        private DateTime fechaHorarioInicio;
        private DateTime fechaHorarioTermino;
        private int asistentes;
        private int personalAdicional;
        private bool vigencia;
        private double valorContrato;
        private string observaciones;
        private cliente cliente;
        private tipoEvento evento;

        public contrato()
        {

        }

        public contrato(string numeroContrato, string creacionContrato, DateTime terminoContrato, DateTime fechaHorarioInicio, DateTime fechaHorarioTermino, int asistentes, int personalAdicional, bool vigencia, double valorContrato, string observaciones, cliente cliente, tipoEvento evento)
        {
            this.NumeroContrato = numeroContrato;
            this.CreacionContrato = creacionContrato;
            this.TerminoContrato = terminoContrato;
            this.FechaHorarioInicio = fechaHorarioInicio;
            this.FechaHorarioTermino = fechaHorarioTermino;
            this.Asistentes = asistentes;
            this.PersonalAdicional = personalAdicional;
            this.Vigencia = vigencia;
            this.ValorContrato = valorContrato;
            this.Observaciones = observaciones;
            this.Cliente = cliente;
            this.Evento = evento;
        }

        public string NumeroContrato { get => numeroContrato; set => numeroContrato = value; }
        public string CreacionContrato { get => creacionContrato; set => creacionContrato = value; }
        public DateTime TerminoContrato { get => terminoContrato; set => terminoContrato = value; }
        public DateTime FechaHorarioInicio { get => fechaHorarioInicio; set => fechaHorarioInicio = value; }
        public DateTime FechaHorarioTermino { get => fechaHorarioTermino; set => fechaHorarioTermino = value; }
        public int Asistentes { get => asistentes; set => asistentes = value; }
        public int PersonalAdicional { get => personalAdicional; set => personalAdicional = value; }
        public bool Vigencia { get => vigencia; set => vigencia = value; }
        public double ValorContrato { get => valorContrato; set => valorContrato = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public cliente Cliente { get => cliente; set => cliente = value; }
        public tipoEvento Evento { get => evento; set => evento = value; }
    }
}
