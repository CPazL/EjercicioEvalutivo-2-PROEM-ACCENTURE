using ClinicaPrivadaCABA.Modelo;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vista;

namespace VistaClinicaCABA
{
    public partial class FormListEsp : Form
    {
        private Queue<PacienteEnEspera> pacientesEspera;
        private List<Paciente> pacientes;
        public FormListEsp(Queue<PacienteEnEspera> pacientesEspera, List<Paciente> pacientes)
        {
            this.pacientesEspera = pacientesEspera;
            this.pacientes = pacientes;
            InitializeComponent();
            cargardataGridView();
            inicializarComboxEspecialidad();
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Close();
        }

        private void volverbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargardataGridView()
        {
            foreach (PacienteEnEspera p in pacientesEspera)
            {
                dataGridView2.Rows.Add(p.propDni, p.propNombre, p.propApellido, p.propFecha_nac.ToString("dd/MM/yyyy"), p.propEspecialidad);
            }
        }

        private void comboBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void inicializarComboxEspecialidad()
        {
            foreach (var i in Enum.GetValues(typeof(Especialidad)))
            {
                comboBoxEspecialidad.Items.Add(i.ToString());
            }
        }
        /// <summary>
        /// Agrega al paciente a lista de espera y si no exixte como paciente lo crea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearMbutton_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(dnitextBox.Text.ToString());
            Especialidad espe = convertComboxEspecialidad();
            DateTime fecha = DateTime.ParseExact(fechatextBox.Text, "dd/MM/yyyy", null);

            PacienteEnEspera m = new PacienteEnEspera(espe, Estado.esperando, dni, nombretextBox.Text, apellidotextBox.Text,ObraSocial.Basica, fecha);
            pacientesEspera.Enqueue(m);
            Paciente p = new Paciente(dni, nombretextBox.Text, apellidotextBox.Text, ObraSocial.Basica, fecha);
            pacientes.Add(p);
            dataGridView2.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propEspecialidad.ToString());

            MessageBox.Show("Se ha creado correctamente", "BIEN HECHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dnitextBox.Text = "";
            nombretextBox.Text = "";
            apellidotextBox.Text = "";
            fechatextBox.Text = "";
            comboBoxEspecialidad.Text = "";
        }
        /// <summary>
        /// Convierte el texto recibido en de un comboBox, y lo convierte en un elemento del Enum Especialidad
        /// </summary>
        /// <returns></returns>
        private Especialidad convertComboxEspecialidad()
        {
            string auxEspec = comboBoxEspecialidad.Text;

            foreach (var i in Enum.GetValues(typeof(Especialidad)))
            {
                if (i.ToString().Equals(auxEspec))
                {

                    return (Especialidad)Enum.Parse(typeof(Especialidad), i.ToString());
                }
            }
            return Especialidad.sin_especificar;

        }

        /// <summary>
        /// Limpia los botones del primer panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            dnitextBox.Text = "";
            nombretextBox.Text = "";
            apellidotextBox.Text = "";
            fechatextBox.Text = "";
            comboBoxEspecialidad.Text = "";

        }
        /// <summary>
        /// luego de se apretado el botón buscar, este método procede a buscar al usuario acorde al dni ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            try {
                foreach (PacienteEnEspera m in pacientesEspera)
                {
                    if (m.propDni.Equals(Int32.Parse(dniBuscartextBox.Text.ToString())))
                    {
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propObrasocial);
                        encontro = true;
                    }
                }
                if (!encontro)
                {
                    MessageBox.Show("No se ha encuentrado registrado al paciente", "LO LAMENTO :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                throw new NotFoundException("Hubo un error :( ");
            }
        }

        private void cargarbutton_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.Rows.Clear();
                cargardataGridView();

            }
            catch
            {
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
