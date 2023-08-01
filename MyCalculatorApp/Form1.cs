using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_add_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {


                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;
                label4.Text = result.ToString();
                label4.Visible = true;
                // MessageBox.Show("Addition resule is "+result.ToString());

            }else
            {
                MessageBox.Show("Please Fill the fields");
            }
        }

        private void cal_sub_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result=num1 - num2;
            MessageBox.Show("Subtarction is "+ result.ToString());

        }

        private void cal_mul_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;
            MessageBox.Show("Multiplication is " + result.ToString());
        }

        private void Cal_div_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1/ num2;
            MessageBox.Show("Division is " + result.ToString());
        }
    }
}
