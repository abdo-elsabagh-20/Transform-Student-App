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
    public partial class Subscriptions : Form
    {
        SqlConnection con = new SqlConnection(
          "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
      );
        public Subscriptions()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Subscription", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            subsDGV.DataSource = dt;
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {
            LoadData();
            SqlCommand cmd = new SqlCommand("SELECT Student_ID FROM Student", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                stuid.Items.Add(dr["Student_ID"].ToString());
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
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subid.Text) ||
                string.IsNullOrWhiteSpace(stuid.Text) ||
                string.IsNullOrWhiteSpace(status.Text) || string.IsNullOrWhiteSpace(date.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Subscription (Sub_ID, Student_ID, Payment_Status, Date) VALUES (@Sub_ID, @Student_ID, @Payment_Status, @Date)",
                    con);
                cmd.Parameters.AddWithValue("@Sub_ID", subid.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_ID", stuid.Text.Trim());
                cmd.Parameters.AddWithValue("@Payment_Status", status.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", date.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Subscription added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                subid.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subid.Text) ||
        string.IsNullOrWhiteSpace(stuid.Text) ||
        string.IsNullOrWhiteSpace(status.Text) || string.IsNullOrWhiteSpace(date.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(subid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Subscription SET Student_ID=@Student_ID, Payment_Status=@Payment_Status, Date=@Date WHERE Sub_ID=@Sub_ID",
                    con);

                cmd.Parameters.AddWithValue("@Sub_ID", id);
                cmd.Parameters.AddWithValue("@Student_ID", stuid.Text.Trim());
                cmd.Parameters.AddWithValue("@Payment_Status", status.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", date.Value);


                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Subscription updated successfully!", "Success",
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

        private void subsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subsDGV.CurrentRow != null)
            {
                subid.Text = subsDGV.CurrentRow.Cells[0].Value.ToString();
                stuid.Text = subsDGV.CurrentRow.Cells[1].Value.ToString();
                status.Text = subsDGV.CurrentRow.Cells[2].Value.ToString();
                date.Value = Convert.ToDateTime(subsDGV.CurrentRow.Cells[3].Value);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subid.Text))
            {
                MessageBox.Show("⚠️ Please select a Subscription first!", "Warning",
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
                    "DELETE FROM Subscription WHERE Sub_ID=@Sub_ID", con);

                cmd.Parameters.AddWithValue("@Sub_ID", subid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Subscription deleted successfully!");

                LoadData();

                subid.Clear();
               date.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
