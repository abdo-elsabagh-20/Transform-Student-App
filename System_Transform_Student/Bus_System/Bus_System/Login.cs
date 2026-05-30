using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_System
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(
   "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up sig = new Sign_up();
            sig.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phonetext.Text = "";
            passwordtext.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM UserAccount WHERE Phone=@Phone AND Password=@Password",
                    con);

                cmd.Parameters.AddWithValue("@Phone", phonetext.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passwordtext.Text.Trim());
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("✅ Login Success", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home f = new Home();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("❌ Phone or Password is wrong", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
