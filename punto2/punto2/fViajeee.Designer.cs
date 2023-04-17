namespace punto2
{
    partial class fViajeee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViajeee));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tVelocidadConstante = new System.Windows.Forms.Label();
            this.tLugarViaje = new System.Windows.Forms.TextBox();
            this.tDistanciaKM = new System.Windows.Forms.TextBox();
            this.tVelConstante = new System.Windows.Forms.TextBox();
            this.bTiempoDuracion = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese a donde quiere viajar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la distancia a recorrer en kilometros:";
            // 
            // tVelocidadConstante
            // 
            this.tVelocidadConstante.AutoSize = true;
            this.tVelocidadConstante.BackColor = System.Drawing.Color.Transparent;
            this.tVelocidadConstante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tVelocidadConstante.Location = new System.Drawing.Point(250, 124);
            this.tVelocidadConstante.Name = "tVelocidadConstante";
            this.tVelocidadConstante.Size = new System.Drawing.Size(248, 15);
            this.tVelocidadConstante.TabIndex = 2;
            this.tVelocidadConstante.Text = "Ingrese la velocidad constante del vehiculo:";
            // 
            // tLugarViaje
            // 
            this.tLugarViaje.Location = new System.Drawing.Point(510, 52);
            this.tLugarViaje.Name = "tLugarViaje";
            this.tLugarViaje.Size = new System.Drawing.Size(100, 23);
            this.tLugarViaje.TabIndex = 3;
            this.tLugarViaje.TextChanged += new System.EventHandler(this.tLugarViaje_TextChanged);
            // 
            // tDistanciaKM
            // 
            this.tDistanciaKM.Location = new System.Drawing.Point(510, 81);
            this.tDistanciaKM.Name = "tDistanciaKM";
            this.tDistanciaKM.Size = new System.Drawing.Size(100, 23);
            this.tDistanciaKM.TabIndex = 4;
            this.tDistanciaKM.TextChanged += new System.EventHandler(this.tDistanciaKM_TextChanged);
            // 
            // tVelConstante
            // 
            this.tVelConstante.Location = new System.Drawing.Point(510, 121);
            this.tVelConstante.Name = "tVelConstante";
            this.tVelConstante.Size = new System.Drawing.Size(100, 23);
            this.tVelConstante.TabIndex = 5;
            this.tVelConstante.TextChanged += new System.EventHandler(this.tVelConstante_TextChanged);
            // 
            // bTiempoDuracion
            // 
            this.bTiempoDuracion.BackColor = System.Drawing.Color.Transparent;
            this.bTiempoDuracion.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bTiempoDuracion.Location = new System.Drawing.Point(284, 180);
            this.bTiempoDuracion.Name = "bTiempoDuracion";
            this.bTiempoDuracion.Size = new System.Drawing.Size(238, 82);
            this.bTiempoDuracion.TabIndex = 6;
            this.bTiempoDuracion.Text = "CALCULAR DURACION DEL VIAJE";
            this.bTiempoDuracion.UseVisualStyleBackColor = false;
            this.bTiempoDuracion.Click += new System.EventHandler(this.bTiempoDuracion_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(345, 337);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(132, 35);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fViajeee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bTiempoDuracion);
            this.Controls.Add(this.tVelConstante);
            this.Controls.Add(this.tDistanciaKM);
            this.Controls.Add(this.tLugarViaje);
            this.Controls.Add(this.tVelocidadConstante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fViajeee";
            this.Text = "Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label tVelocidadConstante;
        private TextBox tLugarViaje;
        private TextBox tDistanciaKM;
        private TextBox tVelConstante;
        private Button bTiempoDuracion;
        private Button bCerrar;
    }
}