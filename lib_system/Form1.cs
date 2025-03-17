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
    public partial class Form1: Form
    {
        public Form1()
        {

            InitializeComponent();
            string mysqlCon = "server=127.0.0.1;user=root;database=library_db;password=";
            MySqlConnection con = new MySqlConnection(mysqlCon);    

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void Library_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
