using librarymanagement.Interface;
using librarymanagement.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagement.View
{
    public partial class SignupView : Form, ISignUpView
    {
        private SignupPresenter _signupPresenter;
        public SignupView()
        {
            InitializeComponent();
            _signupPresenter = new SignupPresenter(this);
        }

        public string Email => throw new NotImplementedException();
        public string Password => throw new NotImplementedException();
        public string Contact => throw new NotImplementedException();
        public string Role => throw new NotImplementedException();
        public void ShowErrorMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            _signupPresenter.HandleSignup();
        }
    }
}
