using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;


namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            listoOperator();
        }

        public void listoOperator()
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUpper.Text) || String.IsNullOrEmpty(txtDown.Text))
            {
                MessageBox.Show("Please fill in the blank");
            }
            else if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select operator");
            }
            else
            {
                float num1 = Convert.ToInt64(txtUpper.Text);
                float num2 = Convert.ToInt64(txtDown.Text);

                if (cbOperator.SelectedItem.ToString() == "+")
                {
                    float add = Basic_Computation.Addition(num1, num2);
                    lblDisplayTotal.Text = add.ToString();
                }
                else if (cbOperator.SelectedItem.ToString() == "-")
                {
                    float sub = Basic_Computation.Subtraction(num1, num2);
                    lblDisplayTotal.Text = sub.ToString();
                }
                else if (cbOperator.SelectedItem.ToString() == "*")
                {
                    float multi = Basic_Computation.Multiplication(num1, num2);
                    lblDisplayTotal.Text = multi.ToString();
                }
                else if (cbOperator.SelectedItem.ToString() == "/")
                {
                    float divi = Basic_Computation.Division(num1, num2);
                    lblDisplayTotal.Text = divi.ToString();
                }
            }
        }

        private void txtUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
            }
        }

        private void txtDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
            }
        }
    }
}
