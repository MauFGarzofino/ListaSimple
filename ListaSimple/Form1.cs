namespace ListaSimple
{
    public partial class Form1 : Form
    {
        TListaAsig Lista1 = new TListaAsig();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                label3.Text = "";
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            if (nombre.Text == string.Empty || cHoras.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Los Datos");
            }
            else
            {
                Lista1.crearLista(nombre.Text, int.Parse(cHoras.Text));
                label3.Text = nombre.Text + "    " + int.Parse(cHoras.Text);
                nombre.Text = "";
                cHoras.Text = "";
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {

            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
            {
                TNodo a;
                a = Lista1.getProxCursor();
                label3.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
                Lista1.cursor = a;
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
            {
                TNodo a;
                a = Lista1.getAntCursor();
                label3.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
                Lista1.cursor = a;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
                Lista1.EliminarUltimo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
                Lista1.eliminarPrimero();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
                Lista1.eliminarLista();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
                label3.Text = "";
            }
            else
                Lista1.inicializar();
        }

        private void PrimerElem_Click(object sender, EventArgs e)
        {
            if (!Lista1.Vacio())
            {
                TNodo a;
                a = Lista1.getPrimero();
                label3.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Aviso");
                label3.Text = "";
            }
        }

        private void UltElem_Click(object sender, EventArgs e)
        {
            if (!Lista1.Vacio())
            {
                TNodo a;
                a = Lista1.getUltimo();
                label3.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Aviso");
                label3.Text = "";
            }
        }
    }
}