using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0, MemoryStore=0 ;
        String operationPerformed = "";
        bool isOperationPerformed = false;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void button20_Click(object sender, EventArgs e)    
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "0";
        }


       

        private void button15_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            textBox_Result.Text = textBox_Result.Text + "9";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                equalSign.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }

            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void equalSign_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void MR(object sender, EventArgs e)
        {
            textBox_Result.Text = this.MemoryStore.ToString();
            return;
        }

        private void MC(object sender, EventArgs e)
        {
            this.MemoryStore = 0;
            return;
        }

       /* private void MPlu(object sender, EventArgs e)
        {
            MemoryStore += Double.Parse(textBox_Result.Text).ToString();
            return;
        }*/

        private void sqr_Click(object sender, EventArgs e)
        {
            var result = Math.Sqrt((double)resultValue);
        }

        private void MMin(object sender, EventArgs e)
        {

        }
    }
}
