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
    public partial class transferFrm : Form
    {
        private withdrawalFrm withdrawalForm = new withdrawalFrm();
        private depositFrm depositForm = new depositFrm();
        public transferFrm()
        {
            InitializeComponent();
            InitializeAccountBoxes();
            this.FormClosing += FormUtilities.CloseFormHandler;
        }

        private void InitializeAccountBoxes()
        {

            accountBox.Items.Add("Checkings");
            accountBox.Items.Add("Savings");

            accountBox2.Items.Add("Checkings");
            accountBox2.Items.Add("Savings");

            accountBox.SelectedIndex = 0;  // Default to Checking
            accountBox2.SelectedIndex = 1;  // Default to Savings
        }

        private void accountBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void transferFrm_Load(object sender, EventArgs e)
        {

        }

        private void toLbl_Click(object sender, EventArgs e)
        {

        }

        private void accountBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            double amount;
            double remainingBalanceWithdraw;
            double remainingBalanceDeposit;

            if (!double.TryParse(transferAmt.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (accountBox.Text == accountBox2.Text)
            {
                MessageBox.Show("You cannot transfer between the same account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool withdrawFromChecking = accountBox.Text == "Checkings";
            bool depositToChecking = accountBox2.Text == "Checkings";

            // Adjust UserSession flags for withdrawal
            UserSession.CheckingAccount = withdrawFromChecking;
            UserSession.SavingsAccount = !withdrawFromChecking;

            // Perform withdrawal from the first account
            if (withdrawalForm.UpdateAccountBalanceWithdraw(amount, out remainingBalanceWithdraw))
            {
                // Adjust UserSession flags for deposit
                UserSession.CheckingAccount = depositToChecking;
                UserSession.SavingsAccount = !depositToChecking;

                // Perform deposit to the second account
                if (depositForm.UpdateAccountBalanceDeposit(amount, out remainingBalanceDeposit))
                {
                    // Update session balances
                    if (withdrawFromChecking)
                    {
                        UserSession.CurrentCheckingBalance = remainingBalanceWithdraw;
                        TransactionLogger.LogTransaction("Transfer", amount, "Checking => Savings", remainingBalanceWithdraw);
                    }
                    else
                    {
                        UserSession.CurrentSavingsBalance = remainingBalanceWithdraw;
                        TransactionLogger.LogTransaction("Transfer", amount, "Savings => Checking", remainingBalanceWithdraw);
                    }

                    if (depositToChecking)
                    {
                        UserSession.CurrentCheckingBalance = remainingBalanceDeposit;

                    }
                    else
                    {
                        UserSession.CurrentSavingsBalance = remainingBalanceDeposit;

                    }

                    MessageBox.Show($"Transfer successful. New balance in the target account: ${remainingBalanceDeposit:0.00}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transfer failed during deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Transfer failed during withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainmenuFrm settingsForm = new mainmenuFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }

        private void transferAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
