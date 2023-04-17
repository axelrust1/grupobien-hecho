namespace punto3
{
    partial class fRevoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRevoque));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tAnchoPared = new System.Windows.Forms.TextBox();
            this.tAltoPared = new System.Windows.Forms.TextBox();
            this.tm3 = new System.Windows.Forms.TextBox();
            this.bCalcularP = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ancho de la pared: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(197, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el alto de la pared: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(197, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese los m3 por metros cuadrados:";
            // 
            // tAnchoPared
            // 
            this.tAnchoPared.Location = new System.Drawing.Point(477, 52);
            this.tAnchoPared.Name = "tAnchoPared";
            this.tAnchoPared.Size = new System.Drawing.Size(100, 23);
            this.tAnchoPared.TabIndex = 3;
            this.tAnchoPared.TextChanged += new System.EventHandler(this.AnchoPared_TextChanged);
            // 
            // tAltoPared
            // 
            this.tAltoPared.Location = new System.Drawing.Point(477, 97);
            this.tAltoPared.Name = "tAltoPared";
            this.tAltoPared.Size = new System.Drawing.Size(100, 23);
            this.tAltoPared.TabIndex = 4;
            this.tAltoPared.TextChanged += new System.EventHandler(this.AltoPared_TextChanged);
            // 
            // tm3
            // 
            this.tm3.Location = new System.Drawing.Point(477, 138);
            this.tm3.Name = "tm3";
            this.tm3.Size = new System.Drawing.Size(100, 23);
            this.tm3.TabIndex = 5;
            this.tm3.TextChanged += new System.EventHandler(this.m3_TextChanged);
            // 
            // bCalcularP
            // 
            this.bCalcularP.Location = new System.Drawing.Point(234, 207);
            this.bCalcularP.Name = "bCalcularP";
            this.bCalcularP.Size = new System.Drawing.Size(269, 135);
            this.bCalcularP.TabIndex = 6;
            this.bCalcularP.Text = "CALCULAR LOS M3";
            this.bCalcularP.UseVisualStyleBackColor = true;
            this.bCalcularP.Click += new System.EventHandler(this.bCalcularP_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(338, 364);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(77, 36);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fRevoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcularP);
            this.Controls.Add(this.tm3);
            this.Controls.Add(this.tAltoPared);
            this.Controls.Add(this.tAnchoPared);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fRevoque";
            this.Text = "Revoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tAnchoPared;
        private TextBox tAltoPared;
        private TextBox tm3;
        private Button bCalcularP;
        private Button bCerrar;
    }
}