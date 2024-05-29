namespace ISDS309FinalProject
{
    partial class transferFrm
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
            OKBtn = new Button();
            fromLbl = new Label();
            accountBox = new ComboBox();
            accountBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            transferAmt = new TextBox();
            cancelBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(454, 82);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = SystemColors.ActiveCaption;
            OKBtn.Location = new Point(106, 324);
            OKBtn.Margin = new Padding(3, 2, 3, 2);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(143, 46);
            OKBtn.TabIndex = 10;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            OKBtn.Click += OKBtn_Click;
            // 
            // fromLbl
            // 
            fromLbl.AutoSize = true;
            fromLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromLbl.Location = new Point(106, 156);
            fromLbl.Name = "fromLbl";
            fromLbl.Size = new Size(52, 23);
            fromLbl.TabIndex = 12;
            fromLbl.Text = "From";
            // 
            // accountBox
            // 
            accountBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountBox.FormattingEnabled = true;
            accountBox.Location = new Point(189, 146);
            accountBox.Margin = new Padding(3, 2, 3, 2);
            accountBox.MaxDropDownItems = 2;
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(151, 28);
            accountBox.TabIndex = 15;
            accountBox.SelectedIndexChanged += accountBox_SelectedIndexChanged;
            // 
            // accountBox2
            // 
            accountBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            accountBox2.FormattingEnabled = true;
            accountBox2.Location = new Point(189, 196);
            accountBox2.Margin = new Padding(3, 2, 3, 2);
            accountBox2.MaxDropDownItems = 2;
            accountBox2.Name = "accountBox2";
            accountBox2.Size = new Size(151, 28);
            accountBox2.TabIndex = 19;
            accountBox2.SelectedIndexChanged += accountBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 204);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 20;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 250);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 21;
            label1.Text = "Amount";
            label1.Click += label1_Click;
            // 
            // transferAmt
            // 
            transferAmt.Location = new Point(189, 248);
            transferAmt.Margin = new Padding(2);
            transferAmt.Name = "transferAmt";
            transferAmt.Size = new Size(151, 27);
            transferAmt.TabIndex = 22;
            transferAmt.TextChanged += transferAmt_TextChanged;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.DarkTurquoise;
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(272, 324);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(144, 46);
            cancelBtn.TabIndex = 23;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.UseWaitCursor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 24;
            label3.Text = "Enter $ Amount";
            // 
            // transferFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cancelBtn);
            Controls.Add(transferAmt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(accountBox2);
            Controls.Add(OKBtn);
            Controls.Add(accountBox);
            Controls.Add(fromLbl);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "transferFrm";
            Text = "Transfer";
            Load += transferFrm_Load;
            DataContextChanged += accountBox_SelectedIndexChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button OKBtn;
        private Label fromLbl;
        private ComboBox accountBox;
        private ComboBox accountBox2;
        private Label label2;
        private Label label1;
        private TextBox transferAmt;
        private Button cancelBtn;
        private Label label3;
    }
}