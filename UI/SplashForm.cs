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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private int move = 0;

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Interval = 30;
            panelBGFont.Width += 7;
            move += 5;
            if (move == 450)
            {
                timerSplash.Stop();
                this.Hide();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }
    }
}