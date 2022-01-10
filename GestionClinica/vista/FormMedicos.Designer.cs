
namespace VistaClinicaCABA
{
    partial class FormMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicos));
            this.salirbutton = new System.Windows.Forms.Button();
            this.volverbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actualizarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxhisto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columndni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.estadisticasbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.buscarlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dniBuscartextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.esplabel = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.crearMbutton = new System.Windows.Forms.Button();
            this.fechanaclabel = new System.Windows.Forms.Label();
            this.fechaNactextBox = new System.Windows.Forms.TextBox();
            this.dnilabel = new System.Windows.Forms.Label();
            this.apellidolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidotextBox = new System.Windows.Forms.TextBox();
            this.dnitextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.ingresoMlabel = new System.Windows.Forms.Label();
            this.gestionlabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salirbutton
            // 
            this.salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salirbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirbutton.Location = new System.Drawing.Point(586, 903);
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
            this.volverbutton.Location = new System.Drawing.Point(167, 903);
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
            this.panel2.Controls.Add(this.actualizarbutton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxhisto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.estadisticasbutton);
            this.panel2.Controls.Add(this.eliminarbutton);
            this.panel2.Controls.Add(this.buscarbutton);
            this.panel2.Controls.Add(this.buscarlabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dniBuscartextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(40, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 514);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // actualizarbutton
            // 
            this.actualizarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizarbutton.BackgroundImage")));
            this.actualizarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actualizarbutton.FlatAppearance.BorderSize = 0;
            this.actualizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarbutton.Location = new System.Drawing.Point(761, 32);
            this.actualizarbutton.Name = "actualizarbutton";
            this.actualizarbutton.Size = new System.Drawing.Size(70, 53);
            this.actualizarbutton.TabIndex = 27;
            this.actualizarbutton.UseVisualStyleBackColor = true;
            this.actualizarbutton.Click += new System.EventHandler(this.actualizarbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "HISTORIAL DE PACIENTES DEL MÉDICO ELEGIDO";
            // 
            // comboBoxhisto
            // 
            this.comboBoxhisto.FormattingEnabled = true;
            this.comboBoxhisto.Location = new System.Drawing.Point(54, 414);
            this.comboBoxhisto.Name = "comboBoxhisto";
            this.comboBoxhisto.Size = new System.Drawing.Size(445, 28);
            this.comboBoxhisto.TabIndex = 25;
            this.comboBoxhisto.SelectedIndexChanged += new System.EventHandler(this.comboBoxhisto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "ESTADÍSTICAS HÍSTORICAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columndni,
            this.columnnombre,
            this.columnapellido,
            this.columnFechaNac,
            this.columnEspecialidad,
            this.columnestado});
            this.dataGridView1.Location = new System.Drawing.Point(30, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(801, 236);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // columnEspecialidad
            // 
            this.columnEspecialidad.HeaderText = "Especialidad";
            this.columnEspecialidad.MinimumWidth = 6;
            this.columnEspecialidad.Name = "columnEspecialidad";
            this.columnEspecialidad.Width = 125;
            // 
            // columnestado
            // 
            this.columnestado.HeaderText = "Estado actual";
            this.columnestado.MinimumWidth = 6;
            this.columnestado.Name = "columnestado";
            this.columnestado.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(563, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "ELIMINAR";
            // 
            // estadisticasbutton
            // 
            this.estadisticasbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("estadisticasbutton.BackgroundImage")));
            this.estadisticasbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.estadisticasbutton.FlatAppearance.BorderSize = 0;
            this.estadisticasbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadisticasbutton.Location = new System.Drawing.Point(596, 376);
            this.estadisticasbutton.Name = "estadisticasbutton";
            this.estadisticasbutton.Size = new System.Drawing.Size(93, 87);
            this.estadisticasbutton.TabIndex = 22;
            this.estadisticasbutton.UseVisualStyleBackColor = true;
            this.estadisticasbutton.Click += new System.EventHandler(this.estadisticasbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarbutton.BackgroundImage")));
            this.eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eliminarbutton.FlatAppearance.BorderSize = 0;
            this.eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbutton.Location = new System.Drawing.Point(650, 34);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(70, 51);
            this.eliminarbutton.TabIndex = 21;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarbutton.BackgroundImage")));
            this.buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscarbutton.FlatAppearance.BorderSize = 0;
            this.buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbutton.Location = new System.Drawing.Point(456, 25);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(81, 66);
            this.buscarbutton.TabIndex = 19;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscarlabel
            // 
            this.buscarlabel.AutoSize = true;
            this.buscarlabel.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarlabel.Location = new System.Drawing.Point(379, 50);
            this.buscarlabel.Name = "buscarlabel";
            this.buscarlabel.Size = new System.Drawing.Size(80, 24);
            this.buscarlabel.TabIndex = 4;
            this.buscarlabel.Text = "BUSCAR";
            this.buscarlabel.Click += new System.EventHandler(this.buscarlabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(163, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "DNI";
            // 
            // dniBuscartextBox
            // 
            this.dniBuscartextBox.Location = new System.Drawing.Point(168, 75);
            this.dniBuscartextBox.Name = "dniBuscartextBox";
            this.dniBuscartextBox.Size = new System.Drawing.Size(158, 27);
            this.dniBuscartextBox.TabIndex = 22;
            this.dniBuscartextBox.TextChanged += new System.EventHandler(this.dniBuscartextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE MÉDICOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.esplabel);
            this.panel1.Controls.Add(this.comboBoxEspecialidad);
            this.panel1.Controls.Add(this.limpiarbutton);
            this.panel1.Controls.Add(this.crearMbutton);
            this.panel1.Controls.Add(this.fechanaclabel);
            this.panel1.Controls.Add(this.fechaNactextBox);
            this.panel1.Controls.Add(this.dnilabel);
            this.panel1.Controls.Add(this.apellidolabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.apellidotextBox);
            this.panel1.Controls.Add(this.dnitextBox);
            this.panel1.Controls.Add(this.nombretextBox);
            this.panel1.Controls.Add(this.ingresoMlabel);
            this.panel1.Location = new System.Drawing.Point(58, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 205);
            this.panel1.TabIndex = 10;
            // 
            // esplabel
            // 
            this.esplabel.AutoSize = true;
            this.esplabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esplabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.esplabel.Location = new System.Drawing.Point(70, 164);
            this.esplabel.Name = "esplabel";
            this.esplabel.Size = new System.Drawing.Size(109, 20);
            this.esplabel.TabIndex = 20;
            this.esplabel.Text = "ESPECIALIDAD";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(250, 156);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(410, 28);
            this.comboBoxEspecialidad.TabIndex = 19;
            this.comboBoxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecialidad_SelectedIndexChanged);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpiarbutton.BackgroundImage")));
            this.limpiarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiarbutton.FlatAppearance.BorderSize = 0;
            this.limpiarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarbutton.Location = new System.Drawing.Point(709, 123);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(70, 53);
            this.limpiarbutton.TabIndex = 18;
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // crearMbutton
            // 
            this.crearMbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crearMbutton.BackgroundImage")));
            this.crearMbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crearMbutton.FlatAppearance.BorderSize = 0;
            this.crearMbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearMbutton.Location = new System.Drawing.Point(709, 47);
            this.crearMbutton.Name = "crearMbutton";
            this.crearMbutton.Size = new System.Drawing.Size(70, 53);
            this.crearMbutton.TabIndex = 17;
            this.crearMbutton.UseVisualStyleBackColor = true;
            this.crearMbutton.Click += new System.EventHandler(this.crearPbutton_Click);
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
            // fechaNactextBox
            // 
            this.fechaNactextBox.Location = new System.Drawing.Point(505, 107);
            this.fechaNactextBox.Name = "fechaNactextBox";
            this.fechaNactextBox.Size = new System.Drawing.Size(133, 27);
            this.fechaNactextBox.TabIndex = 14;
            // 
            // dnilabel
            // 
            this.dnilabel.AutoSize = true;
            this.dnilabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dnilabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dnilabel.Location = new System.Drawing.Point(70, 114);
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
            // 
            // dnitextBox
            // 
            this.dnitextBox.Location = new System.Drawing.Point(109, 107);
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
            this.nombretextBox.TextChanged += new System.EventHandler(this.nombretextBox_TextChanged);
            // 
            // ingresoMlabel
            // 
            this.ingresoMlabel.AutoSize = true;
            this.ingresoMlabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingresoMlabel.Location = new System.Drawing.Point(20, 15);
            this.ingresoMlabel.Name = "ingresoMlabel";
            this.ingresoMlabel.Size = new System.Drawing.Size(184, 20);
            this.ingresoMlabel.TabIndex = 0;
            this.ingresoMlabel.Text = "INGRESO MÉDICO NUEVO";
            // 
            // gestionlabel
            // 
            this.gestionlabel.AutoSize = true;
            this.gestionlabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestionlabel.Location = new System.Drawing.Point(348, 36);
            this.gestionlabel.Name = "gestionlabel";
            this.gestionlabel.Size = new System.Drawing.Size(263, 32);
            this.gestionlabel.TabIndex = 12;
            this.gestionlabel.Text = "GESTIÓN DE MÉDICOS";
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 970);
            this.Controls.Add(this.gestionlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.volverbutton);
            this.Controls.Add(this.salirbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clínica privada de CABA";
            this.Load += new System.EventHandler(this.FormMedicos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Button volverbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dniBuscartextBox;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Label buscarlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.Button crearMbutton;
        private System.Windows.Forms.Label fechanaclabel;
        private System.Windows.Forms.TextBox fechaNactextBox;
        private System.Windows.Forms.Label dnilabel;
        private System.Windows.Forms.Label apellidolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidotextBox;
        private System.Windows.Forms.TextBox dnitextBox;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.Label ingresoMlabel;
        private System.Windows.Forms.Label gestionlabel;
        private System.Windows.Forms.Label esplabel;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button estadisticasbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxhisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnestado;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button actualizarbutton;
    }
}