// Tip Calculator (Done by Anand Sinha)
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        public TipCalculator()
        {
            InitializeComponent();
        }
        
        // Checks exceptions if any, in case of no exception it calculates the Tip and Total amount per person.
        private void Update(object sender, EventArgs e)
        {
            try
            {

                // If any input box is left empty a persistent warning label is displayed "Please don't leave input(s) blank.".
                if (String.IsNullOrEmpty(inpTotalPeople.Text) || String.IsNullOrEmpty(inpTip.Text) || String.IsNullOrEmpty(inpAmount.Text))
                {
                    lblWarning.Text = "Please don't leave input(s) blank.";
                }

                // If user inputs total people as 0 a message box pops up stating number should not be 0 and sets the input value as 1.
                else if (Convert.ToInt32(inpTotalPeople.Text) == 0)
                {
                    MessageBox.Show("\"Number of people\" can't be 0!");
                    inpTotalPeople.Text = "1";
                    lblWarning.Text = "";
                }

                // If user inputs tip% more than 100% a persistent warning label is displayed ensuring that user has not done any mistake.
                else if (Convert.ToDouble(inpTip.Text) > 100 && inpAmount.Text!="0.00")
                {
                    lblWarning.Text = "Tip exceeding bill amount!";
                    CalculateAmount(sender, e);
                }

                // If every input has valid numbers we calculate the Tip and Amount per person.
                else
                {
                    CalculateAmount(sender, e);
                    lblWarning.Text = "";
                }
            }

            // In case of any other exception a message box will pop up telling about the error occured and all the values will reset.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inpAmount.Text = "0.00";
                inpTip.Text = "10";
                inpTotalPeople.Text = "1";
            }
        }

        // Checks if the value entered by user is a digit and not a character
        private void DigitCheck(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            // input 8, 46, 3, 22, 1 are for allowing backspace, delete, Ctrl+C, Ctrl+V and Ctrl+A inputs.
            if (!Char.IsDigit(input) && input != 8 && input != 46 && input != 3 && input != 22 && input != 1)
            {
                lblWarning.Text = "Please input a number only.";
                e.Handled = true;
            }
        }

        /* Checks if a user leaves any input as empty and moves to another input even after persistent warning label was displayed.
           If Yes a message box will pop up notifying user about the mistake.
           Whichever input was left empty will reset to its lowest possible value */
        private void NullCheck(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inpTotalPeople.Text) || String.IsNullOrEmpty(inpTip.Text) || String.IsNullOrEmpty(inpAmount.Text))
            {
                MessageBox.Show("Please don't leave input(s) blank.");

                // Checking which input was left empty and resetting its value.
                if (String.IsNullOrEmpty(inpTotalPeople.Text))
                    inpTotalPeople.Text = "1";

                else if (String.IsNullOrEmpty(inpTip.Text))
                    inpTip.Text = "0";

                else
                    inpAmount.Text = "0.00";
            }

            // If input is not left empty call is transfered to Update function to check for any other exception.
            else
            {
                Update(sender, e);
                // Sets and outputs Amount input into price format.
                inpAmount.Text = string.Format("{0:#,##0.00}", double.Parse(inpAmount.Text));
            }
        }

        // A function that calculates Tip and Amount per person and displays it.
        private void CalculateAmount(object sender, EventArgs e)
        {
            double tipPerPerson = Convert.ToDouble(inpTip.Text) / 100;
            double amountPerPerson = Convert.ToDouble(inpAmount.Text) / Convert.ToDouble(inpTotalPeople.Text);
            string tipShareString = Convert.ToString(amountPerPerson * tipPerPerson);
            string totalPerPerson = Convert.ToString((amountPerPerson + Convert.ToDouble(tipShareString)));
            // Sets and outputs amounts into price format.
            lblTipOut.Text = '$' + string.Format("{0:#,#00.00}", double.Parse(tipShareString));
            lblTotalOut.Text = '$' + string.Format("{0:#,000.00}", double.Parse(totalPerPerson));
        }

        // Increments tip%/No of people by 1.
        private void IncrementValue(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnIncrTip")
            {
                int tip = Convert.ToInt16(inpTip.Text);
                inpTip.Text = (++tip).ToString();
            }
            else
            {
                int people = Convert.ToInt32(inpTotalPeople.Text);
                inpTotalPeople.Text = (++people).ToString();
            }
        }

        // Decrements tip%/No of people by 1.
        private void DecrementValue(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnDecrTip")
            {
                int tip = Convert.ToInt16(inpTip.Text);
                if (tip > 0)
                    inpTip.Text = (--tip).ToString();
            }
            else
            {
                int people = Convert.ToInt32(inpTotalPeople.Text);
                if (people > 1)
                    inpTotalPeople.Text = (--people).ToString();
            }
        }


        // UI Customizations
        /* As there are no border to windows form in our case
           Adding a Close button and Minimize button for user.*/
        
        // On mouse hover label will turn red with gray background.
        private void OnHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Gainsboro;
            lbl.ForeColor = Color.LightCoral;
        }
        // On mouse leave label will reset back to its orignal state.
        private void OnLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.DarkGray;
        }

        // On close label click the app will exit.
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // On minimize label click app will minimize.
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}