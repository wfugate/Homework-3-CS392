namespace FlashCards
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
            txtInt1 = new TextBox();
            txtInt2 = new TextBox();
            txtOp = new TextBox();
            txtInput = new TextBox();
            btnSubmit = new Button();
            btnGenerate = new Button();
            rbAddition = new RadioButton();
            rbSubtraction = new RadioButton();
            lblStatus = new Label();
            groupBox1 = new GroupBox();
            lblLine = new Label();
            lblScore = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInt1
            // 
            txtInt1.Font = new Font("Snap ITC", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInt1.Location = new Point(151, 1);
            txtInt1.Name = "txtInt1";
            txtInt1.ReadOnly = true;
            txtInt1.Size = new Size(131, 131);
            txtInt1.TabIndex = 0;
            // 
            // txtInt2
            // 
            txtInt2.BackColor = SystemColors.Control;
            txtInt2.Font = new Font("Snap ITC", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInt2.Location = new Point(151, 138);
            txtInt2.Name = "txtInt2";
            txtInt2.ReadOnly = true;
            txtInt2.Size = new Size(131, 131);
            txtInt2.TabIndex = 1;
            // 
            // txtOp
            // 
            txtOp.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOp.Location = new Point(33, 200);
            txtOp.Name = "txtOp";
            txtOp.ReadOnly = true;
            txtOp.Size = new Size(75, 64);
            txtOp.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(24, 100);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(141, 100);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(84, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(141, 23);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(84, 23);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // rbAddition
            // 
            rbAddition.AutoSize = true;
            rbAddition.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAddition.Location = new Point(24, 48);
            rbAddition.Name = "rbAddition";
            rbAddition.Size = new Size(84, 21);
            rbAddition.TabIndex = 6;
            rbAddition.TabStop = true;
            rbAddition.Text = "Addition";
            rbAddition.UseVisualStyleBackColor = true;
            // 
            // rbSubtraction
            // 
            rbSubtraction.AutoSize = true;
            rbSubtraction.Font = new Font("Snap ITC", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSubtraction.Location = new Point(24, 23);
            rbSubtraction.Name = "rbSubtraction";
            rbSubtraction.Size = new Size(100, 19);
            rbSubtraction.TabIndex = 7;
            rbSubtraction.TabStop = true;
            rbSubtraction.Text = "Subtraction";
            rbSubtraction.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(24, 126);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 17);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Begin!";
            lblStatus.Click += txtStatus_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLine);
            groupBox1.Controls.Add(rbAddition);
            groupBox1.Controls.Add(rbSubtraction);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Location = new Point(33, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 152);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // lblLine
            // 
            lblLine.BorderStyle = BorderStyle.Fixed3D;
            lblLine.Location = new Point(0, 86);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(249, 1);
            lblLine.TabIndex = 11;
            lblLine.Text = "ddd";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(33, 30);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(43, 17);
            lblScore.TabIndex = 11;
            lblScore.Text = "0/10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 455);
            Controls.Add(lblScore);
            Controls.Add(groupBox1);
            Controls.Add(txtOp);
            Controls.Add(txtInt2);
            Controls.Add(txtInt1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInt1;
        private TextBox txtInt2;
        private TextBox txtOp;
        private TextBox txtInput;
        private Button btnSubmit;
        private Button btnGenerate;
        private RadioButton rbAddition;
        private RadioButton rbSubtraction;
        private Label lblStatus;
        private GroupBox groupBox1;
        private Label lblLine;
        private Label lblScore;
    }
}
