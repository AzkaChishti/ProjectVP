using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botique
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Azka Fareed";
            textBox2.Text = "12345";
            textBox2.PasswordChar = '*';
            if (textBox1.Text == "Azka Fareed" && textBox2.Text == "12345")
            {
                this.Hide();
                Form1 fr = new Form1();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid user name and password");
            }

           
        }
    }
}
