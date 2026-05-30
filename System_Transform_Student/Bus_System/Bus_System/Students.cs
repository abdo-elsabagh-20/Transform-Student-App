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
using System.Xml.Linq;

namespace Bus_System
{
    public partial class Students : Form
    {
        SqlConnection con = new SqlConnection(
           "Data Source=DESKTOP-254CQDO;Initial Catalog=BusSystem;Integrated Security=True;Encrypt=False;"
       );
        public Students()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgrid.DataSource = dt;
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

        private void Student_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textname.Text) ||
        string.IsNullOrWhiteSpace(textphone.Text) ||
        string.IsNullOrWhiteSpace(textaddress.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before adding!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Student (Student_ID,Name, Phone, Address) VALUES (@Student_ID,@Name, @Phone, @Address)",
                    con);
                cmd.Parameters.AddWithValue("@Student_ID", textid.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", textname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", textphone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", textaddress.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();

                textid.Clear();
                textname.Clear();
                textphone.Clear();
                textaddress.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textid.Text) ||
        string.IsNullOrWhiteSpace(textname.Text) ||
        string.IsNullOrWhiteSpace(textphone.Text) ||
        string.IsNullOrWhiteSpace(textaddress.Text))
            {
                MessageBox.Show("⚠️ Please fill all fields before updating!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textid.Text, out int id))
            {
                MessageBox.Show("⚠️ ID must be a valid number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Student SET Name=@Name, Phone=@Phone, Address=@Address WHERE Student_ID=@Student_ID",
                    con);

                cmd.Parameters.AddWithValue("@Student_ID", id);
                cmd.Parameters.AddWithValue("@Name", textname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", textphone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", textaddress.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Student updated successfully!", "Success",
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
        private void deletebutton_Click(object sender, EventArgs e)
        {


        }
        //private void searchbutton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(
        //            "SELECT * FROM Student WHERE Name LIKE @Name", con);
        //        da.SelectCommand.Parameters.AddWithValue("@Name", "%" + textname.Text + "%");
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        studentgrid.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void studentgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void studentgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentgrid.CurrentRow != null)
            {
                textid.Text = studentgrid.CurrentRow.Cells[0].Value.ToString();
                textname.Text = studentgrid.CurrentRow.Cells[1].Value.ToString();
                textphone.Text = studentgrid.CurrentRow.Cells[2].Value.ToString();
                textaddress.Text = studentgrid.CurrentRow.Cells[3].Value.ToString();
            }

        }

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textid.Text))
            {
                MessageBox.Show("⚠️ Please select a student first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Student WHERE Student_ID=@Student_ID", con);

                cmd.Parameters.AddWithValue("@Student_ID", textid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("🗑️ Student deleted successfully!");

                LoadData();

                textid.Clear();
                textname.Clear();
                textphone.Clear();
                textaddress.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Student WHERE Student_ID LIKE @Student_ID", con);

                da.SelectCommand.Parameters.AddWithValue("@Student_ID", "%" + textid.Text.Trim() + "%");
                da.SelectCommand.Parameters.AddWithValue("@Name", "%" + textname.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                studentgrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
