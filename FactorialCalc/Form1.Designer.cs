namespace FactorialCalc
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
            lblResult = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(427, 193);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(45, 15);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result: ";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(323, 190);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(24, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
    }
}
