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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botique_ManagementDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.botique_ManagementDataSet1.Items);
            // TODO: This line of code loads data into the 'botique_ManagementDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.botique_ManagementDataSet.Items);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemsBindingSource.EndEdit();
            itemsTableAdapter.Update(botique_ManagementDataSet.Items);

            MessageBox.Show("Sucessfully save data");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Items", a);
            a.Open();
            SqlDataAdapter j = new SqlDataAdapter(b);
            DataTable dt = new DataTable();
            j.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           itemsBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Items WHERE item_Name LIKE '" + textBox1.Text + "%'", a);
            a.Open();
            SqlDataAdapter j = new SqlDataAdapter(b);
            DataTable dt = new DataTable();
            j.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
