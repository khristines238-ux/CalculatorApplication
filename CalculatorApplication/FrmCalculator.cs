using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private readonly Calculator cal = new Calculator();

        
        public FrmCalculator()
        {
            InitializeComponent();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

       private void BtnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            double result = 0;

            

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    result = cal.Add(num1, num2);
                    break;
                case "-":
                    result = cal.Subtract(num1, num2);
                    break;
                case "*":
                    result= cal.Multiply(num1, num2);
                    break;
                case "/":
                    result = cal.Divide(num1, num2);
                    break;

            }

            lblDisplayTotal.Text = result.ToString();
        }
          
        public void Form1_Load(object sender, EventArgs e)
        {
            

            
            
        }

        private void BtnEqual_Click1(object sender, EventArgs e)
        {

        }
    }
}
