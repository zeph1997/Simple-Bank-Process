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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createrandom a = new createrandom();
            double card_val = a.createrandomnumber();
            label2.Text = card_val.ToString("f2");
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            double store;
            store = double.Parse(label2.Text);
            store += 10;
            label2.Text = store.ToString();
            MessageBox.Show("You have successfully top up $10, your new balance on the card is $"+store);


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

    }
}
