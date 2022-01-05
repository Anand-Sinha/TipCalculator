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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_tip_add = new System.Windows.Forms.Button();
            this.btn_tip_sub = new System.Windows.Forms.Button();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lbl_no_of_people = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.total_pp = new System.Windows.Forms.Label();
            this.tip_pp = new System.Windows.Forms.Label();
            this.pp_label2 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.pp_label1 = new System.Windows.Forms.Label();
            this.tip_pp_label = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.pnl_division.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_division
            // 
            this.pnl_division.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_division.Controls.Add(this.lbl_no_of_people);
            this.pnl_division.Controls.Add(this.button1);
            this.pnl_division.Controls.Add(this.button2);
            this.pnl_division.Controls.Add(this.textBox2);
            this.pnl_division.Controls.Add(this.lbl_tip);
            this.pnl_division.Controls.Add(this.btn_tip_sub);
            this.pnl_division.Controls.Add(this.btn_tip_add);
            this.pnl_division.Controls.Add(this.textBox1);
            this.pnl_division.Controls.Add(this.lbl_amount);
            this.pnl_division.Controls.Add(this.inp_tip);
            this.pnl_division.Location = new System.Drawing.Point(-10, -5);
            this.pnl_division.Name = "pnl_division";
            this.pnl_division.Size = new System.Drawing.Size(281, 274);
            this.pnl_division.TabIndex = 0;
            // 
            // inp_tip
            // 
            this.inp_tip.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_tip.Location = new System.Drawing.Point(27, 53);
            this.inp_tip.Name = "inp_tip";
            this.inp_tip.Size = new System.Drawing.Size(231, 36);
            this.inp_tip.TabIndex = 0;
            this.inp_tip.Text = "00.00";
            this.inp_tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 36);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "10%";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_tip_add
            // 
            this.btn_tip_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tip_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tip_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_tip_add.FlatAppearance.BorderSize = 10;
            this.btn_tip_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tip_add.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tip_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_tip_add.Location = new System.Drawing.Point(222, 126);
            this.btn_tip_add.Name = "btn_tip_add";
            this.btn_tip_add.Size = new System.Drawing.Size(36, 36);
            this.btn_tip_add.TabIndex = 5;
            this.btn_tip_add.Text = "+";
            this.btn_tip_add.UseVisualStyleBackColor = false;
            // 
            // btn_tip_sub
            // 
            this.btn_tip_sub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tip_sub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tip_sub.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_tip_sub.FlatAppearance.BorderSize = 10;
            this.btn_tip_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tip_sub.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tip_sub.ForeColor = System.Drawing.Color.Gray;
            this.btn_tip_sub.Location = new System.Drawing.Point(27, 126);
            this.btn_tip_sub.Name = "btn_tip_sub";
            this.btn_tip_sub.Size = new System.Drawing.Size(36, 36);
            this.btn_tip_sub.TabIndex = 6;
            this.btn_tip_sub.Text = "-";
            this.btn_tip_sub.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(27, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(222, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(62, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 36);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "10%";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_pp
            // 
            this.total_pp.AutoSize = true;
            this.total_pp.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_pp.Location = new System.Drawing.Point(482, 148);
            this.total_pp.Name = "total_pp";
            this.total_pp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_pp.Size = new System.Drawing.Size(150, 45);
            this.total_pp.TabIndex = 23;
            this.total_pp.Text = "$000.00";
            this.total_pp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tip_pp
            // 
            this.tip_pp.AutoSize = true;
            this.tip_pp.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_pp.Location = new System.Drawing.Point(498, 82);
            this.tip_pp.Name = "tip_pp";
            this.tip_pp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tip_pp.Size = new System.Drawing.Size(134, 43);
            this.tip_pp.TabIndex = 22;
            this.tip_pp.Text = "$00.00";
            this.tip_pp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pp_label2
            // 
            this.pp_label2.AutoSize = true;
            this.pp_label2.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp_label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pp_label2.Location = new System.Drawing.Point(300, 178);
            this.pp_label2.Name = "pp_label2";
            this.pp_label2.Size = new System.Drawing.Size(78, 17);
            this.pp_label2.TabIndex = 21;
            this.pp_label2.Text = "per person";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(298, 150);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(62, 28);
            this.total_label.TabIndex = 20;
            this.total_label.Text = "Total";
            // 
            // pp_label1
            // 
            this.pp_label1.AutoSize = true;
            this.pp_label1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp_label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pp_label1.Location = new System.Drawing.Point(300, 108);
            this.pp_label1.Name = "pp_label1";
            this.pp_label1.Size = new System.Drawing.Size(78, 17);
            this.pp_label1.TabIndex = 19;
            this.pp_label1.Text = "per person";
            // 
            // tip_pp_label
            // 
            this.tip_pp_label.AutoSize = true;
            this.tip_pp_label.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_pp_label.Location = new System.Drawing.Point(298, 80);
            this.tip_pp_label.Name = "tip_pp_label";
            this.tip_pp_label.Size = new System.Drawing.Size(44, 28);
            this.tip_pp_label.TabIndex = 18;
            this.tip_pp_label.Text = "Tip";
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
            this.minimize.Location = new System.Drawing.Point(620, 8);
            this.minimize.Name = "minimize";
            this.minimize.Padding = new System.Windows.Forms.Padding(2);
            this.minimize.Size = new System.Drawing.Size(20, 21);
            this.minimize.TabIndex = 25;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 267);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.total_pp);
            this.Controls.Add(this.tip_pp);
            this.Controls.Add(this.pp_label2);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.pp_label1);
            this.Controls.Add(this.tip_pp_label);
            this.Controls.Add(this.pnl_division);
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
        private System.Windows.Forms.TextBox inp_tip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button btn_tip_sub;
        private System.Windows.Forms.Button btn_tip_add;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Label lbl_no_of_people;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label total_pp;
        private System.Windows.Forms.Label tip_pp;
        private System.Windows.Forms.Label pp_label2;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label pp_label1;
        private System.Windows.Forms.Label tip_pp_label;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
    }
}

