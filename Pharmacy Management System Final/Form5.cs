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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=final pms");

        

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

             e.Graphics.DrawString("Pharmacy Management System", new Font("Arial", 42, FontStyle.Regular), Brushes.Black, new Point(0,0));
           

             e.Graphics.DrawString(" ---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 100));

             e.Graphics.DrawString("Bill No         : " + textBox4.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40,200));
             e.Graphics.DrawString("Bill Date       : " + dateTimePicker1.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40,250));
             e.Graphics.DrawString("Customer Name   : " + textBox5.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40,300));

            

             e.Graphics.DrawString("Medicine Name   : " + textBox1.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 350));
             e.Graphics.DrawString("ID              : " + textBox9.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 400));
             e.Graphics.DrawString("Batch No        : " + textBox8.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 450));
             e.Graphics.DrawString("Category        : " + textBox7.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 500));
             e.Graphics.DrawString("Quantity        : " + textBox2.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 550));

             

             e.Graphics.DrawString("Price           : " + textBox3.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 600));
             e.Graphics.DrawString("Total Price     : " + textBox6.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 650));
             e.Graphics.DrawString("Issued By       : " + textBox10.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 700));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);

            textBox6.Text = total.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `sales`";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;


        }

        private void printPreview_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `sales` VALUES ('"+ textBox4.Text +"','"+ dateTimePicker1.Text +"','"+ textBox5.Text +"','"+ textBox1.Text +"','"+ textBox9.Text +"','"+ textBox8.Text +"', '"+ textBox7.Text +"','"+ textBox2.Text +"','"+ textBox3.Text +"','"+ textBox6.Text +"','"+ textBox10.Text +"')", con);
            cmd.ExecuteNonQuery();







            MessageBox.Show("Succesful");
           
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "delete from `sales` where ID = '"+ textBox9.Text +"'";
            MySqlDataAdapter md = new MySqlDataAdapter(cmd, con);
            md.SelectCommand.ExecuteNonQuery();
            con.Close();
            Form5 d = new Form5();
            d.Show();
            d.Refresh();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
