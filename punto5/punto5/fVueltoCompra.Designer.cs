namespace punto5
{
    partial class fVueltoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVueltoCompra));
            this.tNombreCliente = new System.Windows.Forms.TextBox();
            this.tValorPagado = new System.Windows.Forms.TextBox();
            this.tValorCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCalcularVuelto = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombreCliente
            // 
            this.tNombreCliente.Location = new System.Drawing.Point(448, 66);
            this.tNombreCliente.Name = "tNombreCliente";
            this.tNombreCliente.Size = new System.Drawing.Size(100, 23);
            this.tNombreCliente.TabIndex = 0;
            this.tNombreCliente.TextChanged += new System.EventHandler(this.tNombreCliente_TextChanged);
            // 
            // tValorPagado
            // 
            this.tValorPagado.Location = new System.Drawing.Point(448, 159);
            this.tValorPagado.Name = "tValorPagado";
            this.tValorPagado.Size = new System.Drawing.Size(100, 23);
            this.tValorPagado.TabIndex = 1;
            this.tValorPagado.TextChanged += new System.EventHandler(this.tValorPagado_TextChanged);
            // 
            // tValorCompra
            // 
            this.tValorCompra.Location = new System.Drawing.Point(448, 116);
            this.tValorCompra.Name = "tValorCompra";
            this.tValorCompra.Size = new System.Drawing.Size(100, 23);
            this.tValorCompra.TabIndex = 2;
            this.tValorCompra.TextChanged += new System.EventHandler(this.tValorCompra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(254, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(254, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el precio de la compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(254, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese con cuanto paga";
            // 
            // bCalcularVuelto
            // 
            this.bCalcularVuelto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCalcularVuelto.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bCalcularVuelto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCalcularVuelto.Location = new System.Drawing.Point(304, 248);
            this.bCalcularVuelto.Name = "bCalcularVuelto";
            this.bCalcularVuelto.Size = new System.Drawing.Size(188, 60);
            this.bCalcularVuelto.TabIndex = 6;
            this.bCalcularVuelto.Text = "Calcular vuelto";
            this.bCalcularVuelto.UseVisualStyleBackColor = false;
            this.bCalcularVuelto.Click += new System.EventHandler(this.bCalcularVuelto_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCerrar.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCerrar.Location = new System.Drawing.Point(304, 358);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(188, 32);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fVueltoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcularVuelto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tValorCompra);
            this.Controls.Add(this.tValorPagado);
            this.Controls.Add(this.tNombreCliente);
            this.Name = "fVueltoCompra";
            this.Text = "Calcular Vuelto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tNombreCliente;
        private TextBox tValorPagado;
        private TextBox tValorCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bCalcularVuelto;
        private Button bCerrar;
    }
}