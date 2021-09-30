using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            text2.Enabled = false;
            text3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if (double.TryParse(text1.Text,out double result))
            {
                button1.Enabled = true;
            }
           if(double.TryParse (text1.Text,out double result2))
            {
                double totalBill = double.Parse(text1.Text) * 0.2;
                text2.Text = "" + totalBill.ToString();
                text3.Text = "" + (double.Parse(text1.Text) + totalBill).ToString();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
