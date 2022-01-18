
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using gestion;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vista;

namespace VistaClinicaCABA
{
    public partial class FormConsultas : Form
    {
        private Queue<Consulta> consultas;
        private Queue<PacienteEnEspera> pacienteEnEsperas;
        private List<Medico> medicos;
        public FormConsultas(Queue<Consulta> consultas, Queue<PacienteEnEspera> pe, List<Medico> m)
        {
            InitializeComponent();
            this.consultas = consultas;
            this.pacienteEnEsperas = pe;
            this.medicos = m;
            cargardataGridView();
            cargarComboxEspecialidad();
            inicializarComboBoxid();
            cargarComboBoxListaEspera();
        }
        /// <summary>
        /// regresa a el formulario principal y cierra el formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volverbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.ShowDialog();
        }
        /// <summary>
        /// Limpia los controles de para dar de alta a un paciente en lista de espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            comboBoxPacientes.SelectedIndex = -1;
            comboBoxmedicos.SelectedIndex = -1;
            comboBoxEspec.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Close();
        }
        /// <summary>
        /// cargar el dataGridView con la lista de consultas presente-
        /// </summary>
        private void cargardataGridView()
        {
            String paciente;
            String medico;
            try
            {
                foreach (Consulta c in consultas)
                {
                    paciente = c.propPaciente.propNombre + " " + c.propPaciente.propApellido;
                    medico = c.propPaciente.propNombre + " " + c.propMedico.propApellido;
                    dataGridView2.Rows.Add(c.propid, paciente, medico);
                }
            }
            catch
            {
                throw new NotFoundException("Error en la carga de datos");
             }
        }

        /// <summary>
        /// carga los nombres y apellidos de pacientes en lista de espera
        /// </summary>
        private void cargarComboxEspecialidad()
        {
            try { 
              foreach (var i in Enum.GetValues(typeof(Especialidad)))
                {
                comboBoxEspec.Items.Add(i.ToString());
                }
            }
            catch
            {
                throw new NotFoundException("Error en la carga de datos");
    }
}
        /// <summary>
        /// Carga el conbox con la lista de espera para crear una nueva consulta
        /// </summary>
        private void cargarComboBoxListaEspera()
        {
            string nomApe;

            try
            {
                for (int x = 0; x < comboBoxEspec.Items.Count - 1; x++)
                {
                    foreach (PacienteEnEspera pe in pacienteEnEsperas)
                    {
                        nomApe = pe.propNombre + " " + pe.propApellido;
                        comboBoxPacientes.Items.Add(nomApe);
                    }

                }
            }
            catch
            {
                throw new NotFoundException("Error en la carga de datos");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxEspec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pacientes_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBoxmedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crearMbutton_Click(object sender, EventArgs e)
        {
            string[] nomApe;
            string nombre;
            string apellido;
            Medico m = new Medico();
            Paciente p = new Paciente();
            try
            {
                nomApe = comboBoxmedicos.Text.ToString().Split(' ');
                nombre = nomApe[0];
                apellido = nomApe[1];
                m = buscarMedico(nombre, apellido);

                nomApe = comboBoxPacientes.Text.ToString().Split(" ");
                nombre = nomApe[0];
                apellido = nomApe[1];
                p = buscarPaciente(nombre, apellido);
                Consulta c = new Consulta(m, p);
                dataGridView2.Rows.Add(c.propid, comboBoxmedicos.Text.ToString(), comboBoxPacientes.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible crear al nuevo paciente, revise los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Busca el item medico que coincida con el nombre y apellido ingresado como parametro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        private Medico buscarMedico(string nombre, string apellido)
        {
            try
            {

                foreach (Medico med in (medicos))
                {
                    if (med.propNombre.Equals(nombre) && med.propApellido.Equals(apellido))
                    {
                        return med;
                    }
                }
            }
            catch
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
            return null;
        }
        public Paciente buscarPaciente(string nombre, string apellido)
        {
            try
            {

                foreach (Paciente p in pacienteEnEsperas)
                {
                    if (p.propNombre.Equals(nombre) && p.propApellido.Equals(apellido))
                    {
                        return p;
                    }
                }
                return null;
            }
            catch
            {
                throw new NotFoundException("Error en la busqueda del paciente");
            }
        }

        private void finalizarbutton_Click(object sender, EventArgs e)
        {

            int idconsulta = Int32.Parse(idcomboBox.Text.ToString());
            string resultados = resultTextBox.Text.ToString();

            foreach (Consulta c in consultas)
            {
                if (idconsulta == c.propid)
                {
                    c.propMedico.prophisto.propPacientesAtendidos.Enqueue(c.propPaciente);
                    c.finalizarConsulta(resultados);


                }
            }


        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void idcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void comboBoxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void inicializarComboBoxid()
        {
            foreach (Consulta c in consultas)
            {
                idcomboBox.Items.Add(c.propid.ToString());
            }

        }
    }
    
}
