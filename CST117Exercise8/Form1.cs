using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFat_Click(object sender, EventArgs e) 
        {
            //tests whether the input is a double
            double test4Double;
            //if invalid input
            if (!double.TryParse(textBox1.Text, out test4Double))
            {
                MessageBox.Show("Enter valid integer.");
                textBox1.Text = " ";
                textBox1.Focus();
            }
            //when valid input
            else 
            {
                textBox1.Text = Convert.ToString(FatCalories(test4Double));
            }
        }

        private void buttonCarbs_Click(object sender, EventArgs e) 
        {
            //tests whether the input is a double
            double test4Double;
            //if invalid input
            if (!double.TryParse(textBox2.Text, out test4Double))
            {
                MessageBox.Show("Enter valid integer.");
                textBox2.Text = " ";
                textBox2.Focus();
            }
            //when valid input
            else 
            {
                textBox2.Text = Convert.ToString(CarbCalories(test4Double));
            }
        }
        //converts fat grams to calories
        public double FatCalories(double fatGrams) 
        {
            return fatGrams * 9.0;
        }
        //converts carbohydrates to calories
        public double CarbCalories(double carbGrams) 
        {
            return carbGrams * 4.0;
        }

        private void OutputLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
