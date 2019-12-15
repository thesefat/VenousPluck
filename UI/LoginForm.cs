using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenousPluck.Manager.Login_manager;
using VenousPluck.Models.ViewModels;

namespace VenousPluck.UI
{
    public partial class LoginForm : Form
    {
        private readonly LoginManager _loginManager;
        private Login loginModel = new Login();

        public LoginForm()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = loginUserNameTextBox.Text;
                var password = loginPasswordTextBox.Text;

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                {
                    loginModel.UserName = userName;
                    loginModel.Password = password;
                    bool verificationCheck = _loginManager.VerifyLogin(loginModel);

                    if (verificationCheck)
                    {
                        MessageBox.Show("Login Success");
                        HomeForm homeForm = new HomeForm();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! \n Try Again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}