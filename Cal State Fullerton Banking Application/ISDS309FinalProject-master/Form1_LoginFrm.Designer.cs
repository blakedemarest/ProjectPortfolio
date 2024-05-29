namespace ISDS309FinalProject
{
    partial class Form1_LoginFrm
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
            usernameLbl = new Label();
            passwordLbl = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            createAccountBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(95, 122);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(73, 20);
            usernameLbl.TabIndex = 0;
            usernameLbl.Text = "username";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(95, 167);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(72, 20);
            passwordLbl.TabIndex = 1;
            passwordLbl.Text = "password";
            passwordLbl.Click += label2_Click;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(193, 122);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(125, 27);
            usernameTxt.TabIndex = 2;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(193, 167);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(125, 27);
            passwordTxt.TabIndex = 3;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(193, 292);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Location = new Point(193, 338);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(169, 31);
            createAccountBtn.TabIndex = 5;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(424, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1_LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(createAccountBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Name = "Form1_LoginFrm";
            Text = "Welcome to CSUF Credit Union";
            Load += loginFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLbl;
        private Label passwordLbl;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Button createAccountBtn;
        private PictureBox pictureBox1;
    }
}
