using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 8)
            {
                if (lblDisplay.Text == "0")
                    lblDisplay.Text = ((Button)sender).Text;
                else
                    lblDisplay.Text += ((Button)sender).Text;
            }
            else
                lblDisplay.Text = lblDisplay.Text;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            ch = 0;
            check = '&';
            result = 0;
            hold = 0;
        }

        int ch =0;
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = lblDisplay.Text + ".";
            }
            else
            {
                if (ch == 0)
                {
                    lblDisplay.Text = lblDisplay.Text+".";
                    ch = 1;
                }
                else
                    lblDisplay.Text = lblDisplay.Text;
            }
        }

        double result=0;
        char check = '&';
        double hold = 0;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            check = '+';
            ch = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            check = '-';
            ch = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            check = '*';
            ch = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            check = '/';
            ch = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double equal = Double.Parse(lblDisplay.Text);
            if (check == '+')
                result += equal;
            else if (check == '-')
                result -= equal;
            else if (check == '*')
                result *= equal;
            else if (check == '/')
                result /= equal;
            else if (check == '0')
                result = equal;
    
            else if (check == '&')
            {
                result = Double.Parse(lblDisplay.Text);
            }
            if (result.ToString().Length <= 8) 
                lblDisplay.Text = result.ToString();
            else
                lblDisplay.Text = "Error";
        }

       
        private void btnPercent_Click(object sender, EventArgs e)
        {


            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = Convert.ToString(result * result / 100);
            }
            else
            {
                 hold = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = Convert.ToString(result * ( hold / 100));
            }
        }

       
        private void btnSign_Click(object sender, EventArgs e)
        {
            result = Double.Parse(lblDisplay.Text)*-1;
            lblDisplay.Text = result.ToString();;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length == 1)
                lblDisplay.Text = "0"; 
            
            else
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
        }
    }
}