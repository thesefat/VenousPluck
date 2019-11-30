using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenousPluck.Manager.User_manager;
using VenousPluck.Models.BaseModels;

namespace VenousPluck.UI
{
    public partial class UserForm : Form
    {


        private readonly UserManager _userManager;

        public UserForm()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        #region Image
        private void UserImageChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

#pragma warning disable CA1303 // Do not pass literals as localized parameters
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.PNG; *.gif;) | *.jpg;*.jpeg;*.png;*.PNG;*.gif;";
#pragma warning restore CA1303 // Do not pass literals as localized parameters

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.CheckFileExists)
                {
                    userPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        #endregion



        #region Form Clear

        public void ClearForm()
        {
            userFirstNameTextBox.Text = "";
            userLastNameTextBox.Text = "";
            userNameTextBox.Text = "";
            userPasswordTextBox.Text = "";
            userEmailTextBox.Text = "";
            userAddressTextBox.Text = "";
            userBloodGroupTextBox.Text = "";
            userContactNoTextBox.Text = "";
            userPictureBox = null;
        }
        #endregion


        public string ImageFile = "No_Image.jpg";



        #region Create User
        private void UserCreateButton_Click(object sender, EventArgs e)
        {

            User user = new User()
            {

                FirstName = userFirstNameTextBox.Text,
                LastName = userLastNameTextBox.Text,
                UserName = userNameTextBox.Text,
                Password = userPasswordTextBox.Text,
                Email = userEmailTextBox.Text,
                UserAddress = userAddressTextBox.Text,
                AddedDate = DateTime.Now,
                BloodGroup = userBloodGroupTextBox.Text,
                ContactNo = userContactNoTextBox.Text,
                Image = ImageFile
            };

            if (UserCreateButton.Text == "Update")
            {
                if (user.Id>0)
                {
                    //User Update Code Here
                    var isUpdate = _userManager.Update(user);
                    if (isUpdate)
                    {
                        MessageBox.Show($"User Update successfully of {user.FirstName + " " + user.LastName}");
                    }
                    UserCreateButton.Text = "Create";
                    UserUpdateButton.Show();
                    return;

                }
                else
                {
                    MessageBox.Show("User not valid");
                    return;
                }
               
            }
           

            if (UserCreateButton.Text == "Create")
            {
                var isAdded = _userManager.Add(user);
                if (isAdded)
                {
                    MessageBox.Show($"User created successfully of {user.FirstName + " " + user.LastName}");
                    ClearForm();
                    return;
                }
            }

            MessageBox.Show("Operation Failed");

        }
        #endregion



        #region Show in Grid

        #endregion
        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            UserUpdateButton.Hide();
            UserCreateButton.Text = "Update";
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'venousPluckDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.venousPluckDataSet.Users);

        }
    }
}
