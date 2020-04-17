using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;


namespace DipPlusProj
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            
            InitializeComponent();
            coe1.Focus();
            btnplot.Visible = false;
            lblcoe.Text = "0.00";
            lblcpf.Text = "0.00";
            lblpua.Text = "0.00";
            lblia.Text = "0.00";
            lbllia.Text = "0.00";

            lblcoe1.Text = "0.00";
            lblcpf1.Text = "0.00";
            lblpua1.Text = "0.00";
            lblia1.Text = "0.00";
            lbllia1.Text = "0.00";
            lblassets.Text = "0.00";
            lbllia2.Text = "0.00"; 
            lblnetworth.Text = "0.00";
        }

        private void btncal_Click(object sender, EventArgs e)
        {

            if (coe1.Text == "")
                coe1.Text = "0.00";
            if (coe2.Text == "")
                coe2.Text = "0.00";
            if (coe3.Text == "")
                coe3.Text = "0.00";
            if (coe4.Text == "")
                coe4.Text = "0.00";
            if (cpf1.Text == "")
                cpf1.Text = "0.00";
            if (cpf2.Text == "")
                cpf2.Text = "0.00";
            if (cpf3.Text == "")
                cpf3.Text = "0.00";
            if (pua1.Text == "")
                pua1.Text = "0.00";
            if (pua2.Text == "")
                pua2.Text = "0.00";
            if (pua3.Text == "")
                pua3.Text = "0.00";
            if (ia1.Text == "")
                ia1.Text = "0.00";
            if (ia2.Text == "")
                ia2.Text = "0.00";
            if (ia3.Text == "")
                ia3.Text = "0.00";
            if (lia1.Text == "")
                lia1.Text = "0.00";
            if (lia2.Text == "")
                lia2.Text = "0.00";
            if (lia3.Text == "")
                lia3.Text = "0.00";
            if (lia4.Text == "")
                lia4.Text = "0.00";
            if (lia5.Text == "")
                lia5.Text = "0.00";


            NetWorthFormulas a = new NetWorthFormulas(Convert.ToDouble(coe1.Text), Convert.ToDouble(coe2.Text), Convert.ToDouble(coe3.Text), Convert.ToDouble(coe4.Text),
                                                      Convert.ToDouble(cpf1.Text), Convert.ToDouble(cpf2.Text), Convert.ToDouble(cpf3.Text),
                                                      Convert.ToDouble(pua1.Text), Convert.ToDouble(pua2.Text), Convert.ToDouble(pua3.Text),
                                                      Convert.ToDouble(ia1.Text), Convert.ToDouble(ia2.Text), Convert.ToDouble(ia3.Text),
                                                      Convert.ToDouble(lia1.Text), Convert.ToDouble(lia2.Text), Convert.ToDouble(lia3.Text), Convert.ToDouble(lia4.Text), Convert.ToDouble(lia5.Text));

            


            lblcoe.Text=a.totalcoe().ToString("f2");
            lblcpf.Text=a.totalcpf().ToString("f2");
            lblpua.Text = a.totalpua().ToString("f2");
            lblia.Text = a.totallia().ToString("f2");
            lbllia.Text = a.totallia().ToString("f2");           
            lblcoe1.Text = lblcoe.Text;
            lblcpf1.Text = lblcpf.Text;
            lblpua1.Text = lblpua.Text;
            lblia1.Text = lblia.Text;
            lbllia1.Text = lbllia.Text;
            lbllia2.Text = lbllia.Text;
            lblassets.Text = a.totalassets().ToString("f2");
            lblnetworth.Text = a.networth().ToString("f2");


            btnplot.Visible = true;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            coe1.Focus();
            lblcoe.Text = "0.00";
            lblcpf.Text = "0.00";
            lblpua.Text = "0.00";
            lblia.Text = "0.00";
            lbllia.Text = "0.00";

            lblcoe1.Text = "0.00";
            lblcpf1.Text = "0.00";
            lblpua1.Text = "0.00";
            lblia1.Text = "0.00";
            lbllia1.Text = "0.00";
            lblassets.Text = "0.00";
            lbllia2.Text = "0.00";
            lblnetworth.Text = "0.00";

            coe1.Text="";
            coe2.Text = "";
            coe3.Text = "";
            coe4.Text = "";
            cpf1.Text = "";
            cpf2.Text = "";
            cpf3.Text = "";
            pua1.Text = "";
            pua2.Text = "";
            pua3.Text = "";
            ia1.Text = "";
            ia2.Text = "";
            ia3.Text = "";
            lia1.Text = "";
            lia2.Text = "";
            lia3.Text = "";
            lia4.Text = "";
            lia5.Text = "";

            btnplot.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetWorthPieChart a = new NetWorthPieChart();
            a.Show();
            a.piechart.Titles.Add("INDIVIDUAL's ASSETS IN PERCENTAGE");
            a.piechart.BackColor = Color.White;
            a.piechart.ChartAreas[0].BackColor = Color.LightYellow;
            a.piechart.Series.Add("Net Worth");
            a.piechart.Series["Net Worth"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            a.piechart.Series["Net Worth"].Points.AddXY("CASH OR EQUIVALENT", Convert.ToDouble(lblcoe.Text));
            a.piechart.Series["Net Worth"].Points.AddXY("CPF SAVINGS", Convert.ToDouble(lblcpf.Text));
            a.piechart.Series["Net Worth"].Points.AddXY("PERSONAL USE ASSETS", Convert.ToDouble(lblpua.Text));
            a.piechart.Series["Net Worth"].Points.AddXY("INVESTED ASSETS", Convert.ToDouble(lblia.Text));
            a.piechart.Series["Net Worth"].IsVisibleInLegend = false;
            a.piechart.Series["Net Worth"].Label = "#VALX\n#PERCENT";
            a.piechart.Series["Net Worth"].LabelForeColor = System.Drawing.Color.Black;
            a.piechart.Series["Net Worth"]["PieLabelStyle"] = "Outside";            
            a.piechart.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void coe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void coe2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void coe3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void coe4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cpf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cpf2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cpf3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ia1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ia3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pua1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pua2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pua3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lia1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lia3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lia4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please key in only numeric values");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Visible = false;
        }
    }
}
