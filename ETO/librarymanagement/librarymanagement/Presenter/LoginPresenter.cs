using librarymanagement.Interface;
using librarymanagement.View;
using MySql.Data.MySqlClient;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace librarymanagement.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly Form _loginForm;

        public LoginPresenter(ILoginView view, Form loginForm)
        {
            _view = view;
            _loginForm = loginForm;
        }

        public void Login()
        {
            string username = _view.Username;
            string password = _view.Password;

            User user = ValidateLogin(username, password);            
            if (user != null)
            {
                _view.ShowMessage("Login successful!");
                string userInfo = $"Hello {user.Name}, email:  {user.Email}, contact: {user.Contact}, role: {user.Role}";
                
                _view.DisplayUserName(userInfo); 

                ShowUi(user.Role);
            }
            else
            {
                _view.ShowMessage("Invalid username or password.");
            }
        }

        private void ShowUi(string role)
        {
            switch (role)
            {
                case "admin":
                    AdmivView adminView = new AdmivView();
                    adminView.Show();
                    _loginForm.Hide();
                    break;
                case "librarian":
                case "member":
                    UserView userView = new UserView();                    
                    userView.Show();
                    _loginForm.Hide();
                    break;
                default:
                    MessageBox.Show("Invalid role");
                    break;
            }
        }


        private User ValidateLogin(string username, string password)
        {
            string connectionString = "server=localhost;database=libsys;user=root;password=root;";
            User user = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM user WHERE email=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = Convert.ToInt32(reader["userId"]),
                                Name = reader["name"].ToString(),
                                Email = reader["email"].ToString(),
                                Contact = reader["contact"].ToString(),
                                Role = reader["role"].ToString(),                                
                            };
                        }                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            return user;
        }
    }
}