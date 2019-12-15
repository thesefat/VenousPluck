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
using VenousPluck.Manager.Donor_manager;
using VenousPluck.Manager.User_manager;
using VenousPluck.Models.BaseModels;

namespace VenousPluck.UI
{
    public partial class DonorFrom : Form
    {
        public string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public string ImageFile = "No_Image.jpg";
        private Donor donor = new Donor();
        private readonly DonorManager _donorManager;
        private readonly UserManager _userManager;

        public DonorFrom()
        {
            InitializeComponent();
            _donorManager = new DonorManager();
            _userManager = new UserManager();
        }

        private void DonorFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donorsDataSet.Donors' table. You can move, or remove it, as needed.

            this.donorsTableAdapter.Fill(this.donorsDataSet.Donors);
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DonorImageChooseButton_Click(object sender, EventArgs e)
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
                        donorPictureBox.Image = new Bitmap(openFileDialog.FileName); //Display in form

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

        private void DonorCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                donor.FirstName = donorFirstNameTextBox.Text;
                donor.LastName = donorLastNameTextBox.Text;
                donor.UserName = donorUserNameTextBox.Text;
                donor.Password = donorPasswordTextBox.Text;
                donor.Email = donorEmailTextBox.Text;
                donor.Address = donorAddressTextBox.Text;
                donor.AddedDate = DateTime.Now;
                donor.BloodGroup = donorBloodGroupTextBox.Text;
                donor.ContactNo = donorContactNoTextBox.Text;

                //AddedByUser

                string loggedInUser = LoginForm.loggedInUser;
                long userId = _userManager.GetUserIdByName(loggedInUser);
                donor.AddedBy = userId;

                donor.Image = ImageFile;

                #region Update

                if (DonorCreateButton.Text == "Update")
                {
                    if (donor.Id > 0)
                    {
                        //donor Update Code Here
                        var isUpdate = _donorManager.Update(donor);
                        if (isUpdate)
                        {
                            MessageBox.Show($"donor Update successfully of {donor.FirstName + " " + donor.LastName}");
                            DataSourceUpdate();
                            ClearForm();
                        }
                        DonorCreateButton.Text = "Create";

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Donor not valid");
                        return;
                    }
                }

                #endregion Update

                #region Create

                if (DonorCreateButton.Text == "Create")
                {
                    var isAdded = _donorManager.Add(donor);
                    if (isAdded)
                    {
                        MessageBox.Show($"Donor created successfully of {donor.FirstName + " " + donor.LastName}");
                        DataSourceUpdate();
                        ClearForm();
                        return;
                    }
                }

                #endregion Create

                MessageBox.Show("Operation Failed");
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
                donorFirstNameTextBox.Text = "";
                donorLastNameTextBox.Text = "";
                donorUserNameTextBox.Text = "";
                donorPasswordTextBox.Text = "";
                donorEmailTextBox.Text = "";
                donorAddressTextBox.Text = "";
                donorBloodGroupTextBox.Text = "";
                donorContactNoTextBox.Text = "";
                string imgPath = paths + "\\images\\No_Image.jpg";
                donorPictureBox.Image = new Bitmap(imgPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Clear From for Refresh Text Box

        #region Data Grid View Source Update

        public void DataSourceUpdate()
        {
            try
            {
                var datalist = _donorManager.GetAllDonor();
                donorsBindingSource.DataSource = null;
                donorsBindingSource.DataSource = datalist;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Data Grid View Source Update

        #region Form Fill Up By Selected User

        public void FormFillUpBySelectedUser(Donor dn)
        {
            try
            {
                donorFirstNameTextBox.Text = dn.FirstName;
                donorLastNameTextBox.Text = dn.LastName;
                donorUserNameTextBox.Text = dn.UserName;
                donorPasswordTextBox.Text = dn.Password;
                donorEmailTextBox.Text = dn.Email;
                donorAddressTextBox.Text = dn.Address;
                donorBloodGroupTextBox.Text = dn.BloodGroup;
                donorContactNoTextBox.Text = dn.ContactNo;
                GetImageFromFile(dn.Image.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Form Fill Up By Selected User

        #region Get Image From File

        public void GetImageFromFile(string _imgName)
        {
            try
            {
                if (_imgName != "No_Image.jpg")
                {
                    string imgPath = paths + "\\images\\" + _imgName;
                    donorPictureBox.Image = new Bitmap(imgPath);
                    return;
                }

                if (_imgName == "No_Image.jpg")
                {
                    string imgPath = paths + "\\images\\" + _imgName;
                    donorPictureBox.Image = new Bitmap(imgPath);
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Get Image From File

        private void DonorDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                string getId = donorDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                donor = _donorManager.GetDonorById(Convert.ToInt64(getId));
                FormFillUpBySelectedUser(donor);
                DonorCreateButton.Text = "Update";
                DonorDeleteButton.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DonorDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure to Delete This Record ?", "Venous Pluck", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _donorManager.Remove(donor);
                    DataSourceUpdate();
                    ClearForm();
                    DonorDeleteButton.Hide();
                    DonorCreateButton.Text = "Create";
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}