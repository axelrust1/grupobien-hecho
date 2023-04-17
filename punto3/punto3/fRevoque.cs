namespace punto3
{
    public partial class fRevoque : Form
    {
        public fRevoque()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCalcularP_Click(object sender, EventArgs e)
        {
            double ancho = Convert.ToDouble(tAnchoPared.Text);
            double alto = Convert.ToDouble(tAltoPared.Text);
            double metros3 = Convert.ToDouble(tm3.Text);
            double areaPared = ancho * alto;
            double arenafinal = metros3 * areaPared;

            MessageBox.Show("Se necesita " + arenafinal + " m3 de arena para revocar la pared.");

        }

        private void AltoPared_TextChanged(object sender, EventArgs e)
        {

        }

        private void m3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnchoPared_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}