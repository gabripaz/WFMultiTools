using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFOOPProject
{
    public partial class SimpleCalc : Form
    {
        public SimpleCalc()
        {
            InitializeComponent();
        }
        Calculator Calc = new Calculator();
        public void AddtoVisor(string valuetoadd)
        {
            txtVisor.Text += valuetoadd;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Simple Calculator?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddtoVisor(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddtoVisor(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddtoVisor(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddtoVisor(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddtoVisor(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddtoVisor(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddtoVisor(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddtoVisor(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddtoVisor(button9.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddtoVisor(button0.Text);
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            AddtoVisor(btndot.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            Calc.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Calc.Add(Convert.ToDecimal(txtVisor.Text));
                txtVisor.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please only numbers are valid. Ex: 12.34" + ex.Message);
                txtVisor.Focus();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Calc.Subtract(Convert.ToDecimal(txtVisor.Text));
                txtVisor.Text = "";
                //txtVisor.Text = Convert.ToString((float)Calc.CurrentValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please only numbers are valid. Ex: 12.34" + ex.Message);
                txtVisor.Focus();
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                Calc.Multiply(Convert.ToDecimal(txtVisor.Text));
                txtVisor.Text = "";
                //txtVisor.Text = Convert.ToString((float)Calc.CurrentValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please only numbers are valid. Ex: 12.34" + ex.Message);
                txtVisor.Focus();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                Calc.Divide(Convert.ToDecimal(txtVisor.Text));
                txtVisor.Text = "";
                //txtVisor.Text = Convert.ToString((float)Calc.CurrentValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please only numbers are valid. Ex: 12.34" + ex.Message);
                txtVisor.Focus();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            { 
                Calc.Equals(Convert.ToDecimal(txtVisor.Text));
                txtVisor.Text = Convert.ToString((float)Calc.CurrentValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                txtVisor.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) btndot.Text = ",";
            else btndot.Text = ".";
        }
    }

    class Calculator
    {
        private string op = null;
        private decimal operand1 = 0;
        private decimal operand2 = 0;
        private decimal currentValue = 0;

        public decimal CurrentValue { get; set; }

        public void Clear()
        {
            operand1 = operand2 = CurrentValue = 0;
            op = null;
        }

        public void Add(decimal displayValue)
        {
            op = "+";            
            operand1 = CurrentValue = displayValue;
        }
        public void Subtract(decimal displayValue)
        {
            op = "-";
            operand1 = CurrentValue = displayValue;
        }
        public void Multiply(decimal displayValue)
        {
            op = "*";
            operand1 = CurrentValue = displayValue;
        }
        public void Divide(decimal displayValue)
        {
            op = "/";
            operand1 = CurrentValue = displayValue;
        }
        public void Equals()
        {
            switch (op)
            {
                case "+":
                    operand1 += operand2;
                    break;
                case "-":
                    operand1 -= operand2;
                    break;
                case "*":
                    operand1 *= operand2;
                    break;
                case "/":
                    operand1 /= operand2;
                    break;
            }
            CurrentValue = operand1;
        }
        public void Equals (decimal displayValue)
        {
            operand2 = CurrentValue = displayValue;
            Equals();
        }
    }
}
