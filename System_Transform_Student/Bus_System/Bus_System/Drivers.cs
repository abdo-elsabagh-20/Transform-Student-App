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
using static System.Net.Mime.MediaTypeNames;

namespace Bus_System
{
    public partial class Drivers : Form
    {
        SqlConnection con = new SqlConnection(
           "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
       );
        public Drivers()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Driver", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            driverGrid.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (driverGrid.CurrentRow != null)
            {
                drivid.Text = driverGrid.CurrentRow.Cells[0].Value.ToString();
                drivname.Text = driverGrid.CurrentRow.Cells[1].Value.ToString();
                drivPhone.Text = driverGrid.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home log = new Home();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(drivname.Text) ||
        string.IsNullOrWhiteSpace(drivPhone.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Driver (Driver_ID,Driver_Name, Driver_Phone) VALUES (@Driver_ID,@Driver_Name, @Driver_Phone)",
                    con);
                cmd.Parameters.AddWithValue("@Driver_ID", drivid.Text.Trim());
                cmd.Parameters.AddWithValue("@Driver_Name", drivname.Text.Trim());
                cmd.Parameters.AddWithValue("@Driver_Phone", drivPhone.Text.Trim());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Driver added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                drivid.Clear();
                drivname.Clear();
                drivPhone.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(drivname.Text) ||
        string.IsNullOrWhiteSpace(drivPhone.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(drivid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Driver SET Driver_ID=@Driver_ID, Driver_Name=@Driver_Name, Driver_Phone=@Driver_Phone WHERE Driver_ID=@Driver_ID",
                    con);

                cmd.Parameters.AddWithValue("@Driver_ID", id);
                cmd.Parameters.AddWithValue("@Driver_Name", drivname.Text.Trim());
                cmd.Parameters.AddWithValue("@Driver_Phone", drivPhone.Text.Trim());


                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Driver updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("❌ No record found with this ID!", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("❌ Error: " + ex.Message, "Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(drivid.Text))
            {
                MessageBox.Show("⚠️ Please select a Driver first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Driver?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Driver WHERE Driver_ID=@Driver_ID", con);

                cmd.Parameters.AddWithValue("@Driver_ID", drivid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Student deleted successfully!");

                LoadData();

                drivid.Clear();
                drivname.Clear();
                drivPhone.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
