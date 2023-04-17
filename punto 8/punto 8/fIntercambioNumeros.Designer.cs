namespace punto_8
{
    partial class fIntercambioNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIntercambioNumeros));
            this.bIntercambiar = new System.Windows.Forms.Button();
            this.tNumA = new System.Windows.Forms.TextBox();
            this.tNumB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntercambiar
            // 
            this.bIntercambiar.Location = new System.Drawing.Point(328, 252);
            this.bIntercambiar.Name = "bIntercambiar";
            this.bIntercambiar.Size = new System.Drawing.Size(168, 49);
            this.bIntercambiar.TabIndex = 0;
            this.bIntercambiar.Text = "INTERCAMBIAR";
            this.bIntercambiar.UseVisualStyleBackColor = true;
            this.bIntercambiar.Click += new System.EventHandler(this.bIntercambiar_Click);
            // 
            // tNumA
            // 
            this.tNumA.Location = new System.Drawing.Point(449, 68);
            this.tNumA.Name = "tNumA";
            this.tNumA.Size = new System.Drawing.Size(100, 23);
            this.tNumA.TabIndex = 1;
            // 
            // tNumB
            // 
            this.tNumB.Location = new System.Drawing.Point(449, 106);
            this.tNumB.Name = "tNumB";
            this.tNumB.Size = new System.Drawing.Size(100, 23);
            this.tNumB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(299, 71);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese numero A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese numero B";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(328, 327);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(168, 49);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fIntercambioNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumB);
            this.Controls.Add(this.tNumA);
            this.Controls.Add(this.bIntercambiar);
            this.Name = "fIntercambioNumeros";
            this.Text = "Ingrese numero A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bIntercambiar;
        private TextBox tNumA;
        private TextBox tNumB;
        private Label label1;
        private Label label2;
        private Button bCerrar;
    }
}