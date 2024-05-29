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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ISDS309FinalProject
{
    public partial class withdrawalFrm : Form
    {
        public withdrawalFrm()
        {
            InitializeComponent();
            this.FormClosing += FormUtilities.CloseFormHandler;
        }

        public bool UpdateAccountBalanceWithdraw(double amount, out double remainingBalance)
        {
            string allUsersFilePath = Path.Combine(Application.StartupPath, "All_User_Accounts.txt");
            bool updateSuccessful = false;
            remainingBalance = 0.0;
            double currentBalance = 0;
            string username = UserSession.CurrentUsername;
            string accountType = UserSession.CheckingAccount ? "Checking" : "Savings";

            // Load user data into array
            string[,] userData = UserDataTracking.LoadUserData(allUsersFilePath);

            // Find the user and update the balance
            for (int i = 1; i < userData.GetLength(0); i++)
            {
                if (userData[i, 3].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))  // Check the username match
                {
                    int balanceColumn = accountType == "Checking" ? 5 : 6;  // Adjust indices based on actual column positions
                    currentBalance = double.Parse(userData[i, balanceColumn].Trim('$'));
                    if (currentBalance >= amount)
                    {
                        currentBalance -= amount;
                        userData[i, balanceColumn] = $"${currentBalance:0.00}";
                        updateSuccessful = true;
                        remainingBalance = currentBalance;
                        break;  // Exit the loop once update is done
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient funds for this transaction. Available funds: ${currentBalance:0.00}");
                        return false;  // Exit method early if insufficient funds
                    }
                }
            }

            // Write updated data back to file if update was successful
            if (updateSuccessful)
            {
                using (StreamWriter writer = new StreamWriter(allUsersFilePath, false))  // Overwrite the entire file
                {
                    writer.WriteLine("UserID,First Name,Last Name,Username,Password,Checking Account Balance,Savings Account Balance");
                    for (int j = 0; j < userData.GetLength(0); j++)  // Start from 0 to include headers
                    {
                        writer.WriteLine(string.Join(",", userData[j, 0], userData[j, 1], userData[j, 2], userData[j, 3], userData[j, 4], userData[j, 5], userData[j, 6]));
                    }
                }
            }

            return updateSuccessful;
        }


        private void WithdrawalMessage(double amount)
        {
            string accountType = UserSession.CheckingAccount ? "Checking" : "Savings";  // Determine the account type
                                                                                        // Prompt the user to confirm the withdrawal
            double currentAccountBalance = UserSession.CheckingAccount ? UserSession.CurrentCheckingBalance : UserSession.CurrentSavingsBalance;
            DialogResult result = MessageBox.Show($"Are you sure you want to withdraw ${amount:0.00} from your {accountType} account?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                double remainingBalance;
                bool wasUpdateSuccessful = UpdateAccountBalanceWithdraw(amount, out remainingBalance);
                if (wasUpdateSuccessful)
                {
                    if (UserSession.CheckingAccount)
                    {
                        UserSession.CurrentCheckingBalance = remainingBalance;
                        TransactionLogger.LogTransaction("Withdrawal", amount, "Checking", remainingBalance);
                    }
                    else
                    {
                        UserSession.CurrentSavingsBalance = remainingBalance;
                        TransactionLogger.LogTransaction("Withdrawal", amount, "Savings", remainingBalance);
                    }
                    // Show success message only if the update was successful
                    MessageBox.Show($"Successfully withdrew ${amount} from your account! Remaining balance: ${remainingBalance:0.00}", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Show error message if the withdrawal was not successful
                    MessageBox.Show($"Withdrawal failed. Please check the amount and try again.", "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Withdrawal cancelled.", "Transaction Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fortyBtn_Click(object sender, EventArgs e)
        {
            WithdrawalMessage(40.00);
        }

        private void eightyBtn_Click(object sender, EventArgs e)
        {
            WithdrawalMessage(80.00);
        }

        private void hundredBtn_Click(object sender, EventArgs e)
        {
            WithdrawalMessage(100.00);
        }

        private void twohundredBtn_Click(object sender, EventArgs e)
        {
            WithdrawalMessage(200.00);
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to withdraw:", "Withdraw", "0", -1, -1);
            if (double.TryParse(input, out double customAmount) && customAmount > 0)
            {
                WithdrawalMessage(customAmount);
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainmenuFrm settingsForm = new mainmenuFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }
    }
}
