namespace ISDS309FinalProject
{
    partial class balanceFrm
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            SavingsAccountBalance = new Label();
            label3 = new Label();
            label4 = new Label();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(424, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(78, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 32);
            label2.TabIndex = 12;
            label2.Text = "Checking Account Balance";
            label2.Click += label2_Click;
            // 
            // SavingsAccountBalance
            // 
            SavingsAccountBalance.AutoSize = true;
            SavingsAccountBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SavingsAccountBalance.ForeColor = Color.Green;
            SavingsAccountBalance.Location = new Point(89, 162);
            SavingsAccountBalance.Margin = new Padding(2, 0, 2, 0);
            SavingsAccountBalance.Name = "SavingsAccountBalance";
            SavingsAccountBalance.Size = new Size(298, 32);
            SavingsAccountBalance.TabIndex = 13;
            SavingsAccountBalance.Text = "Savings Account Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(89, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(2, 22);
            label3.TabIndex = 14;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(89, 193);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(2, 22);
            label4.TabIndex = 15;
            label4.Click += label4_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkTurquoise;
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(89, 318);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(144, 46);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.UseWaitCursor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // balanceFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SavingsAccountBalance);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "balanceFrm";
            Text = "Balance";
            Load += balanceFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label SavingsAccountBalance;
        private Label label3;
        private Label label4;
        private Button cancelBtn;
    }
}