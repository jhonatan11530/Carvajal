using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class Bienvenido : Form
    {
        String dato;
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            dato = row.Cells[0].Value.ToString();

            Form form = new View(dato);
            form.Show();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carvajalDataBienvenido.vuelos' Puede moverla o quitarla según sea necesario.
            this.vuelosTableAdapter.Fill(this.carvajalDataBienvenido.vuelos);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String stado = "Salida";
            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            SqlCommand command = new SqlCommand("Select count(id) as id from vuelos where estado Like '" + stado + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (dataGridView1.RowCount.ToString() != reader["id"].ToString())
                {
                    this.vuelosTableAdapter.Fill(this.carvajalDataBienvenido.vuelos);
                    connection.Close();
                }

            }
        }
    }
}
