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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
            finalbal.ReadOnly = true;
            lblfrom.Text = userarray.userstxts;
            finalbal.Text = userarray.bal.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < userarray.a ; i++)
            {
                if (userarray.custarray[i].getUser()== lblfrom.Text && userarray.custarray[i].getBalance() > double.Parse(txtamt.Text) == true)
                {
                    userarray.custarray[i].fromBalance(Double.Parse(txtamt.Text));
                    finalbal.Text = userarray.custarray[i].getBalance().ToString();
                }

            }
            
            for ( int m = 0; m < userarray.a; m++)
            {
                if (userarray.custarray[m].getUser() == txtto.Text)
                {
                    userarray.custarray[m].toBalance(Double.Parse(txtamt.Text));
                }
                

            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 b = new Form4();
            b.Show() ;
            this.Hide();

        }
    }
}
