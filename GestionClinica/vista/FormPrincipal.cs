using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vista;

namespace VistaClinicaCABA
{
    public partial class FormPrincipal : Form
    {
        private Clinica clinica;
        private FormConsultas consultas;
        private FormMedicos medicos;
        private FormListEsp pacientesEspera;
        private FormPacientes pacientes;
        public FormPrincipal()
        {
            InitializeComponent();
            clinica = new Clinica();
            consultas = new FormConsultas(clinica.propConsultas, clinica.propPacientesEnEsp, clinica.propMed);
            medicos = new FormMedicos(clinica.propMed);
            pacientesEspera = new FormListEsp(clinica.propPacientesEnEsp, clinica.propPacientes);
            pacientes = new FormPacientes(clinica.propPacientes);

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            clinica.cargaInicialdeDatos();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            vista.Program.principal.Hide();
            pacientes.Show();
        }
        private void medicosbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Hide();
            medicos.Show();
        }
        private void consultaslabel_Click(object sender, EventArgs e)
        {
            Program.principal.Hide();
            
            consultas.Show();
        }
        private void listaesperabutton_Click_1(object sender, EventArgs e)
        {
            Program.principal.Hide();
            pacientesEspera.Show();
        }
        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Close();
        }
        private void consultasbutton_Click_1(object sender, EventArgs e)
        {
            Program.principal.Hide();

            consultas.Show();
        }

        ///<summary>
        ///
        /// </summary>

        private void ActualizarFormularios()
        {
            consultas= new FormConsultas(clinica.propConsultas, clinica.propPacientesEnEsp, clinica.propMed);
            medicos = new FormMedicos(clinica.propMed);
            pacientes = new FormPacientes(clinica.propPacientes);
            pacientesEspera = new FormListEsp(clinica.propPacientesEnEsp, clinica.propPacientes);

        }
    }
}
