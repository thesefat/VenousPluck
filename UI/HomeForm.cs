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
using VenousPluck.Models.ViewModels;
using VenousPluck.UI;

namespace VenousPluck
{
    public partial class HomeForm : Form
    {
        private readonly UserManager _userManager;

        public HomeForm()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        #region Close Application

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            //Close Application
            Close();
        }

        #endregion Close Application

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = searchTextBox.Text;
            ICollection<UsersVM> userVm = new List<UsersVM>();
            if (!string.IsNullOrEmpty(value))
            {
                var datalist = _userManager.Search(value);

                foreach (var item in datalist)
                {
                    UsersVM model = new UsersVM()
                    {
                        Name = item.FirstName,
                        Email = item.Email,
                        ContactNo = item.ContactNo,
                        BG = item.BloodGroup,
                        Address = item.UserAddress
                    };
                    userVm.Add(model);
                }
            }

            searchGridView.DataSource = null;
            searchGridView.DataSource = userVm;
        }

        private void DonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorForm donorForm = new DonorForm();
            donorForm.Show();
        }
    }
}