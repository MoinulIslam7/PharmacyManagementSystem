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

namespace Pharmacy_Management_System_Final
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            MySqlConnection connection = new MySqlConnection(@"server=localhost;user id=root;database=final pms");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from login where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);
            DataTable t = new DataTable();
             sda.Fill(t);

            if (t.Rows[0][0].ToString() == "1")
            {
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your User Name & Password Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 d = new Form6();
            d.Show();
            d.Refresh();
            this.Hide();
        }
    }
}
