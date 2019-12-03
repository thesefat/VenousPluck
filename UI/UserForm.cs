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
    public partial class UserForm : Form
    {

        public string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public string ImageFile = "No_Image.jpg";
        User user = new User();
        
        private readonly UserManager _userManager;

        public UserForm()
        {
            InitializeComponent();
            _userManager = new UserManager();
           
        }

        #region Upload Image to File Storage
        private void UserImageChooseButton_Click(object sender, EventArgs e)
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
                        userPictureBox.Image = new Bitmap(openFileDialog.FileName); //Display in form

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
        #endregion

        #region Clear From for Refresh Text Box

        public void ClearForm()
        {

            try
            {
                userFirstNameTextBox.Text = "";
                userLastNameTextBox.Text = "";
                userNameTextBox.Text = "";
                userPasswordTextBox.Text = "";
                userEmailTextBox.Text = "";
                userAddressTextBox.Text = "";
                userBloodGroupTextBox.Text = "";
                userContactNoTextBox.Text = "";
                string imgPath = paths + "\\images\\No_Image.jpg";
                userPictureBox.Image = new Bitmap(imgPath);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }
        #endregion

        #region User Create And Update
        private void UserCreateButton_Click(object sender, EventArgs e)
        {

            try
            {

                user.FirstName = userFirstNameTextBox.Text;
                user.LastName = userLastNameTextBox.Text;
                user.UserName = userNameTextBox.Text;
                user.Password = userPasswordTextBox.Text;
                user.Email = userEmailTextBox.Text;
                user.UserAddress = userAddressTextBox.Text;
                user.AddedDate = DateTime.Now;
                user.BloodGroup = userBloodGroupTextBox.Text;
                user.ContactNo = userContactNoTextBox.Text;
                user.Image = ImageFile;

                #region Update

                if (UserCreateButton.Text == "Update")
                {
                    if (user.Id > 0)
                    {
                        //User Update Code Here
                        var isUpdate = _userManager.Update(user);
                        if (isUpdate)
                        {
                            MessageBox.Show($"User Update successfully of {user.FirstName + " " + user.LastName}");
                            DataSourceUpdate();
                            ClearForm();
                        }
                        UserCreateButton.Text = "Create";

                        return;

                    }
                    else
                    {
                        MessageBox.Show("User not valid");
                        return;
                    }

                }

                #endregion

                #region Create
                if (UserCreateButton.Text == "Create")
                {


                    var isAdded = _userManager.Add(user);
                    if (isAdded)
                    {
                        MessageBox.Show($"User created successfully of {user.FirstName + " " + user.LastName}");
                        DataSourceUpdate();
                        ClearForm();
                        return;
                    }
                }
                #endregion

                MessageBox.Show("Operation Failed");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        #endregion

        #region Data Grid View Source Update
        public void DataSourceUpdate() {

            try
            {
                var datalist = _userManager.GetAllUser();
                usersBindingSource.DataSource = null;
                usersBindingSource.DataSource = datalist;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }

        #endregion

        #region  Single Mouse Click Event
        //private void UserUpdateButton_Click(object sender, EventArgs e)
        //{
        //    UserUpdateButton.Hide();
        //    UserCreateButton.Text = "Update";
        //}
        #endregion

        #region Application Close
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {

            try
            {
                Close();
            }
            catch (Exception ex) 
            {

                throw new Exception(ex.Message);
            }
            
        }

        #endregion

        #region Automatic Table Loader
        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'venousPluckDataSet.Users' table. You can move, or remove it, as needed.
            try
            {
                DataSourceUpdate();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           

           // this.usersTableAdapter.Fill(this.venousPluckDataSet.Users);

        }
        #endregion

        //private void UserDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int rowIndex = e.RowIndex;
        //    userFirstNameTextBox.Text = userDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
        //    userLastNameTextBox.Text = userDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        //    userContactNoTextBox.Text = userDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        //    userNameTextBox.Text = userDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
        //    userPasswordTextBox.Text = userDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
        //    userEmailTextBox.Text = userDataGridView.Rows[rowIndex].Cells[10].Value.ToString();
        //    userAddressTextBox.Text = userDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
        //    userBloodGroupTextBox.Text = userDataGridView.Rows[rowIndex].Cells[8].Value.ToString();

        //    UserCreateButton.Text = "Update";
        //}

        #region Form Fill Up By Selected User 
        public void FormFillUpBySelectedUser( User user )
        {

            try
            {
                userFirstNameTextBox.Text = user.FirstName;
                userLastNameTextBox.Text = user.LastName;
                userNameTextBox.Text = user.UserName;
                userPasswordTextBox.Text = user.Password;
                userEmailTextBox.Text = user.Email;
                userAddressTextBox.Text = user.UserAddress;
                userBloodGroupTextBox.Text = user.BloodGroup;
                userContactNoTextBox.Text = user.ContactNo;
                GetImageFromFile(user.Image.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

           
            
        }
        #endregion

        #region Get Image From File
        public void GetImageFromFile(string _imgName)
        {

            try
            {
                if (_imgName != "No_Image.jpg")
                {
                    string imgPath = paths + "\\images\\" + _imgName;
                    userPictureBox.Image = new Bitmap(imgPath);
                    return;

                }

                if (_imgName == "No_Image.jpg")
                {
                    string imgPath = paths + "\\images\\" + _imgName;
                    userPictureBox.Image = new Bitmap(imgPath);
                    return;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          


        }

        #endregion

        #region Selected User in Update Form
        private void UserDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                string getId = userDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                user = _userManager.GetUserById(Convert.ToInt64(getId));
                FormFillUpBySelectedUser(user);
                UserCreateButton.Text = "Update";
                UserDeleteButton.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           

        
        }

        #endregion

        //private void UserUpdateButton_Click(object sender, EventArgs e)
        //{

        //    UserUpdateButton.Hide();
        //}

        #region User Delete from Table 
        private void UserDeleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are You Sure to Delete This Record ?", "Venous Pluck", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _userManager.Remove(user);
                    DataSourceUpdate();
                    ClearForm();
                    UserDeleteButton.Hide();
                    UserCreateButton.Text = "Create";
                    return;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            
        }

        #endregion
    }
}
