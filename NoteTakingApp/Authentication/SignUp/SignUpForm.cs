using NoteTakingApp.Authentication.Login;
using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp.Authentication.SignUp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        UserRepository userRepository = new UserRepository();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password == confirmPassword)
            {
                var existingUser = userRepository.GetAll().FirstOrDefault(x => x.Username.Equals(username));
                if (existingUser != null)
                {
                    MessageBox.Show("User already exists !");
                    return;
                }
                User newUser = new User()
                {
                    Username = username,
                    Password = password
                };

                userRepository.Create(newUser);

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("");
            }

        }
    }
}
