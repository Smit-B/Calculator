using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int v1, v2,v3;
         char sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnone_Click(object sender, EventArgs e)
        {
           
            txtdisplay.Text = txtdisplay.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
           
            txtdisplay.Text = txtdisplay.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "0";
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            v1=Convert.ToInt32(txtdisplay.Text);
            sign = '+';
            txtdisplay.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {

            v1=Convert.ToInt32(txtdisplay.Text);
            sign = '-';
            txtdisplay.Text = "";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {

          v1= Convert.ToInt32(txtdisplay.Text);
            sign = '*';
            txtdisplay.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {

            v1=Convert.ToInt32(txtdisplay.Text);
            sign = '/';
            txtdisplay.Text = "";
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            v2=Convert.ToInt32(txtdisplay.Text);
            int result;

            if (sign == '+')
            {
                result = v1 + v2;
                txtdisplay.Text = Convert.ToString(result);
            }
            if (sign == '-')
            {
                result = v1 - v2;
                txtdisplay.Text = Convert.ToString(result);
            }
            if (sign == '*')
            {
                result = v1 * v2;
                txtdisplay.Text = Convert.ToString(result);
            }
            if (sign == '/')
            {
                if (v2 != 0)
                {
                    result = v1 / v2;
                    txtdisplay.Text = Convert.ToString(result);
                }
                else
                {
                    MessageBox.Show("can't div 0");               
                }
            }
            
       

        }

        private void btnsqu_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtdisplay.Text);
            v2 = Convert.ToInt32(txtdisplay.Text);
            txtdisplay.Text = (v1 * v2).ToString();
            //double v1 = Convert.ToInt32(txtdisplay.Text);
            //double sign = Math.Pow(v1,2);
            //txtdisplay.Text =  Convert.ToDouble(sign).ToString();
            
           
        }

        private void btnqua_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(txtdisplay.Text);
            v2 = Convert.ToInt32(txtdisplay.Text);
            v3 = Convert.ToInt32(txtdisplay.Text);
            txtdisplay.Text = (v1 * v2*v3).ToString();
            
            //double v1 = Convert.ToInt32(txtdisplay.Text);
            //txtdisplay.Text = Convert.ToDouble( Math.Pow(v1, 3)).ToString();
            
        }

       
    }
}
