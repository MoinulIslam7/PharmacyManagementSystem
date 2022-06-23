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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `customer`";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer`(`ID`, `Name`, `Address`, `Mobile`, `Email`) VALUES ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();







            MessageBox.Show("Succesful");
            con.Close();
            Form4 d = new Form4();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "delete from `customer` where ID = '" + textBox6.Text + "'";
            MySqlDataAdapter md = new MySqlDataAdapter(cmd, con);
            md.SelectCommand.ExecuteNonQuery();
            con.Close();
            Form4 d = new Form4();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 d = new Form4();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
