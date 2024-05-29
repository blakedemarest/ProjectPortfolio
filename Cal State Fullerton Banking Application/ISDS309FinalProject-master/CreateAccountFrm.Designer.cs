namespace ISDS309FinalProject
{
    partial class CreateAccountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountFrm));
            pictureBox1 = new PictureBox();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            passwordLbl = new Label();
            usernameLbl = new Label();
            confirmPasswordInput = new TextBox();
            label1 = new Label();
            createAccountBtn = new Button();
            firstNameInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lastNameInput = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // passwordInput
            // 
            resources.ApplyResources(passwordInput, "passwordInput");
            passwordInput.Name = "passwordInput";
            // 
            // usernameInput
            // 
            resources.ApplyResources(usernameInput, "usernameInput");
            usernameInput.Name = "usernameInput";
            usernameInput.TextChanged += usernameTxt_TextChanged;
            // 
            // passwordLbl
            // 
            resources.ApplyResources(passwordLbl, "passwordLbl");
            passwordLbl.Name = "passwordLbl";
            // 
            // usernameLbl
            // 
            resources.ApplyResources(usernameLbl, "usernameLbl");
            usernameLbl.Name = "usernameLbl";
            // 
            // confirmPasswordInput
            // 
            resources.ApplyResources(confirmPasswordInput, "confirmPasswordInput");
            confirmPasswordInput.Name = "confirmPasswordInput";
            confirmPasswordInput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // createAccountBtn
            // 
            resources.ApplyResources(createAccountBtn, "createAccountBtn");
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createBtn_Click;
            // 
            // firstNameInput
            // 
            resources.ApplyResources(firstNameInput, "firstNameInput");
            firstNameInput.Name = "firstNameInput";
            firstNameInput.TextChanged += firstNameInput_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // lastNameInput
            // 
            resources.ApplyResources(lastNameInput, "lastNameInput");
            lastNameInput.Name = "lastNameInput";
            lastNameInput.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateAccountFrm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lastNameInput);
            Controls.Add(label2);
            Controls.Add(firstNameInput);
            Controls.Add(createAccountBtn);
            Controls.Add(confirmPasswordInput);
            Controls.Add(label1);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(pictureBox1);
            Name = "CreateAccountFrm";
            Load += CreateAccountFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private Label passwordLbl;
        private Label usernameLbl;
        private TextBox confirmPasswordInput;
        private Label label1;
        private Button createAccountBtn;
        private TextBox firstNameInput;
        private Label label2;
        private Label label3;
        private TextBox lastNameInput;
        private Button button1;
    }
}