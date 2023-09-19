using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        double enterValue1, enterValue2;
        String op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enterValue1 = Convert.ToDouble(textBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterNums(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (textBox.Text == "0")
                textBox.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!textBox.Text.Contains("."))  //add a decimal point to textBox if already not there
                    {
                        textBox.Text = textBox.Text + num.Text;
                    }
                }
                else
                {
                    textBox.Text = textBox.Text + num.Text;  //adding the clicked button's digit to textBox
                }
            }
            
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterValue1 = Convert.ToDouble(textBox.Text);
            op = num.Text;
            textBox.Text = "";

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterValue2 = Convert.ToDouble(textBox.Text);
            switch (op) { 
                case "+":
                    textBox.Text = (enterValue1 + enterValue2).ToString();
                    break;

                case "-":
                    textBox.Text = (enterValue1 - enterValue2).ToString();
                    break;

                case "*":
                    textBox.Text = (enterValue1 * enterValue2).ToString();
                    break;

                case "/":
                    textBox.Text = (enterValue1 / enterValue2).ToString();
                    break;

                default:

                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

            String firstNum, secondNum;
            firstNum = Convert.ToString(enterValue1);
            secondNum = Convert.ToString(enterValue2);

            firstNum = "";
            secondNum = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBox.Text);
            textBox.Text = Convert.ToString(-1 * val);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0) {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }

            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }
    }
}
