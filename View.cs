
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class View : Form
    {
        public View(String index)
        {
            InitializeComponent();


            String sql = "SELECT * FROM vuelos WHERE id='" + index + "';";

            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            try
            {

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader myreader = command.ExecuteReader();
                while (myreader.Read())
                {

                    Nvuelo.Text = myreader["nvuelo"].ToString();
                    Aerolinia.Text = myreader["aerolinea"].ToString();
                    Corigen.Text = myreader["ciudad_origen"].ToString();
                    Horallegada.Text = myreader["hora_entrada"].ToString();
                    fecha.Text = myreader["fecha"].ToString();
                    HoraSalida.Text = myreader["hora_salida"].ToString();
                    Cdestino.Text = myreader["ciudad_destino"].ToString();
                    estado.Text = myreader["estado"].ToString();

                }
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
