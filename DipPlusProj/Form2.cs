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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelpemail.Visible = false;
            pemail.Visible = false;
            cnorms.Visible = false;
            HNW.Visible = false;
            
        }
        
        private void backlogin_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            
            this.Close();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtype.SelectedIndex.Equals(0))
            {
                labelpemail.Visible = true;
                pemail.Visible = true;
                cnorms.Visible = false;
                HNW.Visible = false;
            }
            else if (mtype.SelectedIndex.Equals(1))
            {
                labelpemail.Visible = false;
                pemail.Visible = false;
                cnorms.Visible = true;
                HNW.Visible = false;
            }
            else if (mtype.SelectedIndex.Equals(2))
            {
                labelpemail.Visible = false;
                pemail.Visible = false;
                cnorms.Visible = false;
                HNW.Visible = true;
            }
        }

        public int i = 5;
        public void signbtn_Click(object sender, EventArgs e)
        {
            if (mtype.SelectedIndex == 0) { 
                userarray.custarray[i] = new UEight(user.Text, pass2.Text, name.Text, 0,pemail.Text);
            }
            else if (mtype.SelectedIndex == 1)
            {
                if (Ncc.Checked == true)
                {
                    userarray.custarray[i] = new Ncustomer(user.Text, pass2.Text, name.Text, 0, 0);
                }
                else
                {
                    userarray.custarray[i] = new Ncustomer(user.Text, pass2.Text, name.Text, 0, 1);
                } 
            }
            else if (mtype.SelectedIndex == 2)
            {
                if (blackradio.Checked == true)
                {
                    userarray.custarray[i] = new Highnet(user.Text, pass2.Text, name.Text, 0, 0);
                }
                else
                {
                    userarray.custarray[i] = new Highnet(user.Text, pass2.Text, name.Text, 0, 1);
                }
            }
            i++;
            userarray.a++;
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
