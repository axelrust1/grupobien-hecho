namespace punto4
{
    partial class fConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConversion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNombreArchivo = new System.Windows.Forms.TextBox();
            this.tTamanoArchivo = new System.Windows.Forms.TextBox();
            this.bCalcularTamnio = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(291, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de archivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(246, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "tamano del archivo (MB)";
            // 
            // tNombreArchivo
            // 
            this.tNombreArchivo.Location = new System.Drawing.Point(443, 128);
            this.tNombreArchivo.Name = "tNombreArchivo";
            this.tNombreArchivo.Size = new System.Drawing.Size(100, 23);
            this.tNombreArchivo.TabIndex = 2;
            this.tNombreArchivo.TextChanged += new System.EventHandler(this.NombreArchivo_TextChanged);
            // 
            // tTamanoArchivo
            // 
            this.tTamanoArchivo.Location = new System.Drawing.Point(443, 170);
            this.tTamanoArchivo.Name = "tTamanoArchivo";
            this.tTamanoArchivo.Size = new System.Drawing.Size(100, 23);
            this.tTamanoArchivo.TabIndex = 3;
            this.tTamanoArchivo.TextChanged += new System.EventHandler(this.TamanoArchivo_TextChanged);
            // 
            // bCalcularTamnio
            // 
            this.bCalcularTamnio.Location = new System.Drawing.Point(212, 250);
            this.bCalcularTamnio.Name = "bCalcularTamnio";
            this.bCalcularTamnio.Size = new System.Drawing.Size(160, 61);
            this.bCalcularTamnio.TabIndex = 4;
            this.bCalcularTamnio.Text = "Calcular tamano";
            this.bCalcularTamnio.UseVisualStyleBackColor = true;
            this.bCalcularTamnio.Click += new System.EventHandler(this.bCalcularTamnio_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(470, 250);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(160, 61);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // fConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcularTamnio);
            this.Controls.Add(this.tTamanoArchivo);
            this.Controls.Add(this.tNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fConversion";
            this.Text = "Conversion MB a GB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tNombreArchivo;
        private TextBox tTamanoArchivo;
        private Button bCalcularTamnio;
        private Button bCerrar;
    }
}