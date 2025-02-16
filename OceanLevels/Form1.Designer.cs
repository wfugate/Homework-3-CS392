namespace OceanLevels
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
            label1 = new Label();
            txtYear = new TextBox();
            lbLevels = new ListBox();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 60);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Year:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(87, 57);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 1;
            // 
            // lbLevels
            // 
            lbLevels.FormattingEnabled = true;
            lbLevels.ItemHeight = 15;
            lbLevels.Location = new Point(19, 103);
            lbLevels.Name = "lbLevels";
            lbLevels.Size = new Size(168, 154);
            lbLevels.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(19, 78);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(51, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lbLevels);
            Controls.Add(txtYear);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtYear;
        private ListBox lbLevels;
        private Button btnShow;
    }
}
