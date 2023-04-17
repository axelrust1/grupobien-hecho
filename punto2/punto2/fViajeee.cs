namespace punto2
{
    public partial class fViajeee : Form
    {
        public fViajeee()
        {
            InitializeComponent();
        }

        private void bTiempoDuracion_Click(object sender, EventArgs e)
        {
            string lugar = tLugarViaje.Text;
            double distancia = Convert.ToDouble(tDistanciaKM.Text);
            double velocidad = Convert.ToDouble(tVelConstante.Text);
            double horas = (distancia / velocidad);

            MessageBox.Show($"El tiempo de duracion del viaje a " + lugar + " es de: " + Math.Round(horas) + " horas" );
        }

        private void tLugarViaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDistanciaKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void tVelConstante_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}