using gestion;
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
    public partial class FormMedicos : Form
    {
        private List<Medico> medicos;
        public FormMedicos(List<Medico> medicos)
        {
            InitializeComponent();
            this.medicos = medicos;
            inicializarComboxEspecialidad();
            cargardataGridView();
        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {
        }
        private void volverbutton_Click(object sender, EventArgs e)
        {

            this.Dispose();
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.ShowDialog();
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataGridViewRow dr = dataGridView1.CurrentRow;



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dniBuscartextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Convierte el textbox recibido de dni 
        /// </summary>
        /// <returns></returns>

        //----------------------------------------------------------------------------------------
        /// <summary>
        /// Limpia los elementos del primer panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            nombretextBox.Text = "";
            apellidotextBox.Text = "";
            dnitextBox.Text = "";
            fechaNactextBox.Text = "";
            comboBoxEspecialidad.SelectedIndex = -1;

        }
        /// <summary>
        /// Crea un nuevo médico luego de que el usuario presione el boton crearPbutton_Click()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearPbutton_Click(object sender, EventArgs e)
        {

            try { 
                int dni = Int32.Parse(dnitextBox.Text);
                Especialidad espe = convertComboxEspecialidad();
                DateTime fecha = DateTime.ParseExact(fechaNactextBox.Text, "dd/MM/yyyy", null);

                Medico m = new Medico (espe,EstadoLaboral.libre,dni, nombretextBox.Text, apellidotextBox.Text, fecha);
                medicos.Add(m);
                dataGridView1.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propEsp.ToString());

               MessageBox.Show("Se ha creado correctamente", "BIEN HECHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                nombretextBox.Text = "";
                apellidotextBox.Text = "";
                dnitextBox.Text = "";
                fechaNactextBox.Text = "";
                comboBoxEspecialidad.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible crear al nuevo paciente, revise los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                   
                    return (Especialidad)Enum.Parse(typeof(Especialidad),i.ToString());
                }
              }
            return Especialidad.sin_especificar;

        }
        /// <summary>
        /// /Inicializa el combo Box de especialidad
        /// </summary>
        private void inicializarComboxEspecialidad()
        {
            foreach (var i in Enum.GetValues(typeof(Especialidad)))
            {
                comboBoxEspecialidad.Items.Add(i.ToString());
            }
        }
        /// <summary>
        ///   Se carga los datos en el DATAGRIDVIEW
        /// </summary>
        private void cargardataGridView()
        {
            foreach (Medico m in medicos)
            {
                dataGridView1.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propEsp.ToString());
            }
        }
        /// <summary>
        ///   Botón para eliminar filas del dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Medico m in medicos)
                {
                    if (m.propDni.Equals(Int32.Parse(dniBuscartextBox.Text)))
                    {
                        medicos.Remove(m);

                    }
                }
                dataGridView1.Rows.Clear();
                cargardataGridView();
            }
            catch
            {

            }
        }
        /// <summary>
        /// Botón buscar a un médico por medio del DNI ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            try {
                foreach (Medico m in medicos)
                {
                    if (m.propDni.Equals(Int32.Parse(dniBuscartextBox.Text))) {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propEsp.ToString());
                        encontro = true;
                    }
                }
                if (!encontro)
                {
                    MessageBox.Show("No se encuentra registrado el paciente", "LO LAMENTO :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                throw new NotFoundException("Error! algo salio mal");
            }
            }
        private void comboBoxhisto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Invoca a el formulario Estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void estadisticasbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            FormEstadisticas prin = new FormEstadisticas();
            prin.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Actualiza la lista modificada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actualizarbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cargardataGridView();
        }

        private void buscarlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
