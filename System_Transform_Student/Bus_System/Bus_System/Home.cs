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
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(
   "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
);
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students stu = new Students();
            stu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subscriptions sub = new Subscriptions();
            sub.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivers dr = new Drivers();
            dr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Areas are = new Areas();
            are.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buses bu = new Buses();
            bu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bus_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadStudentCount();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Log Out?", "sure", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }

        private void student_Click(object sender, EventArgs e)
        {

        }
        void LoadStudentCount()
        {
            con.Open();

            student.Text = new SqlCommand("SELECT COUNT(*) FROM Student", con).ExecuteScalar().ToString();
            subscription.Text = new SqlCommand("SELECT COUNT(*) FROM Subscription", con).ExecuteScalar().ToString();
            driver.Text = new SqlCommand("SELECT COUNT(*) FROM Driver", con).ExecuteScalar().ToString();
            area.Text = new SqlCommand("SELECT COUNT(*) FROM Area", con).ExecuteScalar().ToString();
            bus.Text = new SqlCommand("SELECT COUNT(*) FROM Bus", con).ExecuteScalar().ToString();
            trip.Text = new SqlCommand("SELECT COUNT(*) FROM Trip", con).ExecuteScalar().ToString();

            con.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Trips tr = new Trips();
            tr.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
