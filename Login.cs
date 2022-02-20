using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Carvajal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SQLConection SQLConection = new SQLConection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String user = Usuario.Text;
            String pass = Contraseña.Text;
            String sql = "SELECT usuario, contraseña FROM usuario WHERE usuario= '" + user.ToString() + "' AND contraseña='" + pass.ToString() + "' ";

            SqlConnection connection = SQLConection.conexion();
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("bienvenido");

                this.Hide();
                Form form = new Panel();
                form.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error No puede ingresar ");

            }
            finally
            {
                connection.Close();
            }

        }
    }
}
