using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lib_system
{
    public partial class member : Form
    {
        string selectedMemberId = "";

        public member()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            SAVE.Click += SAVE_Click;
            DELETE.Click += DELETE_Click;
        }

        private void back3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 back = new Form2();
            back.ShowDialog();
        }

        public void Member_lib()
        {
            string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM tbl_member";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }

            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["member_id"].ReadOnly = true;
        }

        private void member_Load(object sender, EventArgs e)
        {
            Member_lib();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedMemberId = row.Cells["member_id"].Value.ToString();
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMemberId))
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                string firstname = row.Cells["firstname"].Value?.ToString();
                string lastname = row.Cells["lastname"].Value?.ToString();
                string middlename = row.Cells["middlename"].Value?.ToString();
                string course = row.Cells["course"].Value?.ToString();
                string year = row.Cells["year"].Value?.ToString();

                string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"UPDATE tbl_member 
                                     SET firstname = @firstname, lastname = @lastname, middlename = @middlename, 
                                         course = @course, year = @year 
                                     WHERE member_id = @member_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@middlename", middlename);
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@member_id", selectedMemberId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Member updated successfully.");
                Member_lib();
                ReselectRow(selectedMemberId);
            }
            else
            {
                MessageBox.Show("Please select a member to save changes.");
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMemberId))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM tbl_member WHERE member_id = @member_id";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@member_id", selectedMemberId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Member deleted successfully.");
                    Member_lib();
                    selectedMemberId = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }

        private void ReselectRow(string memberId)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells["member_id"].Value.ToString() == memberId)
                {
                    r.Selected = true;
                    dataGridView1.CurrentCell = r.Cells[0];
                    break;
                }
            }
        }
    }
}