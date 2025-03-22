using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lib_system
{
    public partial class borrow : Form
    {
        string selectedBorrowId = "";

        public borrow()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            Delete.Click += Delete_Click;
        }

        private void back4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 back = new Form2();
            back.ShowDialog();
        }

        public void Borrow_lib()
        {
            string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT borrow_id, borrow_date, return_date, book_id, member_id FROM tbl_borrowingrecords ORDER BY borrow_id ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }

            dataGridView1.ReadOnly = true;
        }

        private void borrow_Load(object sender, EventArgs e)
        {
            Borrow_lib();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedBorrowId = row.Cells["borrow_id"].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedBorrowId))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this borrowing record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM tbl_borrowingrecords WHERE borrow_id = @borrow_id";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@borrow_id", selectedBorrowId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Borrowing record deleted successfully.");
                    Borrow_lib();
                    selectedBorrowId = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
    }
}
