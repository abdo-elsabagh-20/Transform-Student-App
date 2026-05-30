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
    public partial class Areas : Form
    {
        SqlConnection con = new SqlConnection(
           "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
       );
        public Areas()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Area", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvArea.DataSource = dt;
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home log = new Home();
            log.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(areaid.Text) ||
        string.IsNullOrWhiteSpace(areaname.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Area (Area_ID,Area_Name) VALUES (@Area_ID,@Area_Name)",
                    con);
                cmd.Parameters.AddWithValue("@Area_ID", areaid.Text.Trim());
                cmd.Parameters.AddWithValue("@Area_Name", areaname.Text.Trim());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Area added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                areaid.Clear();
                areaname.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(areaid.Text) ||
        string.IsNullOrWhiteSpace(areaname.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(areaid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Area SET  Area_Name=@Area_Name WHERE Area_ID=@Area_ID",
                    con);

                cmd.Parameters.AddWithValue("@Area_ID", id);
                cmd.Parameters.AddWithValue("@Area_Name", areaname.Text.Trim());



                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Areas updated successfully!", "Success",
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
            if (string.IsNullOrWhiteSpace(areaid.Text))
            {
                MessageBox.Show("⚠️ Please select an Area first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Area?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Area WHERE Area_ID=@Area_ID", con);

                cmd.Parameters.AddWithValue("@Area_ID", areaid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Area deleted successfully!");

                LoadData();

                areaid.Clear();
                areaname.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArea.CurrentRow != null)
            {
                areaid.Text = dgvArea.CurrentRow.Cells[0].Value.ToString();
                areaname.Text = dgvArea.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
