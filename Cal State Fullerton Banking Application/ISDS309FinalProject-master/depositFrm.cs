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
    public partial class depositFrm : Form
    {
        public depositFrm()
        {
            InitializeComponent();
            this.FormClosing += FormUtilities.CloseFormHandler;
        }

        public bool UpdateAccountBalanceDeposit(double amount, out double remainingBalance)
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
                if (userData[i, 3] == username)
                {
                    int balanceColumn = accountType == "Checking" ? 5 : 6;
                    currentBalance = double.Parse(userData[i, balanceColumn].Trim('$'));
                    currentBalance += amount;
                    userData[i, balanceColumn] = $"${currentBalance:0.00}";
                    updateSuccessful = true;
                    remainingBalance = currentBalance;
                    break;
                }
            }

            // Write updated data back to file
            if (updateSuccessful)
            {
                using (StreamWriter writer = new StreamWriter(allUsersFilePath, false))  // Overwrite file
                {
                    writer.WriteLine("UserID,First Name,Last Name,Username,Password,Checking Account Balance,Savings Account Balance");
                    for (int i = 1; i < userData.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(",", userData[i, 0], userData[i, 1], userData[i, 2], userData[i, 3], userData[i, 4], userData[i, 5], userData[i, 6]));
                    }
                }
            }

            return updateSuccessful;
        }

        private void DepositMessage(double amount)
        {
            string accountType = UserSession.CheckingAccount ? "Checking" : "Savings";  // Determine the account type
                                                                                        // Prompt the user to confirm the deposit
            double currentAccountBalance = UserSession.CheckingAccount ? UserSession.CurrentCheckingBalance : UserSession.CurrentSavingsBalance;
            DialogResult result = MessageBox.Show($"Are you sure you want to deposit ${amount:0.00} into your {accountType} account?", "Confirm deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            // Check the user's response
            if (result == DialogResult.Yes)
            {
                double remainingBalance;
                bool wasUpdateSuccessful = UpdateAccountBalanceDeposit(amount, out remainingBalance);
                if (UserSession.CheckingAccount)
                {
                    UserSession.CurrentCheckingBalance = remainingBalance;
                    TransactionLogger.LogTransaction("Deposit", amount, "Checking", remainingBalance);

                }
                else
                {
                    UserSession.CurrentSavingsBalance = remainingBalance;
                    TransactionLogger.LogTransaction("Deposit", amount, "Savings", remainingBalance);
                }
                MessageBox.Show($"Successfully deposited ${amount} into your account!");
            }
            else
            {
                MessageBox.Show("deposit cancelled.", "Transaction Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainmenuFrm settingsForm = new mainmenuFrm();
            FormUtilities.ShowForm(this, settingsForm);

        }

        private void depositFrm_Load(object sender, EventArgs e)
        {

        }

        private void fortyBtn_Click_1(object sender, EventArgs e)
        {
            DepositMessage(40.00);
        }

        private void eightyBtn_Click_1(object sender, EventArgs e)
        {
            DepositMessage(80.00);
        }

        private void hundredBtn_Click_1(object sender, EventArgs e)
        {
            DepositMessage(100.00);
        }

        private void twohundredBtn_Click_1(object sender, EventArgs e)
        {
            DepositMessage(200.00);
        }

        private void otherBtn_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to deposit:", "deposit", "0", -1, -1);
            if (double.TryParse(input, out double customAmount) && customAmount > 0)
            {
                DepositMessage(customAmount);
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            mainmenuFrm settingsForm = new mainmenuFrm();
            FormUtilities.ShowForm(this, settingsForm); 
        }
    }
}
