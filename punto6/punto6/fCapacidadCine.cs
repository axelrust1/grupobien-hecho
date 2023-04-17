namespace punto6
{
    public partial class fCapacidadCine : Form
    {
        int personas;
        public fCapacidadCine()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void bAumentoPersonas_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(tCapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(tAsistencia.Text);

            
            MessageBox.Show("las personas que asistieron eran " + AsisPersona + ". Pero ingreso una mas y quedo en " + ++AsisPersona);
            tAsistencia.Text = Convert.ToString(AsisPersona);
                
        }

        private void bCalculoPorcentaje_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(tCapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(tAsistencia.Text);

            MessageBox.Show("El cine esta en un " + (AsisPersona * 100) / capacidad + "% de su capacidad");
        }

        private void bDisminuirPersonas_Click(object sender, EventArgs e)
        {
            int capacidad = Convert.ToInt32(tCapacidadPerso.Text);
            int AsisPersona = Convert.ToInt32(tAsistencia.Text);


            MessageBox.Show("las personas que asistieron eran " + AsisPersona + ". Pero se fue una mas y quedo en " + --AsisPersona);
            tAsistencia.Text = Convert.ToString(AsisPersona);
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}