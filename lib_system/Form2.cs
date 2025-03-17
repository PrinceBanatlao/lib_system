using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib_system
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            author author = new author();
            author.ShowDialog();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            book book = new book();
            book.ShowDialog();

               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            member member = new member();
            member.ShowDialog();
        }

        private void borrow_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            borrow borrow = new borrow();
            borrow.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.ShowDialog();

        }
    }
}
