namespace FruitSalad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTotal = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            btnExit = new Button();
            pbBanana = new PictureBox();
            pbApple = new PictureBox();
            pbOrange = new PictureBox();
            pbPear = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBanana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbApple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPear).BeginInit();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(448, 71);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 0;
            txtTotal.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(473, 47);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "Total";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(448, 297);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 33);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(448, 336);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 33);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pbBanana
            // 
            pbBanana.Image = (Image)resources.GetObject("pbBanana.Image");
            pbBanana.InitialImage = (Image)resources.GetObject("pbBanana.InitialImage");
            pbBanana.Location = new Point(12, 12);
            pbBanana.Name = "pbBanana";
            pbBanana.Size = new Size(129, 157);
            pbBanana.TabIndex = 4;
            pbBanana.TabStop = false;
            pbBanana.Click += pbBanana_Click;
            // 
            // pbApple
            // 
            pbApple.Image = (Image)resources.GetObject("pbApple.Image");
            pbApple.InitialImage = (Image)resources.GetObject("pbApple.InitialImage");
            pbApple.Location = new Point(147, 12);
            pbApple.Name = "pbApple";
            pbApple.Size = new Size(129, 157);
            pbApple.TabIndex = 5;
            pbApple.TabStop = false;
            pbApple.Click += pbApple_Click;
            // 
            // pbOrange
            // 
            pbOrange.Image = (Image)resources.GetObject("pbOrange.Image");
            pbOrange.InitialImage = (Image)resources.GetObject("pbOrange.InitialImage");
            pbOrange.Location = new Point(12, 173);
            pbOrange.Name = "pbOrange";
            pbOrange.Size = new Size(129, 157);
            pbOrange.TabIndex = 6;
            pbOrange.TabStop = false;
            pbOrange.Click += pbOrange_Click;
            // 
            // pbPear
            // 
            pbPear.Image = (Image)resources.GetObject("pbPear.Image");
            pbPear.InitialImage = (Image)resources.GetObject("pbPear.InitialImage");
            pbPear.Location = new Point(147, 173);
            pbPear.Name = "pbPear";
            pbPear.Size = new Size(129, 157);
            pbPear.TabIndex = 7;
            pbPear.TabStop = false;
            pbPear.Click += pbPear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbPear);
            Controls.Add(pbOrange);
            Controls.Add(pbApple);
            Controls.Add(pbBanana);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbBanana).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbApple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label1;
        private Button btnReset;
        private Button btnExit;
        private PictureBox pbBanana;
        private PictureBox pbApple;
        private PictureBox pbOrange;
        private PictureBox pbPear;
    }
}
