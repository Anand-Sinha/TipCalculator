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

        private void Update(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inpTotalPeople.Text) || String.IsNullOrEmpty(inpTip.Text) || String.IsNullOrEmpty(inpAmount.Text)) { }
                else if (Convert.ToInt16(inpTip.Text) < 0)
                {
                    MessageBox.Show("Please input \"Tip %\" as a positive integer.");
                    inpTip.Text = "0";
                }
                else if (Convert.ToInt32(inpTotalPeople.Text) == 0)
                {
                    MessageBox.Show("\"Number of people\" can't be 0!");
                    inpTotalPeople.Text = "1";
                }
                else
                {
                    double tip_per_person = Convert.ToDouble(inpTip.Text) / 100;
                    double amount_per_person = Convert.ToDouble(inpAmount.Text) / Convert.ToDouble(inpTotalPeople.Text);
                    string tip_share_string = Convert.ToString(amount_per_person * tip_per_person);
                    string total_per_person = Convert.ToString((amount_per_person + Convert.ToDouble(tip_share_string)));
                    lblTipOut.Text = '$' + string.Format("{0:#,#00.00}", double.Parse(tip_share_string));
                    lblTotalOut.Text = '$' + string.Format("{0:#,000.00}", double.Parse(total_per_person));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inpAmount.Text = "0.00";
                inpTip.Text = "10";
                inpTotalPeople.Text = "1";
            }
        }
        private void NullCheck(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inpTotalPeople.Text) || String.IsNullOrEmpty(inpTip.Text) || String.IsNullOrEmpty(inpAmount.Text))
            {
                MessageBox.Show("Please don't leave input(s) blank.");
                inpAmount.Text = "0.00";
                inpTip.Text = "10";
                inpTotalPeople.Text = "1";
            }
            else
            {
                Update(sender, e);
                inpAmount.Text = string.Format("{0:#,##0.00}", double.Parse(inpAmount.Text));
            }
        }

        private void DigitCheck(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void inpAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void btnIncrTip_Click(object sender, EventArgs e)
        {
            int tip = Convert.ToInt16(inpTip.Text);
            inpTip.Text = (++tip).ToString();
        }

        private void btnDecrTip_Click(object sender, EventArgs e)
        {
            int tip = Convert.ToInt16(inpTip.Text);
            if (tip > 0)
                inpTip.Text = (--tip).ToString();
        }

        private void btnIncrPeople_Click(object sender, EventArgs e)
        {
            int people = Convert.ToInt32(inpTotalPeople.Text);
            inpTotalPeople.Text = (++people).ToString();
        }

        private void btnDecrPeople_Click(object sender, EventArgs e)
        {
            int people = Convert.ToInt32(inpTotalPeople.Text);
            if (people > 1)
                inpTotalPeople.Text = (--people).ToString();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Gainsboro;
            lblClose.ForeColor = Color.LightCoral;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.White;
            lblClose.ForeColor = Color.DarkGray;
        }

        private void lblMinimize_MouseHover(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.Gainsboro;
            lblMinimize.ForeColor = Color.DeepSkyBlue;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.White;
            lblMinimize.ForeColor = Color.DarkGray;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
