namespace punto6
{
    partial class fCapacidadCine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCapacidadCine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tCapacidadPerso = new System.Windows.Forms.TextBox();
            this.tAsistencia = new System.Windows.Forms.TextBox();
            this.bCalculoPorcentaje = new System.Windows.Forms.Button();
            this.bAumentoPersonas = new System.Windows.Forms.Button();
            this.bDisminuirPersonas = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la capacidad de personas de la sala de cine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las personas q asistieron";
            // 
            // tCapacidadPerso
            // 
            this.tCapacidadPerso.Location = new System.Drawing.Point(489, 101);
            this.tCapacidadPerso.Name = "tCapacidadPerso";
            this.tCapacidadPerso.Size = new System.Drawing.Size(100, 23);
            this.tCapacidadPerso.TabIndex = 2;
            // 
            // tAsistencia
            // 
            this.tAsistencia.Location = new System.Drawing.Point(489, 134);
            this.tAsistencia.Name = "tAsistencia";
            this.tAsistencia.Size = new System.Drawing.Size(100, 23);
            this.tAsistencia.TabIndex = 3;
            // 
            // bCalculoPorcentaje
            // 
            this.bCalculoPorcentaje.BackColor = System.Drawing.Color.DarkRed;
            this.bCalculoPorcentaje.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bCalculoPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCalculoPorcentaje.Location = new System.Drawing.Point(148, 184);
            this.bCalculoPorcentaje.Name = "bCalculoPorcentaje";
            this.bCalculoPorcentaje.Size = new System.Drawing.Size(153, 36);
            this.bCalculoPorcentaje.TabIndex = 6;
            this.bCalculoPorcentaje.Text = "Calcular porcentaje";
            this.bCalculoPorcentaje.UseVisualStyleBackColor = false;
            this.bCalculoPorcentaje.Click += new System.EventHandler(this.bCalculoPorcentaje_Click);
            // 
            // bAumentoPersonas
            // 
            this.bAumentoPersonas.BackColor = System.Drawing.Color.DarkRed;
            this.bAumentoPersonas.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bAumentoPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAumentoPersonas.Location = new System.Drawing.Point(148, 226);
            this.bAumentoPersonas.Name = "bAumentoPersonas";
            this.bAumentoPersonas.Size = new System.Drawing.Size(153, 36);
            this.bAumentoPersonas.TabIndex = 7;
            this.bAumentoPersonas.Text = "Aumentar personas";
            this.bAumentoPersonas.UseVisualStyleBackColor = false;
            this.bAumentoPersonas.Click += new System.EventHandler(this.bAumentoPersonas_Click);
            // 
            // bDisminuirPersonas
            // 
            this.bDisminuirPersonas.BackColor = System.Drawing.Color.DarkRed;
            this.bDisminuirPersonas.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bDisminuirPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDisminuirPersonas.Location = new System.Drawing.Point(148, 268);
            this.bDisminuirPersonas.Name = "bDisminuirPersonas";
            this.bDisminuirPersonas.Size = new System.Drawing.Size(153, 35);
            this.bDisminuirPersonas.TabIndex = 8;
            this.bDisminuirPersonas.Text = "Disminuir personas";
            this.bDisminuirPersonas.UseVisualStyleBackColor = false;
            this.bDisminuirPersonas.Click += new System.EventHandler(this.bDisminuirPersonas_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.bCerrar.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCerrar.Location = new System.Drawing.Point(457, 226);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(153, 36);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fCapacidadCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bDisminuirPersonas);
            this.Controls.Add(this.bAumentoPersonas);
            this.Controls.Add(this.bCalculoPorcentaje);
            this.Controls.Add(this.tAsistencia);
            this.Controls.Add(this.tCapacidadPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fCapacidadCine";
            this.Text = "Capacidad Cine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tCapacidadPerso;
        private TextBox tAsistencia;
        private Button bCalculoPorcentaje;
        private Button bAumentoPersonas;
        private Button bDisminuirPersonas;
        private Button bCerrar;
    }
}