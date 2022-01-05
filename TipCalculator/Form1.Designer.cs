namespace TipCalculator
{
    partial class TipCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_division = new System.Windows.Forms.Panel();
            this.inp_tip = new System.Windows.Forms.TextBox();
            this.lbl_no_of_people = new System.Windows.Forms.Label();
            this.btn_decr_people = new System.Windows.Forms.Button();
            this.btn_incr_people = new System.Windows.Forms.Button();
            this.inp_total_people = new System.Windows.Forms.TextBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_decr_tip = new System.Windows.Forms.Button();
            this.btn_incr_tip = new System.Windows.Forms.Button();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.inp_amount = new System.Windows.Forms.TextBox();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.lbl_total_out = new System.Windows.Forms.Label();
            this.lbl_tip_out = new System.Windows.Forms.Label();
            this.lbl_pp2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_pp1 = new System.Windows.Forms.Label();
            this.lbl_tip_pp = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.pnl_inp_tip = new System.Windows.Forms.Panel();
            this.pnl_division.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_division
            // 
            this.pnl_division.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_division.Controls.Add(this.inp_tip);
            this.pnl_division.Controls.Add(this.lbl_no_of_people);
            this.pnl_division.Controls.Add(this.btn_decr_people);
            this.pnl_division.Controls.Add(this.btn_incr_people);
            this.pnl_division.Controls.Add(this.inp_total_people);
            this.pnl_division.Controls.Add(this.lbl_tip);
            this.pnl_division.Controls.Add(this.btn_decr_tip);
            this.pnl_division.Controls.Add(this.btn_incr_tip);
            this.pnl_division.Controls.Add(this.lbl_amount);
            this.pnl_division.Controls.Add(this.inp_amount);
            this.pnl_division.Controls.Add(this.lbl_percent);
            this.pnl_division.Controls.Add(this.pnl_inp_tip);
            this.pnl_division.Location = new System.Drawing.Point(-10, -5);
            this.pnl_division.Name = "pnl_division";
            this.pnl_division.Size = new System.Drawing.Size(281, 274);
            this.pnl_division.TabIndex = 0;
            // 
            // inp_tip
            // 
            this.inp_tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inp_tip.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_tip.Location = new System.Drawing.Point(66, 130);
            this.inp_tip.MaxLength = 3;
            this.inp_tip.Name = "inp_tip";
            this.inp_tip.Size = new System.Drawing.Size(83, 29);
            this.inp_tip.TabIndex = 2;
            this.inp_tip.Text = "10";
            this.inp_tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inp_tip.TextChanged += new System.EventHandler(this.update);
            this.inp_tip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitCheck);
            this.inp_tip.Leave += new System.EventHandler(this.nullCheck);
            // 
            // lbl_no_of_people
            // 
            this.lbl_no_of_people.AutoSize = true;
            this.lbl_no_of_people.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_of_people.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_no_of_people.Location = new System.Drawing.Point(24, 179);
            this.lbl_no_of_people.Name = "lbl_no_of_people";
            this.lbl_no_of_people.Size = new System.Drawing.Size(124, 17);
            this.lbl_no_of_people.TabIndex = 11;
            this.lbl_no_of_people.Text = "Number of people";
            // 
            // btn_decr_people
            // 
            this.btn_decr_people.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_decr_people.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_decr_people.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_decr_people.FlatAppearance.BorderSize = 10;
            this.btn_decr_people.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decr_people.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decr_people.ForeColor = System.Drawing.Color.Gray;
            this.btn_decr_people.Location = new System.Drawing.Point(27, 199);
            this.btn_decr_people.Name = "btn_decr_people";
            this.btn_decr_people.Size = new System.Drawing.Size(36, 36);
            this.btn_decr_people.TabIndex = 4;
            this.btn_decr_people.Text = "-";
            this.btn_decr_people.UseVisualStyleBackColor = false;
            this.btn_decr_people.Click += new System.EventHandler(this.btn_decr_people_Click);
            // 
            // btn_incr_people
            // 
            this.btn_incr_people.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_incr_people.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_incr_people.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_incr_people.FlatAppearance.BorderSize = 10;
            this.btn_incr_people.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incr_people.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incr_people.ForeColor = System.Drawing.Color.Gray;
            this.btn_incr_people.Location = new System.Drawing.Point(222, 199);
            this.btn_incr_people.Name = "btn_incr_people";
            this.btn_incr_people.Size = new System.Drawing.Size(36, 36);
            this.btn_incr_people.TabIndex = 6;
            this.btn_incr_people.Text = "+";
            this.btn_incr_people.UseVisualStyleBackColor = false;
            this.btn_incr_people.Click += new System.EventHandler(this.btn_incr_people_Click);
            // 
            // inp_total_people
            // 
            this.inp_total_people.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_total_people.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_total_people.Location = new System.Drawing.Point(62, 199);
            this.inp_total_people.MaxLength = 6;
            this.inp_total_people.Name = "inp_total_people";
            this.inp_total_people.Size = new System.Drawing.Size(161, 36);
            this.inp_total_people.TabIndex = 5;
            this.inp_total_people.Text = "1";
            this.inp_total_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inp_total_people.TextChanged += new System.EventHandler(this.update);
            this.inp_total_people.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitCheck);
            this.inp_total_people.Leave += new System.EventHandler(this.nullCheck);
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_tip.Location = new System.Drawing.Point(24, 106);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(44, 17);
            this.lbl_tip.TabIndex = 7;
            this.lbl_tip.Text = "Tip %";
            // 
            // btn_decr_tip
            // 
            this.btn_decr_tip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_decr_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_decr_tip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_decr_tip.FlatAppearance.BorderSize = 10;
            this.btn_decr_tip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decr_tip.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decr_tip.ForeColor = System.Drawing.Color.Gray;
            this.btn_decr_tip.Location = new System.Drawing.Point(27, 126);
            this.btn_decr_tip.Name = "btn_decr_tip";
            this.btn_decr_tip.Size = new System.Drawing.Size(36, 36);
            this.btn_decr_tip.TabIndex = 1;
            this.btn_decr_tip.Text = "-";
            this.btn_decr_tip.UseVisualStyleBackColor = false;
            this.btn_decr_tip.Click += new System.EventHandler(this.btn_decr_tip_Click);
            // 
            // btn_incr_tip
            // 
            this.btn_incr_tip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_incr_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_incr_tip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_incr_tip.FlatAppearance.BorderSize = 10;
            this.btn_incr_tip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incr_tip.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incr_tip.ForeColor = System.Drawing.Color.Gray;
            this.btn_incr_tip.Location = new System.Drawing.Point(222, 126);
            this.btn_incr_tip.Name = "btn_incr_tip";
            this.btn_incr_tip.Size = new System.Drawing.Size(36, 36);
            this.btn_incr_tip.TabIndex = 3;
            this.btn_incr_tip.Text = "+";
            this.btn_incr_tip.UseVisualStyleBackColor = false;
            this.btn_incr_tip.Click += new System.EventHandler(this.btn_incr_tip_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_amount.Location = new System.Drawing.Point(24, 33);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(27, 17);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Text = "Bill";
            // 
            // inp_amount
            // 
            this.inp_amount.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_amount.Location = new System.Drawing.Point(27, 53);
            this.inp_amount.MaxLength = 8;
            this.inp_amount.Name = "inp_amount";
            this.inp_amount.Size = new System.Drawing.Size(231, 36);
            this.inp_amount.TabIndex = 0;
            this.inp_amount.Text = "0.00";
            this.inp_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inp_amount.TextChanged += new System.EventHandler(this.update);
            this.inp_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_amount_KeyPress);
            this.inp_amount.Leave += new System.EventHandler(this.nullCheck);
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent.Location = new System.Drawing.Point(146, 130);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_percent.Size = new System.Drawing.Size(33, 28);
            this.lbl_percent.TabIndex = 26;
            this.lbl_percent.Text = "%";
            this.lbl_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total_out
            // 
            this.lbl_total_out.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_out.Location = new System.Drawing.Point(366, 148);
            this.lbl_total_out.Name = "lbl_total_out";
            this.lbl_total_out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_total_out.Size = new System.Drawing.Size(298, 45);
            this.lbl_total_out.TabIndex = 23;
            this.lbl_total_out.Text = "$000.00";
            this.lbl_total_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tip_out
            // 
            this.lbl_tip_out.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip_out.Location = new System.Drawing.Point(362, 82);
            this.lbl_tip_out.Name = "lbl_tip_out";
            this.lbl_tip_out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tip_out.Size = new System.Drawing.Size(302, 43);
            this.lbl_tip_out.TabIndex = 22;
            this.lbl_tip_out.Text = "$00.00";
            this.lbl_tip_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pp2
            // 
            this.lbl_pp2.AutoSize = true;
            this.lbl_pp2.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pp2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_pp2.Location = new System.Drawing.Point(300, 178);
            this.lbl_pp2.Name = "lbl_pp2";
            this.lbl_pp2.Size = new System.Drawing.Size(78, 17);
            this.lbl_pp2.TabIndex = 21;
            this.lbl_pp2.Text = "per person";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(298, 150);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 28);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "Total";
            // 
            // lbl_pp1
            // 
            this.lbl_pp1.AutoSize = true;
            this.lbl_pp1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pp1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_pp1.Location = new System.Drawing.Point(300, 108);
            this.lbl_pp1.Name = "lbl_pp1";
            this.lbl_pp1.Size = new System.Drawing.Size(78, 17);
            this.lbl_pp1.TabIndex = 19;
            this.lbl_pp1.Text = "per person";
            // 
            // lbl_tip_pp
            // 
            this.lbl_tip_pp.AutoSize = true;
            this.lbl_tip_pp.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip_pp.Location = new System.Drawing.Point(298, 80);
            this.lbl_tip_pp.Name = "lbl_tip_pp";
            this.lbl_tip_pp.Size = new System.Drawing.Size(44, 28);
            this.lbl_tip_pp.TabIndex = 18;
            this.lbl_tip_pp.Text = "Tip";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.White;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.DarkGray;
            this.close.Location = new System.Drawing.Point(646, 9);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2);
            this.close.Size = new System.Drawing.Size(22, 21);
            this.close.TabIndex = 24;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.DarkGray;
            this.minimize.Location = new System.Drawing.Point(623, 8);
            this.minimize.Name = "minimize";
            this.minimize.Padding = new System.Windows.Forms.Padding(2);
            this.minimize.Size = new System.Drawing.Size(20, 21);
            this.minimize.TabIndex = 25;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // pnl_inp_tip
            // 
            this.pnl_inp_tip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_inp_tip.Location = new System.Drawing.Point(62, 126);
            this.pnl_inp_tip.Name = "pnl_inp_tip";
            this.pnl_inp_tip.Size = new System.Drawing.Size(161, 36);
            this.pnl_inp_tip.TabIndex = 26;
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 267);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lbl_pp2);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_pp1);
            this.Controls.Add(this.lbl_tip_pp);
            this.Controls.Add(this.pnl_division);
            this.Controls.Add(this.lbl_total_out);
            this.Controls.Add(this.lbl_tip_out);
            this.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TipCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.pnl_division.ResumeLayout(false);
            this.pnl_division.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_division;
        private System.Windows.Forms.TextBox inp_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button btn_decr_tip;
        private System.Windows.Forms.Button btn_incr_tip;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_no_of_people;
        private System.Windows.Forms.Button btn_decr_people;
        private System.Windows.Forms.Button btn_incr_people;
        private System.Windows.Forms.TextBox inp_total_people;
        private System.Windows.Forms.Label lbl_total_out;
        private System.Windows.Forms.Label lbl_tip_out;
        private System.Windows.Forms.Label lbl_pp2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_pp1;
        private System.Windows.Forms.Label lbl_tip_pp;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.TextBox inp_tip;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Panel pnl_inp_tip;
    }
}

