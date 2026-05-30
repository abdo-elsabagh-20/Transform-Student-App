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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bus_System
{
    public partial class Buses : Form
    {
        SqlConnection con = new SqlConnection(
   "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
);
        public Buses()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Bus", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBuses.DataSource = dt;
        }

        private void Buses_Load(object sender, EventArgs e)
        {
            LoadData();
            SqlCommand cmd = new SqlCommand("SELECT Driver_ID FROM Driver", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbDriver.Items.Add(dr["Driver_ID"].ToString());
            }

            con.Close();
            // Area
            SqlCommand cmdArea = new SqlCommand("SELECT Area_ID FROM Area", con);

            con.Open();
            SqlDataReader dr2 = cmdArea.ExecuteReader();

            while (dr2.Read())
            {
                cmbArea.Items.Add(dr2["Area_ID"].ToString());
            }
            con.Close();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(busid.Text) ||
string.IsNullOrWhiteSpace(txtCapacity.Text) ||
string.IsNullOrWhiteSpace(txtRoute.Text) || string.IsNullOrWhiteSpace(cmbDriver.Text) || string.IsNullOrWhiteSpace(cmbArea.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Bus (Bus_ID, Capacity, Route, Driver_ID, Area_ID) VALUES (@Bus_ID, @Capacity, @Route, @Driver_ID, @Area_ID)",
                    con);
                cmd.Parameters.AddWithValue("@Bus_ID", busid.Text.Trim());
                cmd.Parameters.AddWithValue("@Capacity", txtCapacity.Text.Trim());
                cmd.Parameters.AddWithValue("@Route", txtRoute.Text.Trim());
                cmd.Parameters.AddWithValue("@Driver_ID", cmbDriver.Text.Trim());
                cmd.Parameters.AddWithValue("@Area_ID", cmbArea.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Buses added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                busid.Clear();
                txtCapacity.Clear();
                txtRoute.Clear();
                cmbDriver.SelectedIndex = -1;
                cmbArea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(busid.Text) ||
        string.IsNullOrWhiteSpace(txtCapacity.Text) ||
        string.IsNullOrWhiteSpace(txtRoute.Text) || string.IsNullOrWhiteSpace(cmbDriver.Text) || string.IsNullOrWhiteSpace(cmbArea.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(busid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Bus SET Bus_ID=@Bus_ID, Capacity=@Capacity, Route=@Route, Driver_ID=@Driver_ID, Area_ID=@Area_ID WHERE Bus_ID=@Bus_ID",
                    con);

                cmd.Parameters.AddWithValue("@Bus_ID", id);
                cmd.Parameters.AddWithValue("@Capacity", txtCapacity.Text.Trim());
                cmd.Parameters.AddWithValue("@Route", txtRoute.Text.Trim());
                cmd.Parameters.AddWithValue("@Driver_ID", cmbDriver.Text.Trim());
                cmd.Parameters.AddWithValue("@Area_ID", cmbArea.Text.Trim());


                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Buses updated successfully!", "Success",
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
            if (string.IsNullOrWhiteSpace(busid.Text))
            {
                MessageBox.Show("⚠️ Please select a Bus first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Bus?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Bus WHERE Bus_ID=@Bus_ID", con);

                cmd.Parameters.AddWithValue("@Bus_ID", busid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Bus deleted successfully!");

                LoadData();

                busid.Clear();
                txtCapacity.Clear();
                txtRoute.Clear();
                cmbDriver.SelectedIndex = -1;
                cmbArea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvBuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuses.CurrentRow != null)
            {
                busid.Text = dgvBuses.CurrentRow.Cells[0].Value.ToString();
                txtCapacity.Text = dgvBuses.CurrentRow.Cells[1].Value.ToString();
                txtRoute.Text = dgvBuses.CurrentRow.Cells[2].Value.ToString();
                cmbDriver.Text = dgvBuses.CurrentRow.Cells[3].Value.ToString();
                cmbArea.Text = dgvBuses.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
