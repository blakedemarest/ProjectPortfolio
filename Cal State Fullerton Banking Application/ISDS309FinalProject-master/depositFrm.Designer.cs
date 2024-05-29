namespace ISDS309FinalProject
{
    partial class depositFrm
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
            label1 = new Label();
            amountLbl = new Label();
            otherBtn = new Button();
            twohundredBtn = new Button();
            hundredBtn = new Button();
            eightyBtn = new Button();
            fortyBtn = new Button();
            pictureBox1 = new PictureBox();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(534, 46);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 35;
            label1.Text = "Deposit Money";
            label1.UseWaitCursor = true;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLbl.ForeColor = Color.Black;
            amountLbl.Location = new Point(80, 46);
            amountLbl.Margin = new Padding(4, 0, 4, 0);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(228, 32);
            amountLbl.TabIndex = 34;
            amountLbl.Text = "Choose an amount";
            amountLbl.UseWaitCursor = true;
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.DarkGreen;
            otherBtn.ForeColor = Color.White;
            otherBtn.Location = new Point(80, 322);
            otherBtn.Margin = new Padding(4, 3, 4, 3);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(187, 75);
            otherBtn.TabIndex = 33;
            otherBtn.Text = "Other";
            otherBtn.UseVisualStyleBackColor = false;
            otherBtn.UseWaitCursor = true;
            otherBtn.Click += otherBtn_Click_1;
            // 
            // twohundredBtn
            // 
            twohundredBtn.BackColor = Color.DarkGreen;
            twohundredBtn.ForeColor = Color.White;
            twohundredBtn.Location = new Point(311, 204);
            twohundredBtn.Margin = new Padding(4, 3, 4, 3);
            twohundredBtn.Name = "twohundredBtn";
            twohundredBtn.Size = new Size(187, 75);
            twohundredBtn.TabIndex = 32;
            twohundredBtn.Text = "$200";
            twohundredBtn.UseVisualStyleBackColor = false;
            twohundredBtn.UseWaitCursor = true;
            twohundredBtn.Click += twohundredBtn_Click_1;
            // 
            // hundredBtn
            // 
            hundredBtn.BackColor = Color.DarkGreen;
            hundredBtn.ForeColor = Color.White;
            hundredBtn.Location = new Point(80, 204);
            hundredBtn.Margin = new Padding(4, 3, 4, 3);
            hundredBtn.Name = "hundredBtn";
            hundredBtn.Size = new Size(187, 75);
            hundredBtn.TabIndex = 31;
            hundredBtn.Text = "$100";
            hundredBtn.UseVisualStyleBackColor = false;
            hundredBtn.UseWaitCursor = true;
            hundredBtn.Click += hundredBtn_Click_1;
            // 
            // eightyBtn
            // 
            eightyBtn.BackColor = Color.DarkGreen;
            eightyBtn.ForeColor = Color.White;
            eightyBtn.Location = new Point(311, 111);
            eightyBtn.Margin = new Padding(4, 3, 4, 3);
            eightyBtn.Name = "eightyBtn";
            eightyBtn.Size = new Size(187, 75);
            eightyBtn.TabIndex = 30;
            eightyBtn.Text = "$80";
            eightyBtn.UseVisualStyleBackColor = false;
            eightyBtn.UseWaitCursor = true;
            eightyBtn.Click += eightyBtn_Click_1;
            // 
            // fortyBtn
            // 
            fortyBtn.BackColor = Color.DarkGreen;
            fortyBtn.ForeColor = Color.White;
            fortyBtn.Location = new Point(80, 111);
            fortyBtn.Margin = new Padding(4, 3, 4, 3);
            fortyBtn.Name = "fortyBtn";
            fortyBtn.Size = new Size(187, 75);
            fortyBtn.TabIndex = 29;
            fortyBtn.Text = "$40";
            fortyBtn.UseVisualStyleBackColor = false;
            fortyBtn.UseWaitCursor = true;
            fortyBtn.Click += fortyBtn_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(534, 111);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkTurquoise;
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(178, 460);
            cancelBtn.Margin = new Padding(4, 3, 4, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(180, 57);
            cancelBtn.TabIndex = 27;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.UseWaitCursor = true;
            cancelBtn.Click += cancelBtn_Click_1;
            // 
            // depositFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(amountLbl);
            Controls.Add(otherBtn);
            Controls.Add(twohundredBtn);
            Controls.Add(hundredBtn);
            Controls.Add(eightyBtn);
            Controls.Add(fortyBtn);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Margin = new Padding(4);
            Name = "depositFrm";
            Text = "Deposit";
            Load += depositFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label amountLbl;
        private Button otherBtn;
        private Button twohundredBtn;
        private Button hundredBtn;
        private Button eightyBtn;
        private Button fortyBtn;
        private PictureBox pictureBox1;
        private Button cancelBtn;
    }
}