namespace ISDS309FinalProject
{
    partial class ChooseAccountFrm
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
            welcomeLbl = new Label();
            savingsBtn = new RadioButton();
            checkingsBtn = new RadioButton();
            OKBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(534, 117);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(91, 117);
            welcomeLbl.Margin = new Padding(4, 0, 4, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(226, 32);
            welcomeLbl.TabIndex = 7;
            welcomeLbl.Text = "Choose an Account:";
            welcomeLbl.Click += welcomeLbl_Click;
            // 
            // savingsBtn
            // 
            savingsBtn.AutoSize = true;
            savingsBtn.BackColor = SystemColors.ControlLightLight;
            savingsBtn.Location = new Point(91, 266);
            savingsBtn.Margin = new Padding(4);
            savingsBtn.Name = "savingsBtn";
            savingsBtn.Size = new Size(98, 29);
            savingsBtn.TabIndex = 9;
            savingsBtn.TabStop = true;
            savingsBtn.Text = "Savings";
            savingsBtn.UseVisualStyleBackColor = false;
            savingsBtn.CheckedChanged += savingsBtn_CheckedChanged;
            // 
            // checkingsBtn
            // 
            checkingsBtn.AutoSize = true;
            checkingsBtn.BackColor = SystemColors.ControlLightLight;
            checkingsBtn.Location = new Point(91, 188);
            checkingsBtn.Margin = new Padding(4);
            checkingsBtn.Name = "checkingsBtn";
            checkingsBtn.Size = new Size(117, 29);
            checkingsBtn.TabIndex = 8;
            checkingsBtn.TabStop = true;
            checkingsBtn.Text = "Checkings";
            checkingsBtn.UseVisualStyleBackColor = false;
            checkingsBtn.CheckedChanged += checkingsBtn_CheckedChanged;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = Color.DarkGreen;
            OKBtn.Location = new Point(91, 347);
            OKBtn.Margin = new Padding(4, 3, 4, 3);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(179, 57);
            OKBtn.TabIndex = 10;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            OKBtn.UseWaitCursor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkTurquoise;
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(91, 439);
            cancelBtn.Margin = new Padding(4, 3, 4, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(180, 57);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.UseWaitCursor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // ChooseAccountFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(cancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(savingsBtn);
            Controls.Add(checkingsBtn);
            Controls.Add(welcomeLbl);
            Controls.Add(pictureBox1);
            Name = "ChooseAccountFrm";
            Text = "Example Text";
            Load += ChooseAccountWithdrawal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcomeLbl;
        private RadioButton savingsBtn;
        private RadioButton checkingsBtn;
        private Button OKBtn;
        private Button cancelBtn;
    }
}