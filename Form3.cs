using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class nameFormatter : Form
    {
        public nameFormatter()
        {
            InitializeComponent();
        }

        private void titleFirstMidLastButton_Click(object sender, EventArgs e)
        {
            //Declares a string variable to hold formatted name.
            string titleFirstMidLast;

            //Combine the names with a space in between. Assign 
            //the result to the titleFirstMidLast variable.
            titleFirstMidLast = titleTextBox.Text + " " + firstNameTextBox.Text + 
            " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;

            //Show the titleFirstMidLast variable in the nameOutputLabel control.
            nameOutputLabel.Text = titleFirstMidLast;
        }

        private void firstMidLastButton_Click(object sender, EventArgs e)
        {
            //Declares a string variable to hold the formatted name.
            string firstMidLast;

            //Combine the names with spacing in between. Assign
            //the result to the firstMidLast variable.
            firstMidLast = firstNameTextBox.Text + " " + middleNameTextBox.Text +
            " " + lastNameTextBox.Text;

            //Show the firstMidLast variable in the nameOutputLabel control.
            nameOutputLabel.Text = firstMidLast;
        }

        private void firstLastButton_Click(object sender, EventArgs e)
        {
            //Declares a string variable to hold the formatted name.
            string firstLast;

            //Combine the names with spacing in between. Assign
            //the result to the firstLast variable.
            firstLast = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            //Show the firstLast variable in the nameOutputLabel control.
            nameOutputLabel.Text = firstLast;
        }

        private void lastFirstMidButon_Click(object sender, EventArgs e)
        {
            //Declares a string variable to hold the formatted name.
            string lastFirstMid;

            //Combine the names with spacing in between. Assign the
            //result to the lastFirstMid variable.
            lastFirstMid = lastNameTextBox.Text + "," + firstNameTextBox.Text +
            " " + middleNameTextBox.Text;

            //Show the lastFirstMid variable in the nameOutputLabel control.
            nameOutputLabel.Text = lastFirstMid;
        }

        private void lastFirstButton_Click(object sender, EventArgs e)
        {
            //Declares a variable to hold the formatted name.
            string lastFirst;

            //Combine the names with spacing in between. Assign the
            //result to the lastFirst variable.
            lastFirst = lastNameTextBox.Text + "," + firstNameTextBox.Text;

            //Show the lastFirst variable in the nameOutputLabel control.
            nameOutputLabel.Text = lastFirst;

        }

        private void lastFirstMidTitleButton_Click(object sender, EventArgs e)
        {
            //Declares a variable to hold the formatted name.
            string lastFirstMidTitle;

            //Combine the names with spacing in between. Assign the 
            //result to the lastFirstMidTitle variable.
            lastFirstMidTitle = lastNameTextBox.Text + "," + firstNameTextBox.Text +
            " " + middleNameTextBox.Text + "," + titleTextBox.Text;

            //Show the lastFirstMidTitle variable in the nameOutputLabel control.
            nameOutputLabel.Text = lastFirstMidTitle;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
