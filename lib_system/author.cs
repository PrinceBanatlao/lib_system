using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lib_system
{
    public partial class author: Form
    {
        public author()
        {
            InitializeComponent();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 back = new Form2();
            back.ShowDialog();

        }
        public void Author_lib()
        {
            string connectionString = "server=127.0.0.1; Database=library_db; Uid=root; Pwd=;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM tbl_author";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }
       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void author_Load(object sender, EventArgs e)
        {
            Author_lib();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

