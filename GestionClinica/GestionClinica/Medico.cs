using ClinicaPrivadaCABA.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// Medico deriva de la clase persona
    /// </summary>
    public class Medico: Persona
    {
        private Especialidad especialidad;
        private EstadoLaboral estadolab;
        private HistorialdelMedico histo;

        /// <summary>
        /// Sobrecarga del construtor de Medico
        /// </summary>
        public Medico()
        {
        }
        public Medico(Especialidad espe, EstadoLaboral estadolab, int dni, string nombre, string apellido, DateTime fecha_nac) : base(dni, nombre, apellido, fecha_nac)
        {
            this.especialidad = espe;
            this.estadolab = estadolab;
            this.histo = new HistorialdelMedico();
        }



        /// <summary>
        /// Propiedades de los atributos especialidad y estadlolab
        /// </summary>
        public Especialidad propEsp
        {
            get { return especialidad; } 
            set { especialidad = value; }
        }
        public EstadoLaboral propEstadLab
        {
            get { return estadolab; }
            set {  estadolab = value;}
        }
        public HistorialdelMedico prophisto
        {
            get { return histo; }
            set { histo = value; }
        }

    }
    /// <summary>
    /// Enumeración de los posibles estados laboral actual del medico
    /// </summary>
    public enum EstadoLaboral
    {
        ocupado,libre
    }

}
