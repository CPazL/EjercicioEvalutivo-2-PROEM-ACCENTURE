using ClinicaPrivadaCABA.Modelo;
using System;
using System.Collections.Generic;

namespace modelo
{
    /// <summary>
    /// Paciente es una clase que deriva de Persona 
    /// </summary>
    public class Paciente: Persona
    {
        private ObraSocial obraSoc;
        private Queue<Consulta> historial;

        /// <summary>
        /// Sobre carga de constructor de la clase Paciente
        /// </summary>
        /// <param name="obraSoc"> Obra Social</param>
        public Paciente(int dni, string nombre, string apellido, ObraSocial obraSoc, DateTime fecha_nac) : base(dni, nombre, apellido, fecha_nac)
        {
            this.obraSoc = obraSoc;
            this.historial = new Queue<Consulta>();
        }

        public Paciente(int dni, string nombre, string apellido) : base(dni, nombre, apellido)
        {
            this.obraSoc = ObraSocial.NoTiene;
            this.historial = new Queue<Consulta>();
        }

        public Paciente()
        {
        }

        /// <summary>
        /// Proppiedades del atributo obraSoc
        /// </summary>
        public ObraSocial propObrasocial
        {
            get{  return obraSoc;}
            set{ obraSoc = value; }
        }
        public Queue<Consulta> PropHisto
        {
            get { return historial; }
            set { historial = value; }
        }
    }


    /// <summary>
    /// Enumeración del tipo de servicio que tiene cubierto el usuario dependiendo de si tiene o no Obra Social
    /// </summary>
    public enum ObraSocial
    {
        NoTiene, Basica, Completa
    }


}
