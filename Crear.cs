using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class Crear : Form
    {

        public Crear()
        {
            InitializeComponent();

        }

        private void Nvuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            Horallegada.Format = DateTimePickerFormat.Custom;
            Horallegada.CustomFormat = "hh:mm:ss";
            HoraSalida.Format = DateTimePickerFormat.Custom;
            HoraSalida.CustomFormat = "hh:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String item = this.estado.GetItemText(this.estado.SelectedItem);
            String sql = "INSERT INTO vuelos(ciudad_origen, ciudad_destino, fecha, hora_salida, hora_entrada, nvuelo, aerolinea, estado) " +
                "VALUES ('" + Corigen.Text + "','" + Cdestino.Text + "','" + fecha.Text + "','" + HoraSalida.Text + "','" + Horallegada.Text + "','" + Nvuelo.Text + "','" + Aerolinia.Text + "','" + item + "')";

            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Los datos se han guardado exitosamente !!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error no se puede insertar " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
