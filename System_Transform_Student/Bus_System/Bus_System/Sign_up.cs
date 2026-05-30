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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bus_System
{
    public partial class Sign_up : Form
    {
        SqlConnection con = new SqlConnection(
           "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
       );
        public Sign_up()
        {
            InitializeComponent();
        }


        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (phonetext.Text == "" || emailtext.Text == "" || passtext.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO UserAccount (Phone,Email,Password) VALUES (@Phone,@Email,@Password)",
                        con);
                    cmd.Parameters.AddWithValue("@Phone", phonetext.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", emailtext.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", passtext.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("✅ User created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phonetext.Clear();
                    emailtext.Clear();
                    passtext.Clear();
                    Login Login = new Login();
                    Login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
