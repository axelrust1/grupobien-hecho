namespace punto_8
{
    public partial class fIntercambioNumeros : Form
    {
        public fIntercambioNumeros()
        {
            InitializeComponent();
        }

        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            string numeroA = tNumA.Text;
            string numeroB = tNumB.Text;
            string aux;

            aux = numeroA;
            numeroA = numeroB;
            numeroB = aux;

            MessageBox.Show("Numero A: " + numeroA + " Numero B: " + numeroB);

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}