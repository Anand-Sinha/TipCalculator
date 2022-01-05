using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double tip_fraction = Convert.ToDouble(inp_tip.Text)/100;
            double amount_per_person = Convert.ToDouble(inp_amount.Text) / Convert.ToDouble(inp_total_people.Text);
            double tip_share = amount_per_person * tip_fraction;
            string tip_share_string = tip_share.ToString();
            string total_per_person = Convert.ToString((amount_per_person + tip_share));
            lbl_tip_out.Text = '$' + string.Format("{0:#,##0.00}", double.Parse(tip_share_string));
            lbl_total_out.Text = '$' + string.Format("{0:#,##0.00}", double.Parse(total_per_person));
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

        private void btn_tip_add_Click(object sender, EventArgs e)
        {
            update(sender, e);
        }

        private void inp_amount_Leave(object sender, EventArgs e)
        {
            inp_amount.Text = string.Format("{0:#,##0.00}", double.Parse(inp_amount.Text));
        }

        private void inp_tip_Leave(object sender, EventArgs e)
        {
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
