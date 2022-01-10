using modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaPrivadaCABA.Modelo
{
    public class PacienteEnEspera :Paciente
    {
        /// <summary>
        /// PacienteEnEspera es una clase hija de Paciente, su finalidad es indicar cuando un paciente 
        /// esta en Lista de espera, pero separandolo de su información personal.
        /// Un paciente puede estar esperando para alguna especialidad  o no , lo cual no hace que deje ser un paciente.
        /// </summary>
        Estado estado;
        Especialidad esp;
        public PacienteEnEspera(Especialidad esp, Estado est, int dni, string nombre, string apellido, ObraSocial obraSoc, DateTime fecha_nac) : base(dni, nombre, apellido, obraSoc, fecha_nac)
        {
            this.estado = est;
            this.esp = esp;
        }
        /*
        public PacienteEnEspera(Especialidad esp, Estado est, Paciente p)
        {
            this.estado = est;
        }*/
        public Especialidad propEspecialidad
        {
            get { return esp; }
            set { esp = value; }
        }
        public Estado propEstado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
    public enum Estado{
        esperando,atendido
    }
}
