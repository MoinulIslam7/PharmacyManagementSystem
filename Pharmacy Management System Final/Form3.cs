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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");
 
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "delete from `employee` where ID = '" + textBox6.Text + "'";
            MySqlDataAdapter md = new MySqlDataAdapter(cmd, con);
            md.SelectCommand.ExecuteNonQuery();
            con.Close();
            Form3 d = new Form3();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `employee` VALUES ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')", con);
            cmd.ExecuteNonQuery();



            MessageBox.Show("Succesful");
            con.Close();
            Form3 d = new Form3();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `employee` SET `ID`='"+ textBox6.Text +"',`Address`='"+ textBox2.Text +"',`Mobile`='"+ textBox3.Text +"',`Email`='"+ textBox4.Text +"' WHERE `Name`='"+ textBox1.Text +"';", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updation Successful");

            con.Close();

            Form3 d = new Form3();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 d = new Form3();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `employee`";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            d.Refresh();
            this.Hide();
        }
    }
}
