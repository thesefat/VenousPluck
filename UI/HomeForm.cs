using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenousPluck.UI;

namespace VenousPluck
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Close Application
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            //Close Application
            Close();
        }
        #endregion

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserForm userForm = new UserForm();
            userForm.Show();


        }
    }
}
