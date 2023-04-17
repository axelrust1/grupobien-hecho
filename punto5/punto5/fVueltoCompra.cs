namespace punto5
{
    public partial class fVueltoCompra : Form
    {
        public fVueltoCompra()
        {
            InitializeComponent();
        }

        private void bCalcularVuelto_Click(object sender, EventArgs e)
        {
            string nombre = tNombreCliente.Text;
            double precio = Convert.ToDouble(tValorCompra.Text);
            double pago = Convert.ToDouble(tValorPagado.Text);

            double vuelto = pago - precio;
            MessageBox.Show("El vuelto para " + nombre + " es: " + Math.Round(vuelto, 2));
        }

        private void tNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tValorCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void tValorPagado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}