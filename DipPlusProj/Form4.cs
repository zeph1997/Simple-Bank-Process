using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DipPlusProj
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transfer a = new Transfer();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
