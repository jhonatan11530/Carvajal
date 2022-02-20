
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class Panel : Form
    {

        String dato;
        public Panel()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Crear();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form form = new View(dato);
            form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            dato = row.Cells[0].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar el registro?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminara el Registro");

                String sql = "DELETE FROM vuelos WHERE id=" + dato;
                SqlConnection connection = SQLConection.conexion();
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }



            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Se mantendra los datos");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Edit(dato);
            form.ShowDialog();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carvajalDataSet.vuelos' Puede moverla o quitarla según sea necesario.
            this.vuelosTableAdapter.Fill(this.carvajalDataSet.vuelos);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            SqlCommand command = new SqlCommand("Select count(id) as id from vuelos", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (dataGridView1.RowCount.ToString() != reader["id"].ToString())
                {
                    this.vuelosTableAdapter.Fill(this.carvajalDataSet.vuelos);
                    connection.Close();
                }

            }
        }
    }
}
