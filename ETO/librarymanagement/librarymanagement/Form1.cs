using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarymanagement.Interface;
using librarymanagement.Presenter;
using MySql.Data.MySqlClient;

namespace librarymanagement
{
    public partial class Form1 : Form, ILoginView
    {
        private LoginPresenter _presenter;

        public string Username => usernameTf.Text;
        public string Password => passwordTf.Text;
        public Form1()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, this);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
         {
            _presenter.Login();
        }        
               
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void DisplayUserName(string name)
        {
            MessageBox.Show(name);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
