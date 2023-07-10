using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TourismManagementSystem
{
    public partial class Form6 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-T8EDLCJ\SQLEXPRESS;Initial Catalog=DEMO;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void linklbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnRegister.Height = pnLogin.Height;
            pnLogin.Location = new Point(5, 5);
            pnMilestone.Location = new Point(385, 0);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            pnRegister.Height = 0; 
            pnLogin.Location = new Point(315, 0);
            pnMilestone.Location = new Point(0,0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO AUTH1 VALUES (@username, @password, @email, @cpassword)", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", textBox4.Text);
            cmd.Parameters.AddWithValue("@password", textBox1.Text);
            cmd.Parameters.AddWithValue("@cpassword", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("New student inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnRegister.Height = 0;
            pnLogin.Location = new Point(315, 0);
            pnMilestone.Location = new Point(0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text == string.Empty)
            {
                textBoxUserName.Focus();
            }
            else if(textBoxpassword.Text == string.Empty || textBoxpassword.Text.Length < 5)
            {
                textBoxpassword.Focus();
                MessageBox.Show("Password must be 6 characters long");
            }
           // SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-T8EDLCJ\SQLEXPRESS;Initial Catalog=DEMO;Integrated Security=True");
            string query = "Select * from AUTH1 Where username = '" + textBoxUserName.Text.Trim() + "' and password = '" + textBoxpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormLogIn objFrmMain = new FormLogIn();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }
    }
}
