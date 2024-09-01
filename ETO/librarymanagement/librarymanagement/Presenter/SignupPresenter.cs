using librarymanagement.Interface;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagement.Presenter
{
    public class SignupPresenter
    {
        private readonly ISignUpView _signupView;

        public SignupPresenter(ISignUpView signupView)
        {
            _signupView = signupView;
        }

        public void HandleSignup()
        {
            string name = "John";
            string email = "test@gmail.com";
            string password = "qwe123";
            string contact = "123456789";
            string role = "member";

            string connectionString = "server=localhost;database=libsys;user=root;password=root;";

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO user (name, email, password, contact, role) VALUES (@name, @email, @password, @contact, @role)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("contact", contact);
                    cmd.Parameters.AddWithValue("role", role);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        
        }
    }
}
