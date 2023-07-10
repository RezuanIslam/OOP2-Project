using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismManagementSystem
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
                this.Hide();
            }
        }
    }
}
