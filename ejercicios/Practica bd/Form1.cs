using Biblioteca;

namespace Practica_bd
{
    public partial class Form1 : Form
    {
        static List<cliente> clientes = new List<cliente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            clientes = ClientesPracticaBd.ObtenerDatos("SELECT * FROM Cliente");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cliente nuevo = new cliente(textBox1.Text, 0);
                ClientesPracticaBd.EscribirDatos(nuevo);
                clientes = ClientesPracticaBd.ObtenerDatos("SELECT * FROM Cliente");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}