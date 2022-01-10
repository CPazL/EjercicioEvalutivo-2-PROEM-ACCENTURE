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
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton que regresa al formulario principal
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
        /// Botón que cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.principal.Close();
        }
    }
}
