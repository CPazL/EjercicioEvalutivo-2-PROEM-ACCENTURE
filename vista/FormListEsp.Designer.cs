
using System;
using System.Windows.Forms;

namespace VistaClinicaCABA
{
    partial class FormListEsp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListEsp));
            this.salirbutton = new System.Windows.Forms.Button();
            this.volverbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cargarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dniBuscartextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buscarlabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.columndni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEspe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gestionlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.esplabel = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.crearMbutton = new System.Windows.Forms.Button();
            this.completaOSradioButton = new System.Windows.Forms.RadioButton();
            this.fechanaclabel = new System.Windows.Forms.Label();
            this.fechatextBox = new System.Windows.Forms.TextBox();
            this.obrasociallabel = new System.Windows.Forms.Label();
            this.basicaOSradioButton = new System.Windows.Forms.RadioButton();
            this.NoOSradioButton = new System.Windows.Forms.RadioButton();
            this.dnilabel = new System.Windows.Forms.Label();
            this.apellidolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidotextBox = new System.Windows.Forms.TextBox();
            this.dnitextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirbutton
            // 
            this.salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salirbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirbutton.Location = new System.Drawing.Point(540, 713);
            this.salirbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(241, 32);
            this.salirbutton.TabIndex = 5;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = false;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // volverbutton
            // 
            this.volverbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.volverbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volverbutton.Location = new System.Drawing.Point(141, 713);
            this.volverbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volverbutton.Name = "volverbutton";
            this.volverbutton.Size = new System.Drawing.Size(241, 32);
            this.volverbutton.TabIndex = 7;
            this.volverbutton.Text = "VOLVER";
            this.volverbutton.UseVisualStyleBackColor = false;
            this.volverbutton.Click += new System.EventHandler(this.volverbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cargarbutton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dniBuscartextBox);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buscarlabel);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 323);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cargarbutton
            // 
            this.cargarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargarbutton.BackgroundImage")));
            this.cargarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cargarbutton.FlatAppearance.BorderSize = 0;
            this.cargarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarbutton.Location = new System.Drawing.Point(744, 177);
            this.cargarbutton.Name = "cargarbutton";
            this.cargarbutton.Size = new System.Drawing.Size(70, 53);
            this.cargarbutton.TabIndex = 32;
            this.cargarbutton.UseVisualStyleBackColor = true;
            this.cargarbutton.Click += new System.EventHandler(this.cargarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(734, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "DNI";
            // 
            // dniBuscartextBox
            // 
            this.dniBuscartextBox.Location = new System.Drawing.Point(739, 144);
            this.dniBuscartextBox.Name = "dniBuscartextBox";
            this.dniBuscartextBox.Size = new System.Drawing.Size(158, 27);
            this.dniBuscartextBox.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(827, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 79);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscarlabel
            // 
            this.buscarlabel.AutoSize = true;
            this.buscarlabel.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarlabel.Location = new System.Drawing.Point(734, 82);
            this.buscarlabel.Name = "buscarlabel";
            this.buscarlabel.Size = new System.Drawing.Size(80, 24);
            this.buscarlabel.TabIndex = 26;
            this.buscarlabel.Text = "BUSCAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columndni,
            this.columnnombre,
            this.columnapellido,
            this.columnFechaNac,
            this.columnEspe});
            this.dataGridView2.Location = new System.Drawing.Point(40, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(677, 250);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // columndni
            // 
            this.columndni.HeaderText = "DNI";
            this.columndni.MinimumWidth = 6;
            this.columndni.Name = "columndni";
            this.columndni.Width = 125;
            // 
            // columnnombre
            // 
            this.columnnombre.HeaderText = "Nombre";
            this.columnnombre.MinimumWidth = 6;
            this.columnnombre.Name = "columnnombre";
            this.columnnombre.Width = 125;
            // 
            // columnapellido
            // 
            this.columnapellido.HeaderText = "Apellido";
            this.columnapellido.MinimumWidth = 6;
            this.columnapellido.Name = "columnapellido";
            this.columnapellido.Width = 125;
            // 
            // columnFechaNac
            // 
            this.columnFechaNac.HeaderText = "Fecha de Nac.:";
            this.columnFechaNac.MinimumWidth = 6;
            this.columnFechaNac.Name = "columnFechaNac";
            this.columnFechaNac.Width = 125;
            // 
            // columnEspe
            // 
            this.columnEspe.HeaderText = "Especialidad";
            this.columnEspe.MinimumWidth = 6;
            this.columnEspe.Name = "columnEspe";
            this.columnEspe.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE PACIENTES EN ESPERA";
            // 
            // gestionlabel
            // 
            this.gestionlabel.AutoSize = true;
            this.gestionlabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestionlabel.Location = new System.Drawing.Point(263, 24);
            this.gestionlabel.Name = "gestionlabel";
            this.gestionlabel.Size = new System.Drawing.Size(380, 32);
            this.gestionlabel.TabIndex = 11;
            this.gestionlabel.Text = "PACIENTES EN LISTA DE ESPERA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.esplabel);
            this.panel1.Controls.Add(this.comboBoxEspecialidad);
            this.panel1.Controls.Add(this.limpiarbutton);
            this.panel1.Controls.Add(this.crearMbutton);
            this.panel1.Controls.Add(this.completaOSradioButton);
            this.panel1.Controls.Add(this.fechanaclabel);
            this.panel1.Controls.Add(this.fechatextBox);
            this.panel1.Controls.Add(this.obrasociallabel);
            this.panel1.Controls.Add(this.basicaOSradioButton);
            this.panel1.Controls.Add(this.NoOSradioButton);
            this.panel1.Controls.Add(this.dnilabel);
            this.panel1.Controls.Add(this.apellidolabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.apellidotextBox);
            this.panel1.Controls.Add(this.dnitextBox);
            this.panel1.Controls.Add(this.nombretextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 259);
            this.panel1.TabIndex = 10;
            // 
            // esplabel
            // 
            this.esplabel.AutoSize = true;
            this.esplabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esplabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.esplabel.Location = new System.Drawing.Point(70, 207);
            this.esplabel.Name = "esplabel";
            this.esplabel.Size = new System.Drawing.Size(109, 20);
            this.esplabel.TabIndex = 22;
            this.esplabel.Text = "ESPECIALIDAD";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(195, 204);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(410, 28);
            this.comboBoxEspecialidad.TabIndex = 21;
            this.comboBoxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecialidad_SelectedIndexChanged);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpiarbutton.BackgroundImage")));
            this.limpiarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiarbutton.FlatAppearance.BorderSize = 0;
            this.limpiarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarbutton.Location = new System.Drawing.Point(778, 149);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(70, 53);
            this.limpiarbutton.TabIndex = 20;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // crearMbutton
            // 
            this.crearMbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crearMbutton.BackgroundImage")));
            this.crearMbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crearMbutton.FlatAppearance.BorderSize = 0;
            this.crearMbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearMbutton.Location = new System.Drawing.Point(778, 73);
            this.crearMbutton.Name = "crearMbutton";
            this.crearMbutton.Size = new System.Drawing.Size(70, 53);
            this.crearMbutton.TabIndex = 19;
            this.crearMbutton.UseVisualStyleBackColor = true;
            this.crearMbutton.Click += new System.EventHandler(this.crearMbutton_Click);
            // 
            // completaOSradioButton
            // 
            this.completaOSradioButton.AutoSize = true;
            this.completaOSradioButton.Location = new System.Drawing.Point(377, 156);
            this.completaOSradioButton.Name = "completaOSradioButton";
            this.completaOSradioButton.Size = new System.Drawing.Size(95, 24);
            this.completaOSradioButton.TabIndex = 16;
            this.completaOSradioButton.TabStop = true;
            this.completaOSradioButton.Text = "Completa";
            this.completaOSradioButton.UseVisualStyleBackColor = true;
            // 
            // fechanaclabel
            // 
            this.fechanaclabel.AutoSize = true;
            this.fechanaclabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechanaclabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fechanaclabel.Location = new System.Drawing.Point(375, 110);
            this.fechanaclabel.Name = "fechanaclabel";
            this.fechanaclabel.Size = new System.Drawing.Size(125, 20);
            this.fechanaclabel.TabIndex = 15;
            this.fechanaclabel.Text = "FECHA DE NAC.:";
            // 
            // fechatextBox
            // 
            this.fechatextBox.Location = new System.Drawing.Point(505, 107);
            this.fechatextBox.Name = "fechatextBox";
            this.fechatextBox.Size = new System.Drawing.Size(133, 27);
            this.fechatextBox.TabIndex = 14;
            // 
            // obrasociallabel
            // 
            this.obrasociallabel.AutoSize = true;
            this.obrasociallabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrasociallabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.obrasociallabel.Location = new System.Drawing.Point(70, 156);
            this.obrasociallabel.Name = "obrasociallabel";
            this.obrasociallabel.Size = new System.Drawing.Size(102, 20);
            this.obrasociallabel.TabIndex = 13;
            this.obrasociallabel.Text = "OBRA SOCIAL";
            // 
            // basicaOSradioButton
            // 
            this.basicaOSradioButton.AutoSize = true;
            this.basicaOSradioButton.Location = new System.Drawing.Point(290, 156);
            this.basicaOSradioButton.Name = "basicaOSradioButton";
            this.basicaOSradioButton.Size = new System.Drawing.Size(72, 24);
            this.basicaOSradioButton.TabIndex = 12;
            this.basicaOSradioButton.TabStop = true;
            this.basicaOSradioButton.Text = "Básica";
            this.basicaOSradioButton.UseVisualStyleBackColor = true;
            // 
            // NoOSradioButton
            // 
            this.NoOSradioButton.AutoSize = true;
            this.NoOSradioButton.Location = new System.Drawing.Point(195, 156);
            this.NoOSradioButton.Name = "NoOSradioButton";
            this.NoOSradioButton.Size = new System.Drawing.Size(87, 24);
            this.NoOSradioButton.TabIndex = 11;
            this.NoOSradioButton.TabStop = true;
            this.NoOSradioButton.Text = "No tiene";
            this.NoOSradioButton.UseVisualStyleBackColor = true;
            // 
            // dnilabel
            // 
            this.dnilabel.AutoSize = true;
            this.dnilabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dnilabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dnilabel.Location = new System.Drawing.Point(70, 105);
            this.dnilabel.Name = "dnilabel";
            this.dnilabel.Size = new System.Drawing.Size(33, 20);
            this.dnilabel.TabIndex = 9;
            this.dnilabel.Text = "DNI";
            // 
            // apellidolabel
            // 
            this.apellidolabel.AutoSize = true;
            this.apellidolabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apellidolabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apellidolabel.Location = new System.Drawing.Point(375, 63);
            this.apellidolabel.Name = "apellidolabel";
            this.apellidolabel.Size = new System.Drawing.Size(78, 20);
            this.apellidolabel.TabIndex = 8;
            this.apellidolabel.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // apellidotextBox
            // 
            this.apellidotextBox.Location = new System.Drawing.Point(468, 56);
            this.apellidotextBox.Name = "apellidotextBox";
            this.apellidotextBox.Size = new System.Drawing.Size(206, 27);
            this.apellidotextBox.TabIndex = 3;
            this.apellidotextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dnitextBox
            // 
            this.dnitextBox.Location = new System.Drawing.Point(114, 99);
            this.dnitextBox.Name = "dnitextBox";
            this.dnitextBox.Size = new System.Drawing.Size(158, 27);
            this.dnitextBox.TabIndex = 2;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(145, 56);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(217, 27);
            this.nombretextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO PACIENTE EN LISTA DE ESPERA";
            // 
            // FormListEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gestionlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.volverbutton);
            this.Controls.Add(this.salirbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListEsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clínica privada de CABA";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cargarbutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Button volverbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gestionlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton completaOSradioButton;
        private System.Windows.Forms.Label fechanaclabel;
        private System.Windows.Forms.TextBox fechatextBox;
        private System.Windows.Forms.Label obrasociallabel;
        private System.Windows.Forms.RadioButton basicaOSradioButton;
        private System.Windows.Forms.RadioButton NoOSradioButton;
        private System.Windows.Forms.Label dnilabel;
        private System.Windows.Forms.Label apellidolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidotextBox;
        private System.Windows.Forms.TextBox dnitextBox;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.Button crearMbutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label esplabel;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEspe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dniBuscartextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label buscarlabel;
        private System.Windows.Forms.Button cargarbutton;
    }
}