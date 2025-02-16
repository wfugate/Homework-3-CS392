namespace StadiumSeating
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbTicketsSold = new GroupBox();
            lblClassC = new Label();
            txtClassC = new TextBox();
            lblClassA = new Label();
            lblClassB = new Label();
            txtClassA = new TextBox();
            txtClassB = new TextBox();
            lbltickets = new Label();
            gbRevenue = new GroupBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            lblClassB2 = new Label();
            txtClassCDisplay = new TextBox();
            lblClassA2 = new Label();
            lblClassC2 = new Label();
            txtClassADisplay = new TextBox();
            txtClassBDisplay = new TextBox();
            btnCalc = new Button();
            btnExit = new Button();
            btnClear = new Button();
            gbTicketsSold.SuspendLayout();
            gbRevenue.SuspendLayout();
            SuspendLayout();
            // 
            // gbTicketsSold
            // 
            gbTicketsSold.Controls.Add(lblClassC);
            gbTicketsSold.Controls.Add(txtClassC);
            gbTicketsSold.Controls.Add(lblClassA);
            gbTicketsSold.Controls.Add(lblClassB);
            gbTicketsSold.Controls.Add(txtClassA);
            gbTicketsSold.Controls.Add(txtClassB);
            gbTicketsSold.Controls.Add(lbltickets);
            gbTicketsSold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbTicketsSold.Location = new Point(12, 12);
            gbTicketsSold.Name = "gbTicketsSold";
            gbTicketsSold.Size = new Size(291, 241);
            gbTicketsSold.TabIndex = 0;
            gbTicketsSold.TabStop = false;
            gbTicketsSold.Text = "Tickets Sold";
            gbTicketsSold.Enter += gbTicketsSold_Enter;
            // 
            // lblClassC
            // 
            lblClassC.AutoSize = true;
            lblClassC.Location = new Point(27, 187);
            lblClassC.Name = "lblClassC";
            lblClassC.Size = new Size(67, 21);
            lblClassC.TabIndex = 1;
            lblClassC.Text = "CLass C:";
            lblClassC.Click += lblClassB_Click;
            // 
            // txtClassC
            // 
            txtClassC.Location = new Point(99, 189);
            txtClassC.Name = "txtClassC";
            txtClassC.Size = new Size(100, 29);
            txtClassC.TabIndex = 3;
            // 
            // lblClassA
            // 
            lblClassA.AutoSize = true;
            lblClassA.Location = new Point(27, 86);
            lblClassA.Name = "lblClassA";
            lblClassA.Size = new Size(67, 21);
            lblClassA.TabIndex = 4;
            lblClassA.Text = "CLass A:";
            lblClassA.Click += label1_Click_1;
            // 
            // lblClassB
            // 
            lblClassB.AutoSize = true;
            lblClassB.Location = new Point(27, 137);
            lblClassB.Name = "lblClassB";
            lblClassB.Size = new Size(66, 21);
            lblClassB.TabIndex = 5;
            lblClassB.Text = "CLass B:";
            // 
            // txtClassA
            // 
            txtClassA.Location = new Point(100, 83);
            txtClassA.Name = "txtClassA";
            txtClassA.Size = new Size(100, 29);
            txtClassA.TabIndex = 1;
            // 
            // txtClassB
            // 
            txtClassB.Location = new Point(100, 135);
            txtClassB.Name = "txtClassB";
            txtClassB.Size = new Size(100, 29);
            txtClassB.TabIndex = 2;
            // 
            // lbltickets
            // 
            lbltickets.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltickets.Location = new Point(27, 25);
            lbltickets.Name = "lbltickets";
            lbltickets.Size = new Size(186, 33);
            lbltickets.TabIndex = 0;
            lbltickets.Text = "Enter the number of tickets sold for each class of seats.";
            lbltickets.Click += label1_Click;
            // 
            // gbRevenue
            // 
            gbRevenue.Controls.Add(txtTotal);
            gbRevenue.Controls.Add(lblTotal);
            gbRevenue.Controls.Add(lblClassB2);
            gbRevenue.Controls.Add(txtClassCDisplay);
            gbRevenue.Controls.Add(lblClassA2);
            gbRevenue.Controls.Add(lblClassC2);
            gbRevenue.Controls.Add(txtClassADisplay);
            gbRevenue.Controls.Add(txtClassBDisplay);
            gbRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbRevenue.Location = new Point(309, 12);
            gbRevenue.Name = "gbRevenue";
            gbRevenue.Size = new Size(291, 241);
            gbRevenue.TabIndex = 1;
            gbRevenue.TabStop = false;
            gbRevenue.Text = "Revenue Generated";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(132, 182);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 29);
            txtTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(71, 185);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // lblClassB2
            // 
            lblClassB2.AutoSize = true;
            lblClassB2.Location = new Point(59, 89);
            lblClassB2.Name = "lblClassB2";
            lblClassB2.Size = new Size(66, 21);
            lblClassB2.TabIndex = 1;
            lblClassB2.Text = "CLass B:";
            // 
            // txtClassCDisplay
            // 
            txtClassCDisplay.Location = new Point(132, 134);
            txtClassCDisplay.Name = "txtClassCDisplay";
            txtClassCDisplay.ReadOnly = true;
            txtClassCDisplay.Size = new Size(100, 29);
            txtClassCDisplay.TabIndex = 3;
            // 
            // lblClassA2
            // 
            lblClassA2.AutoSize = true;
            lblClassA2.Location = new Point(59, 37);
            lblClassA2.Name = "lblClassA2";
            lblClassA2.Size = new Size(67, 21);
            lblClassA2.TabIndex = 4;
            lblClassA2.Text = "CLass A:";
            // 
            // lblClassC2
            // 
            lblClassC2.AutoSize = true;
            lblClassC2.Location = new Point(59, 137);
            lblClassC2.Name = "lblClassC2";
            lblClassC2.Size = new Size(67, 21);
            lblClassC2.TabIndex = 5;
            lblClassC2.Text = "CLass C:";
            // 
            // txtClassADisplay
            // 
            txtClassADisplay.Location = new Point(132, 34);
            txtClassADisplay.Name = "txtClassADisplay";
            txtClassADisplay.ReadOnly = true;
            txtClassADisplay.Size = new Size(100, 29);
            txtClassADisplay.TabIndex = 1;
            // 
            // txtClassBDisplay
            // 
            txtClassBDisplay.Location = new Point(132, 86);
            txtClassBDisplay.Name = "txtClassBDisplay";
            txtClassBDisplay.ReadOnly = true;
            txtClassBDisplay.Size = new Size(100, 29);
            txtClassBDisplay.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.Location = new Point(135, 259);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(110, 68);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate Revenue";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(367, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(251, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 68);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(gbRevenue);
            Controls.Add(gbTicketsSold);
            Name = "Form1";
            Text = "Form1";
            gbTicketsSold.ResumeLayout(false);
            gbTicketsSold.PerformLayout();
            gbRevenue.ResumeLayout(false);
            gbRevenue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTicketsSold;
        private TextBox txtClassC;
        private TextBox txtClassB;
        private TextBox txtClassA;
        private Label lbltickets;
        private Label lblClassA;
        private Label lblClassB;
        private Label lblClassC;
        private GroupBox gbRevenue;
        private TextBox txtTotal;
        private Label lblTotal;
        private Label lblClassB2;
        private TextBox txtClassCDisplay;
        private Label lblClassA2;
        private Label lblClassC2;
        private TextBox txtClassADisplay;
        private TextBox txtClassBDisplay;
        private Button btnCalc;
        private Button btnExit;
        private Button btnClear;
    }
}
