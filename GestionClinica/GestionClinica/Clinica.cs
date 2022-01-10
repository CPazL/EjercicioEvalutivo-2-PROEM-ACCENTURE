using ClinicaPrivadaCABA.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// Clase clinica : se relacionan las consultas, medicos, pacientes, historial de cada medico e historial de pacientes.
    /// </summary>
    public class Clinica
    {
        ///<summary>
        /// Para recopilar Pacientes, Medicos y Consultas se seleccionó la forma de cola (Queue) para que se puedan tener los datos ordenados
        /// por orden de llegada
        ///</summary>
        private List<Paciente> pacientes;
        private Queue<PacienteEnEspera> todosPacientesEnEspera;
        private List<Medico> medicos;
        private Queue<Consulta> consultas;

        /// <summary>
        /// Constructor de la clase Clinica
        /// </summary>
        /// <param name="pacientesEnEspera"></param>
        /// <param name="medicosDisponibles"></param>
        /// <param name="consultas"></param>
        /// <param name="historialMedico"></param>
        /// <param name="historialPaciente"></param>
        public Clinica()
        {
            this.pacientes = new List<Paciente>();
            this.medicos = new List<Medico>();
            this.todosPacientesEnEspera = new Queue<PacienteEnEspera>();
            this.consultas = new Queue<Consulta>();
            cargaInicialdeDatos();

        }
        /// <summary>
        /// Geters y setters de los atributos
        /// </summary>

        public List<Paciente> propPacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }
        public Queue<PacienteEnEspera> propPacientesEnEsp
        {
            get { return todosPacientesEnEspera; }
            set { todosPacientesEnEspera = value; }
        }
        public List<Medico> propMed {
            get { return medicos; }
            set { medicos = value; }
        }
        public Queue<Consulta> propConsultas {
            get { return consultas; }
            set { consultas = value; }
        }

        /// <summary>
        /// ------------------------------------Metodos de la administración clinica----------------------------------
        ///
        /// -------------------Metodo que realiza una carga inicial de datos previos de consultas, medicos , pacientes y pacientes en espera si corresponde------------------
        /// </summary>
        public void cargaInicialdeDatos()
        {
            Medico m1 = new Medico(Especialidad.Cardiologia, EstadoLaboral.libre, 15502230, "Juan Luis", "Perez", new DateTime(1960, 6, 10));
            Medico m2 = new Medico(Especialidad.Electrocardiograma, EstadoLaboral.libre, 12502230, "Mariana", "Ritz", new DateTime(1962, 11, 1));
            Medico m3= new Medico(Especialidad.Rayos, EstadoLaboral.libre, 25502235, "Clarisa", "Santana", new DateTime(1974, 3, 25));

            Paciente p1 = new Paciente(18605933, "Roberto", "Calvo", ObraSocial.Completa, new DateTime(1974, 10, 25));
            Paciente p2 = new Paciente(18611111, "Maximo", "Cosetti", ObraSocial.Basica, new DateTime(1963, 12, 31));
            Paciente p3 = new Paciente(18605933, "Mario", "Santos", ObraSocial.NoTiene, new DateTime(1979, 05, 3));
            Paciente p4 = new Paciente(19105223, "Sofia", "Vergara", ObraSocial.Completa, new DateTime(1980, 09, 21));
            Paciente p5 = new Paciente(17565623, "Michael", "Peterson", ObraSocial.NoTiene, new DateTime(1980, 6, 15));
            Paciente p6 = new Paciente(21563780, "Miguel", "Santana", ObraSocial.NoTiene, new DateTime(1979, 05, 3));
            Paciente p7 = new Paciente(24005230, "Ambar", "Paz", ObraSocial.Completa, new DateTime(1980, 09, 21));
            Paciente p8 = new Paciente(27800900, "Noe", "Mendez", ObraSocial.Basica, new DateTime(1980, 6, 15));
            pacientes.Add(p1);
            pacientes.Add(p2);
            pacientes.Add(p3);
            pacientes.Add(p4);
            pacientes.Add(p5);
            pacientes.Add(p6);
            pacientes.Add(p7);
            pacientes.Add(p8);

            m1.prophisto.propPacientesAtendidos.Enqueue(p1);
            m1.prophisto.propPacientesAtendidos.Enqueue(p2);
            m2.prophisto.propPacientesAtendidos.Enqueue(p1);
            m2.prophisto.propPacientesAtendidos.Enqueue(p2);
            m2.prophisto.propPacientesAtendidos.Enqueue(p3);
            m2.prophisto.propPacientesAtendidos.Enqueue(p4);
            m3.prophisto.propPacientesAtendidos.Enqueue(p3);
            m3.prophisto.propPacientesAtendidos.Enqueue(p5);
            m3.prophisto.propPacientesAtendidos.Enqueue(p1);
            m3.prophisto.propPacientesAtendidos.Enqueue(p2);

            Consulta c1 = new Consulta(m1, p1);
            m1.propEstadLab = EstadoLaboral.ocupado;

            Consulta c2 = new Consulta(m2, p2);
            m2.propEstadLab = EstadoLaboral.ocupado;

            PacienteEnEspera pe1 = new PacienteEnEspera(Especialidad.Cardiologia,Estado.esperando, 19105223, "Sofia", "Vergara", ObraSocial.Completa, new DateTime(1992, 09, 21));
            m1.prophisto.propPacientesEnEspera.Enqueue(pe1);
            todosPacientesEnEspera.Enqueue(pe1);

            PacienteEnEspera pe2 = new PacienteEnEspera(Especialidad.Electrocardiograma, Estado.esperando, 19105223, "Maria Luisa", "Vera", ObraSocial.Completa, new DateTime(1987, 04, 04));
            m2.prophisto.propPacientesEnEspera.Enqueue(pe2);
            todosPacientesEnEspera.Enqueue(pe2);

            PacienteEnEspera pe3 = new PacienteEnEspera(Especialidad.Rayos, Estado.esperando, 17565623, "Pablo", "Rodriguez", ObraSocial.NoTiene, new DateTime(1999, 6, 15));
            m3.prophisto.propPacientesEnEspera.Enqueue(pe3);
            todosPacientesEnEspera.Enqueue(pe3);

            PacienteEnEspera pe4 = new PacienteEnEspera(Especialidad.Cardiologia, Estado.esperando, 21563780, "Miguel", "Santana", ObraSocial.NoTiene, new DateTime(1979, 05, 3));
            m1.prophisto.propPacientesEnEspera.Enqueue(pe4);
            todosPacientesEnEspera.Enqueue(pe4);

            PacienteEnEspera pe5 = new PacienteEnEspera(Especialidad.Electrocardiograma, Estado.esperando, 24005230, "Ambar", "Paz", ObraSocial.Completa, new DateTime(1989, 09, 21));
            m2.prophisto.propPacientesEnEspera.Enqueue(pe4);
            todosPacientesEnEspera.Enqueue(pe5);

            PacienteEnEspera pe6 = new PacienteEnEspera(Especialidad.Rayos, Estado.esperando, 27800900, "Noe", "Mendez", ObraSocial.Basica, new DateTime(1962, 4, 30));
            m3.prophisto.propPacientesEnEspera.Enqueue(pe4);
            todosPacientesEnEspera.Enqueue(pe6);


            medicos.Add(m1);
            medicos.Add(m2);
            medicos.Add(m3);
            añadirConsulta(c1);
            añadirConsulta(c2);
        }
        ///<summary>
        ///--------------------------------------- Metodos para administrar consultas ----------------------------------------
        /// </sumary>
        public void crearConsulta(Medico m, Paciente p)
        {
            Consulta c;
            try
            {
                if (m.propEstadLab.Equals(EstadoLaboral.ocupado))
                {
                    m.prophisto.propPacientesEnEspera.Enqueue(p);
                    ///Devolver mensaje : quedo en lista de espera.
                }
                else
                {
                    c = new Consulta(m, p);
                    c.activarConsulta();
                    m.propEstadLab = EstadoLaboral.ocupado;
                    m.prophisto.propPacientesAtendidos.Enqueue(p);
                    m.prophisto.propContadorPacientes++;
                    p.PropHisto.Enqueue(c);
                    añadirConsulta(c);
                    //Mostrar en el el table de Consultas y un mensagge de añadida con exito
                }
            }
            catch
            {
                throw new NotFoundException("La consulta no pudo ser creada.");
            }
        }
        /// <summary>
        /// Se añade la consulta a la lista de consultas
        /// 
        /// </summary>
        /// <param name="c"></param>
        public void añadirConsulta(Consulta c)
        {
            try
            {
                consultas.Enqueue(c);
            }
            catch
            {
                throw new NotFoundException("La consulta {0} no pudo ser añadida.", c.propid.ToString());
            }
        }
        public bool buscarConsulta(int id)
        {
            try
            {

                foreach (Consulta c in (consultas))
                {
                    if (c.propid == id)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
        }
        /// <summary>
        /// Se puede eliminar consultas luego de finalizadas
        /// bOTON en Windows FORM: Finalizar consultas
        /// </summary>
        public void finalizarConsulta(Consulta c, String resultado)
        {
            if (buscarConsulta(c.propid) )
            {
                c.finalizarConsulta(resultado);
                 guardarConsultaenHistorialdePaciente(c.propid, c);
            }
        }
        
        public void crearPaciente(int dni, string nombre, string apellido, int edad, ObraSocial obraSoc, DateTime fecha_nac)
        {
            Paciente p = null;
            try
            {
                p = new Paciente(dni, nombre, apellido, obraSoc, fecha_nac);
                pacientes.Add(p);
            }
            catch
            {
                throw new NotFoundException("Error en la carga de datos del paciente");
            }
         }

        /// <summary>
        /// Este método sirve para buscar por el dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool buscarPaciente(int dni)
        {
            try { 

                foreach ( Paciente p in (pacientes))
                {
                        if (p.propDni.Equals(dni)){
                    return true;
                        }
                }      
                return false;
            }
            catch 
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
        }
        public void guardarConsultaenHistorialdePaciente(int dni, Consulta c)
        {
            try
            {
                foreach (Paciente p in (pacientes))
                {
                    if (p.propDni.Equals(dni))
                    {
                        p.PropHisto.Enqueue(c);
                    }
                }
            }
            catch
            {
                throw new NotFoundException("Error en la inserción de la consulta al historial");
            }
        }
        public void crearPacienteEnEspera(Especialidad esp, int dni, string nombre, string apellido, int edad, ObraSocial obraSoc, DateTime fecha_nac)
        {
            PacienteEnEspera plEsp = null;
            ///<summary>
            /// Si el paciente no esta registrado en el sistema, se llama a la función crearPaciente() y posteriormente 
            /// se lo crea como Paciente en espera para luego añadirlo a la COLA de espera
            /// Caso contrario, solo se lo crea como Paciente en espera y se lo incorpora a la cola en espera
            /// </summary>
            try
            {
                if (!buscarPaciente(dni))
                {
                    crearPaciente(dni, nombre, apellido, edad, obraSoc, fecha_nac);
                }
                plEsp = new PacienteEnEspera(esp, Estado.esperando, dni, nombre, apellido, obraSoc, fecha_nac);
                todosPacientesEnEspera.Enqueue(plEsp);
            } catch
            {
                throw new NotFoundException("Error en la asignición del paciente a la lista en Espera");
            }
         }
        public bool buscarPacientesEnEspera(int dni)
        {
                try
                {

                    foreach (PacienteEnEspera p in (todosPacientesEnEspera))
                    {
                        if (p.propDni.Equals(dni))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch
                {
                    throw new NotFoundException("Error en la busqueda del paciente en la lista de espera");
                }
            }
        
        /// <summary>
        /// -----------------------Metodos para administar médicos---------------------------------------------
        /// Crear - Buscar en base al dni - Borrar e base al dni un médico
        /// </summary>
        public bool crearMedico(Especialidad espe, EstadoLaboral estadolab, int dni, string nombre, string apellido, DateTime fecha_nac)
        {
            Medico m = null;
            try
            {
                if (buscarMedico(dni))
                {
                    return false;
                }

                    m = new Medico(espe, estadolab, dni, nombre, apellido, fecha_nac);
            }
            catch
            {
                throw new NotFoundException("Error en la creación de un nuevo médico");
            }
            return true;
        }
        private bool buscarMedico(int dni)
        {
            try
            {

                foreach (Medico med in (medicos))
                {
                    if (med.propDni.Equals(dni))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
            return false;
        }
        public void eliminarMedico( Medico m)
        {
            try
            {
                if (buscarMedico(m.propDni))
                {
                    medicos.Remove(m);
                }
                
            }
            catch
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
        }

     
    }
}
