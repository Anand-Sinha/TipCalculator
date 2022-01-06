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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipCalculator));
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.inpTip = new System.Windows.Forms.TextBox();
            this.lblNoOfPeople = new System.Windows.Forms.Label();
            this.btnDecrPeople = new System.Windows.Forms.Button();
            this.btnIncrPeople = new System.Windows.Forms.Button();
            this.inpTotalPeople = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnDecrTip = new System.Windows.Forms.Button();
            this.btnIncrTip = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.inpAmount = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.pnl_inp_tip = new System.Windows.Forms.Panel();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.lblTipOut = new System.Windows.Forms.Label();
            this.lblPP2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPP1 = new System.Windows.Forms.Label();
            this.lblTipPP = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDivision
            // 
            this.pnlDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDivision.Controls.Add(this.lblWarning);
            this.pnlDivision.Controls.Add(this.icon);
            this.pnlDivision.Controls.Add(this.lblHeading);
            this.pnlDivision.Controls.Add(this.inpTip);
            this.pnlDivision.Controls.Add(this.lblNoOfPeople);
            this.pnlDivision.Controls.Add(this.btnDecrPeople);
            this.pnlDivision.Controls.Add(this.btnIncrPeople);
            this.pnlDivision.Controls.Add(this.inpTotalPeople);
            this.pnlDivision.Controls.Add(this.lblTip);
            this.pnlDivision.Controls.Add(this.btnDecrTip);
            this.pnlDivision.Controls.Add(this.btnIncrTip);
            this.pnlDivision.Controls.Add(this.lblBill);
            this.pnlDivision.Controls.Add(this.inpAmount);
            this.pnlDivision.Controls.Add(this.lblPercent);
            this.pnlDivision.Controls.Add(this.pnl_inp_tip);
            this.pnlDivision.Location = new System.Drawing.Point(-10, -5);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(281, 286);
            this.pnlDivision.TabIndex = 0;
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(15, 258);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(259, 15);
            this.lblWarning.TabIndex = 27;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(15, 9);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(22, 22);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 26;
            this.icon.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.White;
            this.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeading.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHeading.Location = new System.Drawing.Point(35, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(3);
            this.lblHeading.Size = new System.Drawing.Size(93, 21);
            this.lblHeading.TabIndex = 26;
            this.lblHeading.Text = "Tip Calculator";
            // 
            // inpTip
            // 
            this.inpTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpTip.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTip.Location = new System.Drawing.Point(66, 143);
            this.inpTip.MaxLength = 4;
            this.inpTip.Name = "inpTip";
            this.inpTip.Size = new System.Drawing.Size(83, 29);
            this.inpTip.TabIndex = 3;
            this.inpTip.Text = "10";
            this.inpTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inpTip.TextChanged += new System.EventHandler(this.Update);
            this.inpTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitCheck);
            this.inpTip.Leave += new System.EventHandler(this.NullCheck);
            // 
            // lblNoOfPeople
            // 
            this.lblNoOfPeople.AutoSize = true;
            this.lblNoOfPeople.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPeople.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNoOfPeople.Location = new System.Drawing.Point(24, 194);
            this.lblNoOfPeople.Name = "lblNoOfPeople";
            this.lblNoOfPeople.Size = new System.Drawing.Size(124, 17);
            this.lblNoOfPeople.TabIndex = 11;
            this.lblNoOfPeople.Text = "Number of people";
            // 
            // btnDecrPeople
            // 
            this.btnDecrPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecrPeople.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecrPeople.FlatAppearance.BorderSize = 10;
            this.btnDecrPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrPeople.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrPeople.ForeColor = System.Drawing.Color.Gray;
            this.btnDecrPeople.Location = new System.Drawing.Point(27, 214);
            this.btnDecrPeople.Name = "btnDecrPeople";
            this.btnDecrPeople.Size = new System.Drawing.Size(36, 36);
            this.btnDecrPeople.TabIndex = 5;
            this.btnDecrPeople.Text = "-";
            this.btnDecrPeople.UseVisualStyleBackColor = false;
            this.btnDecrPeople.Click += new System.EventHandler(this.btnDecrPeople_Click);
            // 
            // btnIncrPeople
            // 
            this.btnIncrPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncrPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncrPeople.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncrPeople.FlatAppearance.BorderSize = 10;
            this.btnIncrPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncrPeople.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrPeople.ForeColor = System.Drawing.Color.Gray;
            this.btnIncrPeople.Location = new System.Drawing.Point(222, 214);
            this.btnIncrPeople.Name = "btnIncrPeople";
            this.btnIncrPeople.Size = new System.Drawing.Size(36, 36);
            this.btnIncrPeople.TabIndex = 7;
            this.btnIncrPeople.Text = "+";
            this.btnIncrPeople.UseVisualStyleBackColor = false;
            this.btnIncrPeople.Click += new System.EventHandler(this.btnIncrPeople_Click);
            // 
            // inpTotalPeople
            // 
            this.inpTotalPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpTotalPeople.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTotalPeople.Location = new System.Drawing.Point(62, 214);
            this.inpTotalPeople.MaxLength = 6;
            this.inpTotalPeople.Name = "inpTotalPeople";
            this.inpTotalPeople.Size = new System.Drawing.Size(161, 36);
            this.inpTotalPeople.TabIndex = 6;
            this.inpTotalPeople.Text = "1";
            this.inpTotalPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpTotalPeople.TextChanged += new System.EventHandler(this.Update);
            this.inpTotalPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitCheck);
            this.inpTotalPeople.Leave += new System.EventHandler(this.NullCheck);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTip.Location = new System.Drawing.Point(24, 119);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(44, 17);
            this.lblTip.TabIndex = 7;
            this.lblTip.Text = "Tip %";
            // 
            // btnDecrTip
            // 
            this.btnDecrTip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecrTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecrTip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecrTip.FlatAppearance.BorderSize = 10;
            this.btnDecrTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrTip.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrTip.ForeColor = System.Drawing.Color.Gray;
            this.btnDecrTip.Location = new System.Drawing.Point(27, 139);
            this.btnDecrTip.Name = "btnDecrTip";
            this.btnDecrTip.Size = new System.Drawing.Size(36, 36);
            this.btnDecrTip.TabIndex = 2;
            this.btnDecrTip.Text = "-";
            this.btnDecrTip.UseVisualStyleBackColor = false;
            this.btnDecrTip.Click += new System.EventHandler(this.btnDecrTip_Click);
            // 
            // btnIncrTip
            // 
            this.btnIncrTip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncrTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncrTip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncrTip.FlatAppearance.BorderSize = 10;
            this.btnIncrTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncrTip.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrTip.ForeColor = System.Drawing.Color.Gray;
            this.btnIncrTip.Location = new System.Drawing.Point(222, 139);
            this.btnIncrTip.Name = "btnIncrTip";
            this.btnIncrTip.Size = new System.Drawing.Size(36, 36);
            this.btnIncrTip.TabIndex = 4;
            this.btnIncrTip.Text = "+";
            this.btnIncrTip.UseVisualStyleBackColor = false;
            this.btnIncrTip.Click += new System.EventHandler(this.btnIncrTip_Click);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBill.Location = new System.Drawing.Point(24, 46);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(27, 17);
            this.lblBill.TabIndex = 2;
            this.lblBill.Text = "Bill";
            // 
            // inpAmount
            // 
            this.inpAmount.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAmount.Location = new System.Drawing.Point(27, 66);
            this.inpAmount.MaxLength = 8;
            this.inpAmount.Name = "inpAmount";
            this.inpAmount.Size = new System.Drawing.Size(231, 36);
            this.inpAmount.TabIndex = 1;
            this.inpAmount.Text = "0.00";
            this.inpAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inpAmount.TextChanged += new System.EventHandler(this.Update);
            this.inpAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitCheck);
            this.inpAmount.Leave += new System.EventHandler(this.NullCheck);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(146, 143);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPercent.Size = new System.Drawing.Size(33, 28);
            this.lblPercent.TabIndex = 26;
            this.lblPercent.Text = "%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_inp_tip
            // 
            this.pnl_inp_tip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_inp_tip.Location = new System.Drawing.Point(62, 139);
            this.pnl_inp_tip.Name = "pnl_inp_tip";
            this.pnl_inp_tip.Size = new System.Drawing.Size(161, 36);
            this.pnl_inp_tip.TabIndex = 26;
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOut.Location = new System.Drawing.Point(366, 156);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalOut.Size = new System.Drawing.Size(298, 45);
            this.lblTotalOut.TabIndex = 23;
            this.lblTotalOut.Text = "$000.00";
            this.lblTotalOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipOut
            // 
            this.lblTipOut.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipOut.Location = new System.Drawing.Point(362, 90);
            this.lblTipOut.Name = "lblTipOut";
            this.lblTipOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTipOut.Size = new System.Drawing.Size(302, 43);
            this.lblTipOut.TabIndex = 22;
            this.lblTipOut.Text = "$00.00";
            this.lblTipOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPP2
            // 
            this.lblPP2.AutoSize = true;
            this.lblPP2.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPP2.Location = new System.Drawing.Point(300, 186);
            this.lblPP2.Name = "lblPP2";
            this.lblPP2.Size = new System.Drawing.Size(78, 17);
            this.lblPP2.TabIndex = 21;
            this.lblPP2.Text = "per person";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(298, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 28);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // lblPP1
            // 
            this.lblPP1.AutoSize = true;
            this.lblPP1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPP1.Location = new System.Drawing.Point(300, 116);
            this.lblPP1.Name = "lblPP1";
            this.lblPP1.Size = new System.Drawing.Size(78, 17);
            this.lblPP1.TabIndex = 19;
            this.lblPP1.Text = "per person";
            // 
            // lblTipPP
            // 
            this.lblTipPP.AutoSize = true;
            this.lblTipPP.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipPP.Location = new System.Drawing.Point(298, 88);
            this.lblTipPP.Name = "lblTipPP";
            this.lblTipPP.Size = new System.Drawing.Size(44, 28);
            this.lblTipPP.TabIndex = 18;
            this.lblTipPP.Text = "Tip";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClose.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.DarkGray;
            this.lblClose.Location = new System.Drawing.Point(646, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Padding = new System.Windows.Forms.Padding(3);
            this.lblClose.Size = new System.Drawing.Size(25, 23);
            this.lblClose.TabIndex = 24;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimize.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMinimize.Location = new System.Drawing.Point(623, 5);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Padding = new System.Windows.Forms.Padding(3);
            this.lblMinimize.Size = new System.Drawing.Size(22, 23);
            this.lblMinimize.TabIndex = 25;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseHover += new System.EventHandler(this.lblMinimize_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(374, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(1, 1);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblName.Location = new System.Drawing.Point(414, 255);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 12);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Made by Anand Sinha";
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 276);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblPP2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPP1);
            this.Controls.Add(this.lblTipPP);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.lblTotalOut);
            this.Controls.Add(this.lblTipOut);
            this.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TipCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.pnlDivision.ResumeLayout(false);
            this.pnlDivision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.TextBox inpAmount;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button btnDecrTip;
        private System.Windows.Forms.Button btnIncrTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblNoOfPeople;
        private System.Windows.Forms.Button btnDecrPeople;
        private System.Windows.Forms.Button btnIncrPeople;
        private System.Windows.Forms.TextBox inpTotalPeople;
        private System.Windows.Forms.Label lblTotalOut;
        private System.Windows.Forms.Label lblTipOut;
        private System.Windows.Forms.Label lblPP2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPP1;
        private System.Windows.Forms.Label lblTipPP;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.TextBox inpTip;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Panel pnl_inp_tip;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblName;
    }
}

