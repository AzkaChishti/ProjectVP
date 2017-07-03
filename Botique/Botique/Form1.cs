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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Form5 ff = new Form5();
           ff.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 o = new Form4();
            o.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Form5 f=new Form5();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fo = new Form6();
            fo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 ff = new Form17();
            ff.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form18 fr = new Form18();
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
