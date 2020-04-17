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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            lblaccountname.Text = userarray.username;
            lblaccountno.Text = userarray.userstxts;
            lblBal.Text = userarray.bal.ToString();
        }

        private void btnaction_Click(object sender, EventArgs e)
        {
            
                if (rbDeposit.Checked)
                {
                    dgTransaction.Rows.Add(dgTransaction.Rows.Count + 1, txtamt.Text, "null");
                    lblBal.Text = (int.Parse(lblBal.Text) + int.Parse(txtamt.Text)).ToString();
                    txtamt.Text = "";
                    userarray.bal= Convert.ToDouble(lblBal.Text);

            }
                else if (rbWithdraw.Checked)
                {
                    if ((int.Parse(lblBal.Text) - int.Parse(txtamt.Text)) < 0)
                    {
                        MessageBox.Show("Insufficient Balance", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtamt.Text = "";
                    }
                    else
                    {
                        dgTransaction.Rows.Add(dgTransaction.Rows.Count + 1, "null", txtamt.Text);
                        lblBal.Text = (int.Parse(lblBal.Text) - int.Parse(txtamt.Text)).ToString();
                        txtamt.Text = "";
                    userarray.bal = Convert.ToDouble(lblBal.Text);
                }
                }
                else if (txtamt.Text == "") MessageBox.Show("Please enter an amount!");
                else
                    MessageBox.Show("Please Select an Option");
                txtamt.Text = "";

            }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Visible = false;
        }
    }
}
