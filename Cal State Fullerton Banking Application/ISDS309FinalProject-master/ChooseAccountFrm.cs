using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISDS309FinalProject.Form1_LoginFrm;

namespace ISDS309FinalProject
{
    public partial class ChooseAccountFrm : Form
    {
        public bool IsWithdrawal { get; set; } //bool that establishes what ChooseAccountFrm looks like.
        public ChooseAccountFrm(bool isWithdrawal)
        {
            InitializeComponent();
            IsWithdrawal = isWithdrawal;
            this.FormClosing += FormUtilities.CloseFormHandler;

        }



        private bool checkingAccount = false;
        private bool savingsAccount = false;

        private void ShowForm(Form form)
        {
            this.Hide(); // Hide the main menu
            form.Show(); // Show the form
        }

        private void ChooseAccountFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // This ensures the entire application exits when the main form attempts to close
        }

        private void ChooseAccountWithdrawal_Load(object sender, EventArgs e)
        {
            // Adjusts the label based on the operation
            this.Text = IsWithdrawal ? "Withdraw" : "Deposit";
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        //more isWithdrawal logic
        private void OKBtn_Click(object sender, EventArgs e)
        {

            if (UserSession.CheckingAccount || UserSession.SavingsAccount)
            {
                Form nextForm = IsWithdrawal ? (Form)new withdrawalFrm() : (Form)new depositFrm();
                ShowForm(nextForm);
            }
            else
            {
                MessageBox.Show("Please select an account type.");
            }
        }

        //establishes the UserSession booleans
        private void checkingsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkingsBtn.Checked)
            {
                UserSession.CheckingAccount = true;
                UserSession.SavingsAccount = false;
            }
        }

        //establishes the UserSession booleans
        private void savingsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (savingsBtn.Checked)
            {
                UserSession.CheckingAccount = false;
                UserSession.SavingsAccount = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainmenuFrm settingsForm = new mainmenuFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }
    }
}
