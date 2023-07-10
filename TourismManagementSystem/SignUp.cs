using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TourismManagementSystem
{
    public partial class SignUp : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-UUQCIRR2;Initial Catalog=DEMO;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO AUTH1 VALUES (@name, @password, @email, @phone)", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", txtBoxFullName.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxMobile.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
