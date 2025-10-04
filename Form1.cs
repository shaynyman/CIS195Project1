using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Shayna Nyman
//Project1
//09/28/25


namespace Project1
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void SixMonthAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable to hold Value of Investment.
                double ValueOfInvestment;

                //Calculate Value of Investment.
                ValueOfInvestment = double.Parse(originalInvestmentAmountTextBox.Text) +
                (double.Parse(annualRateOfReturnTextBox.Text) / 2);

                //Display Value of Investment.
                amountOfInvestOutputLabel.Text = ValueOfInvestment.ToString("c");
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message);
            }
        }




        private void OneYearAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable to hold value of investment at 1 year.
                double ValueOfInvestment1;

                //Calculate Value of Investment.
                ValueOfInvestment1 = double.Parse(originalInvestmentAmountTextBox.Text) +
                double.Parse(annualRateOfReturnTextBox.Text);

                //Display Value of Investment.
                amountOfInvestOutputLabel.Text = ValueOfInvestment1.ToString("c");
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void TwoYearInvestmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable to hold Value of Investment at 2 years.
                double ValueOfInvestment;

                //Calculate Value of Investment.
                ValueOfInvestment = double.Parse(originalInvestmentAmountTextBox.Text) +
                (double.Parse(annualRateOfReturnTextBox.Text)) * 2;

                //Display Value of Investment.
                amountOfInvestOutputLabel.Text = ValueOfInvestment.ToString("c");
            }
            catch (Exception ex)
            {
                    //Display Error Message
                    MessageBox.Show(ex.Message);
                }
            }
        private void FiveYearInvestmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable to hold Value of Investment.
                double ValueOfInvestment;

                //Calculate Value of Investment.
                ValueOfInvestment = double.Parse(originalInvestmentAmountTextBox.Text) +
                (double.Parse(annualRateOfReturnTextBox.Text)) * 5;

                //Display Value of Investment.
                amountOfInvestOutputLabel.Text = ValueOfInvestment.ToString("c");
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message);
            }
            }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes.
            originalInvestmentAmountTextBox.Text = "";
            annualRateOfReturnTextBox.Text = "";

            //Clear the OutputLabel.
            amountOfInvestOutputLabel.Text = "";

            //Set the focus.
            originalInvestmentAmountTextBox.Focus();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }   
}