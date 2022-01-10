using modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaPrivadaCABA.Modelo
{
    public class HistorialdelMedico
    {
        private Queue<Paciente> pacientesAtendidos;
        private Queue<Paciente> pacientesEnEspera;
        private  int contadorPacientes;

        public HistorialdelMedico(Queue<Paciente> pacientesAtendidos, Queue<Paciente> enEspera, int cont)
        {
            this.pacientesAtendidos = pacientesAtendidos;
            this.pacientesEnEspera = enEspera;
            this.contadorPacientes = contarpacientes();
        }
        public HistorialdelMedico()
        {
            this.pacientesAtendidos = new Queue<Paciente>();
            this.pacientesEnEspera = new Queue<Paciente>();
            this.contadorPacientes = 0;
        }
        public Queue<Paciente> propPacientesAtendidos { get => pacientesAtendidos; set => pacientesAtendidos = value; }
        public Queue<Paciente> propPacientesEnEspera { get => pacientesEnEspera; set => pacientesEnEspera = value; }
        public int propContadorPacientes { get => contadorPacientes;


            set { contadorPacientes= contarpacientes();
                contadorPacientes = value; } 
        }
        public int contarpacientes()
        {
            int cont = this.propPacientesAtendidos.Count;
            return cont;
        }
    }
}
