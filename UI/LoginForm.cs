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
using VenousPluck.Manager.User_manager;
using VenousPluck.Models.ViewModels;

namespace VenousPluck.UI
{
    public partial class LoginForm : Form
    {
        private readonly LoginManager _loginManager;
        private readonly UserManager _userManager;
        private readonly Login loginModel = new Login();

        public static string loggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
            _userManager = new UserManager();
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
                    loggedInUser = loginModel.UserName;
                    long id = _userManager.GetUserIdByName(loggedInUser);

                    if (verificationCheck)
                    {
                        HomeForm homeForm = new HomeForm();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception();
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