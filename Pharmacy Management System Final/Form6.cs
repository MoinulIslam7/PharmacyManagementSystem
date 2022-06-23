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
    public partial class Form6 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");

        public Form6()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("update `login` SET `password`='"+ textBox2.Text +"' WHERE `username`='"+ textBox1.Text +"' and email='"+ textBox3.Text +"';", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updation Successful");

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
