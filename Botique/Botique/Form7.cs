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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Data Source=.;Initial Catalog=Botique Management;Integrated Security=True");
            SqlCommand b = new SqlCommand("INSERT INTO New_Arrivals(ItemName,ItemId,ArrivalDate,Quantity) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", a);
            a.Open();
            SqlDataAdapter h = new SqlDataAdapter(b);
            h.SelectCommand.ExecuteNonQuery();
            a.Close();
            MessageBox.Show("Sucessfully Data saved");
        }
    }
}
