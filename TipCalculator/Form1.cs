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
