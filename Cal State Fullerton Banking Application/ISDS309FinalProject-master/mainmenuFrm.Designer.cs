namespace ISDS309FinalProject
{
    partial class mainmenuFrm
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
            depositBtn = new Button();
            transferBtn = new Button();
            balanceBtn = new Button();
            withdrawalBtn = new Button();
            cancelBtn = new Button();
            pictureBox1 = new PictureBox();
            welcomeLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // depositBtn
            // 
            depositBtn.BackColor = SystemColors.ActiveCaption;
            depositBtn.Location = new Point(120, 286);
            depositBtn.Margin = new Padding(4);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(196, 72);
            depositBtn.TabIndex = 0;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = false;
            depositBtn.Click += depositBtn_Click;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = SystemColors.ActiveCaption;
            transferBtn.Location = new Point(120, 366);
            transferBtn.Margin = new Padding(4);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(196, 71);
            transferBtn.TabIndex = 1;
            transferBtn.Text = "Transfer";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // balanceBtn
            // 
            balanceBtn.BackColor = SystemColors.ActiveCaption;
            balanceBtn.Location = new Point(120, 209);
            balanceBtn.Margin = new Padding(4);
            balanceBtn.Name = "balanceBtn";
            balanceBtn.Size = new Size(196, 70);
            balanceBtn.TabIndex = 2;
            balanceBtn.Text = "Balance Inquiry";
            balanceBtn.UseVisualStyleBackColor = false;
            balanceBtn.Click += balanceBtn_Click;
            // 
            // withdrawalBtn
            // 
            withdrawalBtn.BackColor = SystemColors.ActiveCaption;
            withdrawalBtn.Location = new Point(120, 128);
            withdrawalBtn.Margin = new Padding(4);
            withdrawalBtn.Name = "withdrawalBtn";
            withdrawalBtn.Size = new Size(196, 74);
            withdrawalBtn.TabIndex = 3;
            withdrawalBtn.Text = "Withdraw";
            withdrawalBtn.UseVisualStyleBackColor = false;
            withdrawalBtn.Click += withdrawalBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Location = new Point(120, 445);
            cancelBtn.Margin = new Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(196, 74);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Exit";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(534, 117);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(120, 40);
            welcomeLbl.Margin = new Padding(4, 0, 4, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(320, 32);
            welcomeLbl.TabIndex = 6;
            welcomeLbl.Text = "Welcome, (insert name here)";
            // 
            // mainmenuFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(welcomeLbl);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Controls.Add(withdrawalBtn);
            Controls.Add(balanceBtn);
            Controls.Add(transferBtn);
            Controls.Add(depositBtn);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "mainmenuFrm";
            Text = "Main Menu";
            Load += mainmenuFrm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button depositBtn;
        private Button transferBtn;
        private Button balanceBtn;
        private Button withdrawalBtn;
        private Button cancelBtn;
        private PictureBox pictureBox1;
        private Label welcomeLbl;
    }
}