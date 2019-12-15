using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenousPluck.Manager.User_manager;
using VenousPluck.Models.BaseModels;

namespace VenousPluck.UI
{
    public partial class RegistrationForm : Form
    {
        public string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public string ImageFile = "No_Image.jpg";
        private readonly UserManager _userManager;

        public RegistrationForm()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void BackPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegImageChooseButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

#pragma warning disable CA1303 // Do not pass literals as localized parameters
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.PNG; *.gif;) | *.jpg;*.jpeg;*.png;*.PNG;*.gif;";
#pragma warning restore CA1303 // Do not pass literals as localized parameters

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        regPictureBox.Image = new Bitmap(openFileDialog.FileName); //Display in form

                        string imageExtention = Path.GetExtension(openFileDialog.FileName); //Get Extention of Image
                        Random random = new Random();  // Generate Random Integer
                        int randowmInt = random.Next(0, 10000);

                        ImageFile = "VenousPluck_" + randowmInt + imageExtention; // Rename The Image

                        string sourcePath = openFileDialog.FileName; //Get the path of Selected Image

                        //string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length); //Get the path of destination

                        string destinatinonPath = paths + "\\images\\" + ImageFile;  // Image to destination Folder

                        File.Copy(sourcePath, destinatinonPath);  // Image copy to destination path

                        MessageBox.Show("Image Upload Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.FirstName = regFirstNameTextBox.Text;
                user.LastName = regLastNameTextBox.Text;
                user.UserName = regUserNameTextBox.Text;
                user.Password = regPasswordTextBox.Text;
                user.Email = regEmailTextBox.Text;
                user.UserAddress = regAddressTextBox.Text;
                user.AddedDate = DateTime.Now;
                user.BloodGroup = regBloodGroupComboBox.Text;
                user.ContactNo = regContactNoTextBox.Text;
                user.Image = ImageFile;

                #region Create

                var isAdded = _userManager.Add(user);
                if (isAdded)
                {
                    MessageBox.Show($"User created successfully of {user.FirstName + " " + user.LastName}");

                    ClearForm();
                    return;
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }

                #endregion Create
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Clear From for Refresh Text Box

        public void ClearForm()
        {
            try
            {
                regFirstNameTextBox.Text = "";
                regLastNameTextBox.Text = "";
                regUserNameTextBox.Text = "";
                regPasswordTextBox.Text = "";
                regEmailTextBox.Text = "";
                regAddressTextBox.Text = "";
                regBloodGroupComboBox.Text = "";
                regContactNoTextBox.Text = "";
                string imgPath = paths + "\\images\\No_Image.jpg";
                regPictureBox.Image = new Bitmap(imgPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Clear From for Refresh Text Box
    }
}