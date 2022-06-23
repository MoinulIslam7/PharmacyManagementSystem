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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");
        int count = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `medicine`";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `medicine`(`ID`, `Name`, `Batch No`, `Category`, `Quantity`, `Price`, `Manufactured Date`, `Expired Date`) VALUES ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text+ "','" + textBox5.Text + "', '" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Succesful");
            con.Close();
            Form2 d = new Form2();
            d.Show();
            d.Refresh();
            this.Hide();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "delete from `medicine` where ID = '" + textBox6.Text + "'";
            MySqlDataAdapter md = new MySqlDataAdapter(cmd, con);
            md.SelectCommand.ExecuteNonQuery();
            con.Close();
            Form2 d = new Form2();
            d.Show();
            d.Refresh();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            string selectquery = "SELECT * FROM `medicine` WHERE Name= '" + textBox1.Text + "'";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            
            dataGridView1.DataSource = t;
          
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
            s.Refresh();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form4 d = new Form4();
            d.Show();
            d.Refresh();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `medicine` SET `ID`='"+textBox6.Text+"',`Batch No`='"+ textBox2.Text +"',`Category`='"+ textBox3.Text +"',`Quantity`='"+ textBox4.Text +"',`Price`='"+ textBox5.Text +"',`Manufactured Date`='"+ dateTimePicker1.Text +"',`Expired Date`='"+ dateTimePicker2.Text +"' WHERE `Name`='"+ textBox1.Text +"';", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updation Successful");
            
            con.Close();

            Form2 d = new Form2();
            d.Show();
            d.Refresh();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
