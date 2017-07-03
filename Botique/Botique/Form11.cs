using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Botique
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botique_ManagementDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.botique_ManagementDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(botique_ManagementDataSet.Customers);

            MessageBox.Show("Sucessfully save data");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Customers", a);
            a.Open();
            SqlDataAdapter j = new SqlDataAdapter(b);
            DataTable dt = new DataTable();
            j.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Customers WHERE Customer_Name LIKE '" + textBox1.Text + "%'", a);
            a.Open();
            SqlDataAdapter j = new SqlDataAdapter(b);
            DataTable dt = new DataTable();
            j.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           customersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
