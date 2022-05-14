using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 sf = new Form3();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 sf = new Form4();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 sf = new Form5();
            sf.Show();
        }
    }
}
