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
    public partial class Trips : Form
    {
        SqlConnection con = new SqlConnection(
   "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
);
        public Trips()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Trip", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tripDGV.DataSource = dt;
        }

        private void Trips_Load(object sender, EventArgs e)
        {
            LoadData();
            SqlCommand cmd = new SqlCommand("SELECT Bus_ID FROM Bus", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                busid.Items.Add(dr["Bus_ID"].ToString());
            }

            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home log = new Home();
            log.Show();
            this.Hide();
        }

        private void addtrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tripid.Text) ||
        string.IsNullOrWhiteSpace(date.Text) ||
        string.IsNullOrWhiteSpace(time.Text) ||
        string.IsNullOrWhiteSpace(busid.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Trip (Trip_Id, Trip_date, Trip_time, Bus_ID) VALUES (@Trip_Id, @Trip_date, @Trip_time, @Bus_ID)",
                    con);
                cmd.Parameters.AddWithValue("@Trip_Id", tripid.Text.Trim());
                cmd.Parameters.AddWithValue("@Trip_date", date.Value.Date);
                cmd.Parameters.AddWithValue("@Trip_time", time.Value.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@Bus_ID", busid.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Trip added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                tripid.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updatetrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tripid.Text) ||
        string.IsNullOrWhiteSpace(date.Text) ||
        string.IsNullOrWhiteSpace(time.Text) || string.IsNullOrWhiteSpace(busid.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tripid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Trip SET Trip_date=@Trip_date, Trip_time=@Trip_time, Bus_ID=@Bus_ID  WHERE Trip_Id=@Trip_Id",
                    con);

                cmd.Parameters.AddWithValue("@Trip_Id", id);
                cmd.Parameters.AddWithValue("@Trip_date", date.Value.Date);
                cmd.Parameters.AddWithValue("@Trip_time", time.Value.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@Bus_ID", busid.Text.Trim());



                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Trip updated successfully!", "Success",
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

        private void tripDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tripDGV.CurrentRow != null)
            {
                tripid.Text = tripDGV.CurrentRow.Cells[0].Value.ToString();

                date.Value = Convert.ToDateTime(tripDGV.CurrentRow.Cells[1].Value);

                TimeSpan t = (TimeSpan)tripDGV.CurrentRow.Cells[2].Value;
                time.Value = DateTime.Today.Add(t);

                busid.Text = tripDGV.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void deletetrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tripid.Text))
            {
                MessageBox.Show("⚠️ Please select a Trip first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Trip?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Trip WHERE Trip_Id=@Trip_Id", con);
                cmd.Parameters.AddWithValue("@Trip_Id", tripid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Trip deleted successfully!");

                LoadData();

                tripid.Clear();
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
