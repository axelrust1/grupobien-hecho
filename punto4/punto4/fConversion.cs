namespace punto4
{
    public partial class fConversion : Form
    {
        public fConversion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NombreArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TamanoArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCalcularTamnio_Click(object sender, EventArgs e)
        {
            string nombre = tNombreArchivo.Text;
            double tamano = Convert.ToDouble(tTamanoArchivo.Text);

            double valor = tamano / 1024;

            MessageBox.Show("El tamanio del archivo " + nombre + " en GB es: " + valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}