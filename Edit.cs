using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class Edit : Form
    {
        String update;
        public Edit(String index)
        {
            InitializeComponent();
            update = index;
        }
        public void UpdateRowSource(String index)
        {
            String item = this.estado.GetItemText(this.estado.SelectedItem);
            String sql = "UPDATE vuelos SET nvuelo= '" + Nvuelo.Text + "',aerolinea= '" + Aerolinia.Text + "',ciudad_origen= '" + Corigen.Text + "',hora_salida= '" + HoraSalida.Text + "',ciudad_destino='" + Cdestino.Text + "',hora_entrada='" + Horallegada.Text + "',fecha='" + fecha.Text + "',estado='" + item + "' WHERE id= '" + index + "';";

            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Actualizardo correctamente !! ");
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRowSource(update);
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            Horallegada.Format = DateTimePickerFormat.Custom;
            Horallegada.CustomFormat = "hh:mm:ss";
            HoraSalida.Format = DateTimePickerFormat.Custom;
            HoraSalida.CustomFormat = "hh:mm:ss";
        }

        private void Nvuelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
