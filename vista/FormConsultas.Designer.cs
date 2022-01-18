
namespace VistaClinicaCABA
{
    partial class FormConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultas));
            this.volverbutton = new System.Windows.Forms.Button();
            this.salirbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idcomboBox = new System.Windows.Forms.ComboBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.finalizarbutton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnamedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gestionlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelesp = new System.Windows.Forms.Label();
            this.comboBoxEspec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxmedicos = new System.Windows.Forms.ComboBox();
            this.esplabel = new System.Windows.Forms.Label();
            this.comboBoxPacientes = new System.Windows.Forms.ComboBox();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.crearMbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // volverbutton
            // 
            this.volverbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.volverbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volverbutton.Location = new System.Drawing.Point(136, 704);
            this.volverbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volverbutton.Name = "volverbutton";
            this.volverbutton.Size = new System.Drawing.Size(241, 32);
            this.volverbutton.TabIndex = 9;
            this.volverbutton.Text = "VOLVER";
            this.volverbutton.UseVisualStyleBackColor = false;
            this.volverbutton.Click += new System.EventHandler(this.volverbutton_Click);
            // 
            // salirbutton
            // 
            this.salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salirbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirbutton.Location = new System.Drawing.Point(531, 704);
            this.salirbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(241, 32);
            this.salirbutton.TabIndex = 8;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = false;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idcomboBox);
            this.panel2.Controls.Add(this.resultlabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Controls.Add(this.finalizarbutton);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(42, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 349);
            this.panel2.TabIndex = 15;
            // 
            // idcomboBox
            // 
            this.idcomboBox.FormattingEnabled = true;
            this.idcomboBox.Location = new System.Drawing.Point(643, 94);
            this.idcomboBox.Name = "idcomboBox";
            this.idcomboBox.Size = new System.Drawing.Size(184, 28);
            this.idcomboBox.TabIndex = 31;
            this.idcomboBox.SelectedIndexChanged += new System.EventHandler(this.idcomboBox_SelectedIndexChanged);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultlabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultlabel.Location = new System.Drawing.Point(643, 140);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(99, 20);
            this.resultlabel.TabIndex = 30;
            this.resultlabel.Text = "RESULTADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(643, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID CONSULTA";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(643, 176);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(184, 27);
            this.resultTextBox.TabIndex = 28;
            // 
            // finalizarbutton
            // 
            this.finalizarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizarbutton.BackgroundImage")));
            this.finalizarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.finalizarbutton.FlatAppearance.BorderSize = 0;
            this.finalizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizarbutton.Location = new System.Drawing.Point(751, 221);
            this.finalizarbutton.Name = "finalizarbutton";
            this.finalizarbutton.Size = new System.Drawing.Size(70, 53);
            this.finalizarbutton.TabIndex = 27;
            this.finalizarbutton.UseVisualStyleBackColor = true;
            this.finalizarbutton.Click += new System.EventHandler(this.finalizarbutton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(643, 235);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 24);
            this.label.TabIndex = 26;
            this.label.Text = "FINALIZAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnpaciente,
            this.columnamedico,
            this.columnResultado});
            this.dataGridView2.Location = new System.Drawing.Point(40, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(551, 198);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID Consulta";
            this.columnID.MinimumWidth = 6;
            this.columnID.Name = "columnID";
            this.columnID.Width = 125;
            // 
            // columnpaciente
            // 
            this.columnpaciente.HeaderText = "Paciente";
            this.columnpaciente.MinimumWidth = 6;
            this.columnpaciente.Name = "columnpaciente";
            this.columnpaciente.Width = 125;
            // 
            // columnamedico
            // 
            this.columnamedico.HeaderText = "Médico";
            this.columnamedico.MinimumWidth = 6;
            this.columnamedico.Name = "columnamedico";
            this.columnamedico.Width = 125;
            // 
            // columnResultado
            // 
            this.columnResultado.HeaderText = "Resultado";
            this.columnResultado.MinimumWidth = 6;
            this.columnResultado.Name = "columnResultado";
            this.columnResultado.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE CONSULTAS VIGENTES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gestionlabel
            // 
            this.gestionlabel.AutoSize = true;
            this.gestionlabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestionlabel.Location = new System.Drawing.Point(367, 38);
            this.gestionlabel.Name = "gestionlabel";
            this.gestionlabel.Size = new System.Drawing.Size(148, 32);
            this.gestionlabel.TabIndex = 14;
            this.gestionlabel.Text = "CONSULTAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelesp);
            this.panel1.Controls.Add(this.comboBoxEspec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxmedicos);
            this.panel1.Controls.Add(this.esplabel);
            this.panel1.Controls.Add(this.comboBoxPacientes);
            this.panel1.Controls.Add(this.limpiarbutton);
            this.panel1.Controls.Add(this.crearMbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 205);
            this.panel1.TabIndex = 13;
            // 
            // labelesp
            // 
            this.labelesp.AutoSize = true;
            this.labelesp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelesp.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelesp.Location = new System.Drawing.Point(145, 65);
            this.labelesp.Name = "labelesp";
            this.labelesp.Size = new System.Drawing.Size(109, 20);
            this.labelesp.TabIndex = 26;
            this.labelesp.Text = "ESPECIALIDAD";
            // 
            // comboBoxEspec
            // 
            this.comboBoxEspec.FormattingEnabled = true;
            this.comboBoxEspec.Location = new System.Drawing.Point(281, 65);
            this.comboBoxEspec.Name = "comboBoxEspec";
            this.comboBoxEspec.Size = new System.Drawing.Size(410, 28);
            this.comboBoxEspec.TabIndex = 25;
            this.comboBoxEspec.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspec_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "MÉDICOS DISPONIBLES";
            // 
            // comboBoxmedicos
            // 
            this.comboBoxmedicos.FormattingEnabled = true;
            this.comboBoxmedicos.Location = new System.Drawing.Point(281, 156);
            this.comboBoxmedicos.Name = "comboBoxmedicos";
            this.comboBoxmedicos.Size = new System.Drawing.Size(410, 28);
            this.comboBoxmedicos.TabIndex = 23;
            this.comboBoxmedicos.SelectedIndexChanged += new System.EventHandler(this.comboBoxmedicos_SelectedIndexChanged);
            // 
            // esplabel
            // 
            this.esplabel.AutoSize = true;
            this.esplabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esplabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.esplabel.Location = new System.Drawing.Point(30, 108);
            this.esplabel.Name = "esplabel";
            this.esplabel.Size = new System.Drawing.Size(234, 20);
            this.esplabel.TabIndex = 22;
            this.esplabel.Text = "PACIENTES EN LISTA DE ESPERA";
            // 
            // comboBoxPacientes
            // 
            this.comboBoxPacientes.FormattingEnabled = true;
            this.comboBoxPacientes.Location = new System.Drawing.Point(281, 108);
            this.comboBoxPacientes.Name = "comboBoxPacientes";
            this.comboBoxPacientes.Size = new System.Drawing.Size(410, 28);
            this.comboBoxPacientes.TabIndex = 21;
            this.comboBoxPacientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPacientes_SelectedIndexChanged);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpiarbutton.BackgroundImage")));
            this.limpiarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiarbutton.FlatAppearance.BorderSize = 0;
            this.limpiarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarbutton.Location = new System.Drawing.Point(751, 123);
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
            this.crearMbutton.Location = new System.Drawing.Point(751, 65);
            this.crearMbutton.Name = "crearMbutton";
            this.crearMbutton.Size = new System.Drawing.Size(70, 53);
            this.crearMbutton.TabIndex = 19;
            this.crearMbutton.UseVisualStyleBackColor = true;
            this.crearMbutton.Click += new System.EventHandler(this.crearMbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO NUEVA CONSULTA";
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gestionlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.volverbutton);
            this.Controls.Add(this.salirbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestipon de clínica privada CABA";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverbutton;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gestionlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label esplabel;
        private System.Windows.Forms.ComboBox comboBoxPacientes;
        private System.Windows.Forms.Button limpiarbutton;
        private System.Windows.Forms.Button crearMbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxmedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnamedico;
        private System.Windows.Forms.Button finalizarbutton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox idcomboBox;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnResultado;
        private System.Windows.Forms.Label labelesp;
        private System.Windows.Forms.ComboBox comboBoxEspec;
    }
}