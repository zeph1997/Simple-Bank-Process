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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userarray.custarray[0] = new Customer("S1234567A", "a", "Sean Tan", 50000);
            userarray.custarray[1] = new Customer("S1234567B", "a", "Zeph Ng", 30000);
            userarray.custarray[2] = new Customer("S1234567C", "a", "Marcus Lee Eugene", 150000);
            userarray.custarray[3] = new Customer("S1234567D", "a", "Samuel Lim", 70000);
            userarray.custarray[4] = new Customer("S1234567E", "a", "Kuah Zheng Xuan", 20000);

        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (usertxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Please fill in the textboxes");
            }
            else
            {

                if (userarray.a > 0)
                {
                    for (i = 0; i < userarray.a; i++)
                    {

                        if (usertxt.Text == userarray.custarray[i].getUser() && passtxt.Text == userarray.custarray[i].getPass())
                        {
                            MessageBox.Show("Login Successful" + ", " + userarray.custarray[i].getNames());
                            Form3 a = new Form3();
                            a.Show();
                            this.Visible = false;

                            userarray.bal = userarray.custarray[i].getBalance();
                            userarray.username = userarray.custarray[i].getNames();
                            userarray.userstxts = usertxt.Text;
                            break;
                        }
                    }

                    if (i == userarray.a)
                    {

                        MessageBox.Show("Either there is no such account or the account credentials were invalid!");
                        usertxt.Text = "";
                        passtxt.Text = "";
                    }


                }

            }
            }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

