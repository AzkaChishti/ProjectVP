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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'botique_ManagementDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.botique_ManagementDataSet.Payments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           paymentsBindingSource.EndEdit();
            paymentsTableAdapter.Update(botique_ManagementDataSet.Payments);

            MessageBox.Show("Sucessfully save data");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Payments", a);
            a.Open();
            SqlDataAdapter j = new SqlDataAdapter(b);
            DataTable dt = new DataTable();
            j.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("SELECT * FROM Payments WHERE Payment_ID LIKE '" + textBox1.Text + "%'", a);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
