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
    public partial class Form8 : Form
    {
        
        public Form8()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");
        public string user="", pass="";
        private void button1_Click(object sender, EventArgs e)
        {
             user = textBox1.Text;
             pass = textBox2.Text;
            MySqlConnection connection = new MySqlConnection(@"server=localhost;user id=root;database=final pms");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from employee where Name = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);
            DataTable t = new DataTable();
            sda.Fill(t);

            if (t.Rows[0][0].ToString() == "1")
            {
                Form2 f = new Form2();
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
            Form2 fk = new Form2();
            fk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f1 = new Form10();
            f1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
