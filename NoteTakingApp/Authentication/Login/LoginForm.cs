using Repository.Repository;
using NoteTakingApp.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteTakingApp.Authentication;

namespace NoteTakingApp.Authentication.Login
{
    public partial class LoginForm : Form
    {
        public static int publicUserId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            var user = userRepository.GetAll().FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
            if (user is not null)
            {
                int userId = user.UserId;
                publicUserId = userId;
                //Login successfully
                this.Hide();
                Form mainMenu = new MainMenu.MainMenu();
                mainMenu.Show();
                return;
            }
            else
            {
                //Login failed
                MessageBox.Show("You are not allowed to access this function!", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
