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

        void update(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(inp_total_people.Text) || String.IsNullOrEmpty(inp_tip.Text) || String.IsNullOrEmpty(inp_amount.Text)){}
                else if (Convert.ToInt16(inp_tip.Text) < 0)
                {
                    MessageBox.Show("Please input \"Tip %\" as a positive integer.");
                    inp_tip.Text = "0";
                }
                else if (Convert.ToInt32(inp_total_people.Text) == 0)
                {
                    MessageBox.Show("\"Number of people\" can't be 0!");
                    inp_total_people.Text = "1";
                }
                else
                {
                    double tip_per_person = Convert.ToDouble(inp_tip.Text) / 100;
                    double amount_per_person = Convert.ToDouble(inp_amount.Text) / Convert.ToDouble(inp_total_people.Text);
                    string tip_share_string = Convert.ToString(amount_per_person * tip_per_person);
                    string total_per_person = Convert.ToString((amount_per_person + Convert.ToDouble(tip_share_string)));
                    lbl_tip_out.Text = '$' + string.Format("{0:#,#00.00}", double.Parse(tip_share_string));
                    lbl_total_out.Text = '$' + string.Format("{0:#,000.00}", double.Parse(total_per_person));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inp_amount.Text = "0.00";
                inp_tip.Text = "10";
                inp_total_people.Text = "1";
            }
        }

        void nullCheck(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inp_total_people.Text) || String.IsNullOrEmpty(inp_tip.Text) || String.IsNullOrEmpty(inp_amount.Text))
            {
                MessageBox.Show("Please don't leave input(s) blank.");
                inp_amount.Text = "0.00";
                inp_tip.Text = "10";
                inp_total_people.Text = "1";
            }
            else
            {
                update(sender, e);
                inp_amount.Text = string.Format("{0:#,##0.00}", double.Parse(inp_amount.Text));
            }
        }
        void digitCheck(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void inp_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
            }
        }

        private void btn_incr_tip_Click(object sender, EventArgs e)
        {
            int tip = Convert.ToInt16(inp_tip.Text);
            inp_tip.Text = (++tip).ToString();
        }

        private void btn_decr_tip_Click(object sender, EventArgs e)
        {
            int tip = Convert.ToInt16(inp_tip.Text);
            if(tip > 0)
                inp_tip.Text = (--tip).ToString();
        }

        private void btn_incr_people_Click(object sender, EventArgs e)
        {
            int people = Convert.ToInt32(inp_total_people.Text);
            inp_total_people.Text = (++people).ToString();
        }

        private void btn_decr_people_Click(object sender, EventArgs e)
        {
            int people = Convert.ToInt32(inp_total_people.Text);
            if (people > 1)
                inp_total_people.Text = (--people).ToString();
        }
        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = Color.Gainsboro;
            close.ForeColor = Color.LightCoral;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.White;
            close.ForeColor = Color.DarkGray;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.BackColor = Color.Gainsboro;
            minimize.ForeColor = Color.DeepSkyBlue;
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.White;
            minimize.ForeColor = Color.DarkGray;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
