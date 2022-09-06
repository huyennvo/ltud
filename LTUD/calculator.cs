using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD
{
    public partial class calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public calculator()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if((kq.Text == "0") || (operation_pressed)) kq.Clear();
            operation_pressed = false;
            Button temp = (Button)sender;
            if(temp.Text == ".")
            {
                if(!kq.Text.Contains("."))
                    kq.Text = kq.Text + temp.Text;
            }
            else kq.Text = kq.Text + temp.Text;
            
        }

        private void operator_btn(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            if(value != 0 )
            {   if (currentVal.Text != "")
                {
                    button16.PerformClick();
                }
                operation = temp.Text;
                operation_pressed = true;
                currentVal.Text = value + " " + operation;
                kq.Clear();
            }
            else
            {
                operation = temp.Text;
                value = Double.Parse(kq.Text);
                kq.Clear();
                currentVal.Text = value + " " + operation;
                operation_pressed = true;
            }
          /*  operation = temp.Text;
            value = Double.Parse(kq.Text);
            kq.Clear();
            currentVal.Text = value + " " + operation;
            operation_pressed = true;*/
        }

        private void equal(object sender, EventArgs e)
        {
            currentVal.Text = "";
            switch(operation)
            {
                case "+":
                    kq.Text = (value + Double.Parse(kq.Text)).ToString();
                    break;
                case "-":
                    kq.Text = (value - Double.Parse(kq.Text)).ToString();
                    break ;
                case "×":
                    kq.Text = (value * Double.Parse(kq.Text)).ToString();
                    break;
                case "÷":
                    kq.Text = (value / Double.Parse(kq.Text)).ToString();
                    break;
                case "%":
                    kq.Text = (value / 100).ToString();
                    break;
                default:
                    break;
            }
            /*if(operation == "%") operation_pressed = true;
            else
            {
                operation_pressed = false;
            }*/
            operation_pressed = false;
            value = Double.Parse(kq.Text);
            //currentVal.Text = " ";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kq.Text = "0";
            value = 0;
            currentVal.Text = " ";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            kq.Text = "0";
            
        }

        private void currentVal_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kq.Text = (- Double.Parse(kq.Text)).ToString(); 
            
        }

        private void percent(object sender, EventArgs e)
        {
            kq.Text = (Double.Parse(kq.Text)/100).ToString();
        }
    }
}
