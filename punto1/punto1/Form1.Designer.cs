namespace punto1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tIngresoDatos = new System.Windows.Forms.TextBox();
            this.bCalcularPerimetro = new System.Windows.Forms.Button();
            this.bCalcularArea = new System.Windows.Forms.Button();
            this.tExpresion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            resources.ApplyResources(this.bCerrar, "bCerrar");
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tIngresoDatos
            // 
            resources.ApplyResources(this.tIngresoDatos, "tIngresoDatos");
            this.tIngresoDatos.Name = "tIngresoDatos";
            this.tIngresoDatos.TextChanged += new System.EventHandler(this.IngresoDatos_TextChanged);
            // 
            // bCalcularPerimetro
            // 
            resources.ApplyResources(this.bCalcularPerimetro, "bCalcularPerimetro");
            this.bCalcularPerimetro.Name = "bCalcularPerimetro";
            this.bCalcularPerimetro.UseVisualStyleBackColor = true;
            this.bCalcularPerimetro.Click += new System.EventHandler(this.bCalcularPerimetro_Click);
            // 
            // bCalcularArea
            // 
            resources.ApplyResources(this.bCalcularArea, "bCalcularArea");
            this.bCalcularArea.Name = "bCalcularArea";
            this.bCalcularArea.UseVisualStyleBackColor = true;
            this.bCalcularArea.Click += new System.EventHandler(this.bCalcularArea_Click);
            // 
            // tExpresion
            // 
            resources.ApplyResources(this.tExpresion, "tExpresion");
            this.tExpresion.Name = "tExpresion";
            this.tExpresion.TextChanged += new System.EventHandler(this.tExpresion_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tExpresion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCalcularArea);
            this.Controls.Add(this.bCalcularPerimetro);
            this.Controls.Add(this.tIngresoDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCerrar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bCerrar;
        private Label label1;
        private TextBox tIngresoDatos;
        private Button bCalcularPerimetro;
        private Button bCalcularArea;
        private TextBox tExpresion;
        private Label label2;
    }
}