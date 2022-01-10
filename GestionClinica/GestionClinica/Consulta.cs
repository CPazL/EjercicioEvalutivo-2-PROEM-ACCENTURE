
using ClinicaPrivadaCABA.Modelo;
using System;

namespace modelo
{
   public class Consulta
    {
        
       private int idConsulta;
       private Medico medico;
       private Paciente paciente;
       private EstadoConsulta estado;
       private string resultado;
      
        /// <summary>
        /// contador de columnas independientes a la clase Consulta
        /// </summary>
       private static int siguienteidConsulta = 0;

        /// <summary>
        /// Sobrecarga de constructor de la clase Consulta
        /// </summary>

        public Consulta( Medico medico, Paciente paciente)
        {
            this.idConsulta = siguienteidConsulta;
            this.medico = medico;
            this.paciente = paciente;
            this.estado = EstadoConsulta.En_espera;
            this.resultado = "";
      
            Consulta.siguienteidConsulta++;

        }
        public Consulta( PacienteEnEspera paciente)
        {
            this.idConsulta = siguienteidConsulta;
            this.medico = null;
            this.paciente = paciente;
            this.estado = EstadoConsulta.En_espera;
            this.resultado = "";
            Consulta.siguienteidConsulta++;

        }
        /// <summary>
        /// Propiedades de los atributos de la clase Consulta.
        /// </summary>
        public Medico propMedico
        {
            get { return medico; }
            set{ medico = value; }
        }
        public Paciente propPaciente
        {
            get{ return paciente; }
            set { paciente = value; }
        }
        public string propResultado
        {
            get{ return resultado; }
            set{ resultado = value; }
        }
        public int propid
        {
            get { return idConsulta; }
          
        }

        /// <summary>
        /// -------------------------------Metodos de la clase----------------------------------
        /// activarConsulta:
        /// </summary>

        public void activarConsulta()
        {
            try
            {
                this.estado = EstadoConsulta.Activa;
            }
            catch 
            {
                throw new NotFoundException("La consulta no está activada");
            }
            
        }
        /// <summary>
        /// Finalizar consulta, termina con la consulta y guarde en la misma como se ha resuelto la misma.
        /// </summary>
        /// <param name="resultado"></param>
        public void finalizarConsulta(String resultado)
        {
            try{
               if (estado == EstadoConsulta.Activa)
                {
                    this.estado = EstadoConsulta.Finalizada;
                    this.resultado = resultado;

                }
            }
            catch
            {
                throw new NotFoundException("La consulta no está activada");
            }
           
        }

     }

    public enum EstadoConsulta
    {
        En_espera, Activa, Finalizada
    }


}
