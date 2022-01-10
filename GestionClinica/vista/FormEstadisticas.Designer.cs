
namespace VistaClinicaCABA
{
    partial class FormEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticas));
            this.label1 = new System.Windows.Forms.Label();
            this.estadisticasbutton = new System.Windows.Forms.Button();
            this.volverbutton = new System.Windows.Forms.Button();
            this.salirbutton = new System.Windows.Forms.Button();
            this.labellista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masatendioabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "ESTADÍSTICAS HÍSTORICAS";
            // 
            // estadisticasbutton
            // 
            this.estadisticasbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("estadisticasbutton.BackgroundImage")));
            this.estadisticasbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.estadisticasbutton.FlatAppearance.BorderSize = 0;
            this.estadisticasbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadisticasbutton.Location = new System.Drawing.Point(339, 12);
            this.estadisticasbutton.Name = "estadisticasbutton";
            this.estadisticasbutton.Size = new System.Drawing.Size(93, 87);
            this.estadisticasbutton.TabIndex = 24;
            this.estadisticasbutton.UseVisualStyleBackColor = true;
            // 
            // volverbutton
            // 
            this.volverbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.volverbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volverbutton.Location = new System.Drawing.Point(68, 386);
            this.volverbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volverbutton.Name = "volverbutton";
            this.volverbutton.Size = new System.Drawing.Size(241, 32);
            this.volverbutton.TabIndex = 27;
            this.volverbutton.Text = "VOLVER";
            this.volverbutton.UseVisualStyleBackColor = false;
            this.volverbutton.Click += new System.EventHandler(this.volverbutton_Click);
            // 
            // salirbutton
            // 
            this.salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salirbutton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirbutton.Location = new System.Drawing.Point(463, 386);
            this.salirbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(241, 32);
            this.salirbutton.TabIndex = 26;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = false;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // labellista
            // 
            this.labellista.AutoSize = true;
            this.labellista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labellista.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellista.Location = new System.Drawing.Point(46, 171);
            this.labellista.Name = "labellista";
            this.labellista.Size = new System.Drawing.Size(351, 20);
            this.labellista.TabIndex = 30;
            this.labellista.Text = "Lista de profesionales por cantidad de pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "MÉDICOS DISPONIBLES";
            // 
            // masatendioabel
            // 
            this.masatendioabel.AutoSize = true;
            this.masatendioabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masatendioabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masatendioabel.Location = new System.Drawing.Point(46, 212);
            this.masatendioabel.Name = "masatendioabel";
            this.masatendioabel.Size = new System.Drawing.Size(260, 20);
            this.masatendioabel.TabIndex = 28;
            this.masatendioabel.Text = "Médico que más pacientes atendíó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "MÉDICOS DISPONIBLES";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labellista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.masatendioabel);
            this.Controls.Add(this.volverbutton);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadisticasbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadisticas";
            this.Text = "Gestión de clínica privada de CABA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button estadisticasbutton;
        private System.Windows.Forms.Button volverbutton;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Label labellista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label masatendioabel;
        private System.Windows.Forms.Label label2;
    }
}