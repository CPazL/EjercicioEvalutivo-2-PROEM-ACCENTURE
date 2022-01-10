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
    public partial class FormPacientes : Form
    {
        private List<Paciente> pacientes;
        public FormPacientes(List<Paciente> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;
            cargardataGridView();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            nombretextBox.Text = "";
            apellidotextBox.Text = "";
            dnitextBox.Text = "";
            fechaNactextBox.Text = "";
            NoOSradioButton.Checked = false;
            basicaOSradioButton.Checked = false;
            completaOSradioButton.Checked = false;
        }
        private void NoOSradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que crea un nuevo Paciente y lo agrega a la lista de pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearPbutton_Click(object sender, EventArgs e)
        {
            try {
                // int dni, string nombre, string apellido, ObraSocial obraSoc, DateTime fecha_nac)
                ObraSocial obrasocial;
                DateTime fecha = DateTime.Parse(fechaNactextBox.Text);
                int dni = Int32.Parse(dnitextBox.Text);

                if (completaOSradioButton.Checked)
                {
                    obrasocial = ObraSocial.Completa;
                }
                else if (basicaOSradioButton.Checked)
                {
                    obrasocial = ObraSocial.Basica;
                }
                else
                {
                    obrasocial = ObraSocial.NoTiene;
                }

                Paciente p = new Paciente(dni, nombretextBox.Text, apellidotextBox.Text, obrasocial, fecha);
                pacientes.Add(p);
                dataGridView1.Rows.Add(p.propDni, p.propNombre, p.propApellido, p.propFecha_nac.ToString("dd/MM/yyyy"), p.propObrasocial);

                MessageBox.Show("Se ha creado correctamente", "BIEN HECHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("No fue posible crear al nuevo paciente, revise los datos ingresados","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Metodo que carga los datos dentro del DatagridView
        /// </summary>
        private void cargardataGridView()
        {
            foreach (Paciente p in pacientes)
            {
 
                dataGridView1.Rows.Add(p.propDni, p.propNombre, p.propApellido, p.propFecha_nac.ToString("dd/MM/yyyy"), p.propObrasocial);
            }
        }
        /// <summary>
        /// Metodo que busca un Paciente y lo muestra en el dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            foreach (Paciente m in pacientes)
            {
                if (m.propDni.Equals(Int32.Parse(dniBuscartextBox.Text)))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(m.propDni, m.propNombre, m.propApellido, m.propFecha_nac.ToString("dd/MM/yyyy"), m.propObrasocial);
                    encontro = true;
                }

            }
            if (!encontro){
                    MessageBox.Show("No se encuentra registrado el paciente", "LO LAMENTO :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// carga nuevamente la lista en el datagridView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cargardataGridView();
        }
        /// <summary>
        /// Elimina un fila elegida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Paciente m in pacientes)
                {
                    if (m.propDni.Equals(Int32.Parse(dniBuscartextBox.Text)))
                    {
                        pacientes.Remove(m);

                    }
                }
                dataGridView1.Rows.Clear();
                cargardataGridView();
            }
            catch
            {

            }

        }
    }
}
