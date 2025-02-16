namespace Distance_Converter
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
            lblInput = new Label();
            txtInput = new TextBox();
            lbFrom = new ListBox();
            gbFrom = new GroupBox();
            groupBox1 = new GroupBox();
            lbTo = new ListBox();
            lblResult = new Label();
            txtResult = new TextBox();
            btnConvert = new Button();
            btnExit = new Button();
            gbFrom.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(165, 83);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(150, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter a distance to convert:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(321, 80);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // lbFrom
            // 
            lbFrom.FormattingEnabled = true;
            lbFrom.ItemHeight = 15;
            lbFrom.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lbFrom.Location = new Point(37, 33);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(174, 94);
            lbFrom.TabIndex = 2;
            lbFrom.SelectedIndexChanged += lbFrom_SelectedIndexChanged;
            // 
            // gbFrom
            // 
            gbFrom.Controls.Add(lbFrom);
            gbFrom.Location = new Point(40, 143);
            gbFrom.Name = "gbFrom";
            gbFrom.Size = new Size(250, 147);
            gbFrom.TabIndex = 3;
            gbFrom.TabStop = false;
            gbFrom.Text = "From";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTo);
            groupBox1.Location = new Point(321, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 147);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "To";
            // 
            // lbTo
            // 
            lbTo.FormattingEnabled = true;
            lbTo.ItemHeight = 15;
            lbTo.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            lbTo.Location = new Point(37, 33);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(174, 94);
            lbTo.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(315, 320);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(358, 317);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 6;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(196, 372);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 7;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(315, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnConvert);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(groupBox1);
            Controls.Add(gbFrom);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            gbFrom.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private ListBox lbFrom;
        private GroupBox gbFrom;
        private GroupBox groupBox1;
        private ListBox lbTo;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnConvert;
        private Button btnExit;
    }
}
