namespace punto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresoDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCalcularPerimetro_Click(object sender, EventArgs e)
        {
            string expresion = tExpresion.Text;
            double radio = Convert.ToDouble(tIngresoDatos.Text);
            double perimetro = 2 * System.Math.PI * radio;
            MessageBox.Show($"El perimetro del circulo cuyo radio " + radio + " es: " + perimetro + " " + expresion);
        }

        private void bCalcularArea_Click(object sender, EventArgs e)
        {
            string expresion = tExpresion.Text;
            double radio = Convert.ToDouble(tIngresoDatos.Text);
            double area = System.Math.PI * radio * radio;
            MessageBox.Show($"El area del circulo cuyo radio " + radio + " es: " + area + " " + expresion);
        }

        private void tExpresion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}