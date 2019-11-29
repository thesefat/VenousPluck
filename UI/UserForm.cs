using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenousPluck.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
