using System.Text;

namespace ISDS309FinalProject
{
    public partial class Form1_LoginFrm : Form
    {
        //This handles the application closing
        public static class FormUtilities
        {
            public static void CloseFormHandler(object sender, FormClosingEventArgs e)
            {    
                Application.Exit(); // This will terminate the application when user presses the X
            }

            public static void CloseApplication(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Application.Exit(); //Terminates application when a button is pressed
                }

            }

            public static void ShowForm(Form currentForm, Form newForm)
            {
                currentForm.Hide();
                newForm.FormClosed += (s, args) =>
                {
                    currentForm.Show();
                };
                newForm.Show();
            }
        }



        public class TransactionLogger
        {
            private static string receiptPath;

            // Initialize when user logs in
            public static void InitializeReceipt()
            {
                receiptPath = Path.Combine(Application.StartupPath, $"Receipt_{UserSession.CurrentUsername}_{DateTime.Now:yyyy--MM--dd--HH--mmss}.txt");
                using (StreamWriter writer = new StreamWriter(receiptPath, true))
                {
                    writer.WriteLine("Session Start: " + DateTime.Now.ToString());
                    writer.WriteLine("User: " + UserSession.CurrentFirstName + " " + UserSession.CurrentLastName);
                    writer.WriteLine("Checking account balance: $" + UserSession.CurrentCheckingBalance);
                    writer.WriteLine("Savings account balance: $" + UserSession.CurrentSavingsBalance);
                    writer.WriteLine("===================");
                }
            }

            // Call this method to log a transaction
            public static void LogTransaction(string transactionType, double amount, string accountType, double balanceAfter)
            {
                using (StreamWriter writer = new StreamWriter(receiptPath, true))
                {
                    writer.WriteLine($"Transaction Type: {transactionType}");
                    writer.WriteLine($"Amount: ${amount}");
                    writer.WriteLine($"Account Type: {accountType}");
                    writer.WriteLine($"Balance After Transaction: ${balanceAfter}");
                    writer.WriteLine($"Timestamp: {DateTime.Now}");
                    writer.WriteLine("-------------------");
                }
            }

            // Call this at application exit or logout
            public static void FinalizeReceipt()
            {
                using (StreamWriter writer = new StreamWriter(receiptPath, true))
                {
                    writer.WriteLine("Session End: " + DateTime.Now.ToString());
                    writer.WriteLine("User: " + UserSession.CurrentFirstName + " " + UserSession.CurrentLastName);
                    writer.WriteLine("Checking account balance: $" + UserSession.CurrentCheckingBalance);
                    writer.WriteLine("Savings account balance: $" + UserSession.CurrentSavingsBalance);
                    writer.WriteLine("===================");
                }
            }
        }


        public class UserDataTracking
        {
            //do compsci majors have to do this all the time?? this is insane
            public static string[,] LoadUserData(string filePath)
            {
                string[] lines = File.ReadAllLines(filePath);
                string[,] userData = new string[lines.Length, 7];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    for (int j = 0; j < data.Length; j++)
                    {
                        userData[i, j] = data[j];
                    }
                }

                return userData;
            }
        }

        //I couldn't figure out how to get the first name, last name, and user ID out of my
        public static class UserSession
        {
            public static string CurrentUsername { get; set; } = "";
            public static bool CheckingAccount { get; set; } //These are implemented so that ChooseAccountFrm knows which account to get into for withdrawals/deposits
            public static bool SavingsAccount { get; set; } //These are implemented so that ChooseAccountFrm knows which account to get into for withdrawals/deposits
            public static string CurrentFirstName { get; set; } = "";
            public static string CurrentLastName { get; set; } = "";
            public static double CurrentCheckingBalance { get; set; }
            public static double CurrentSavingsBalance { get; set; }
            public static string CurrentUserID { get; set; } = "";

        }
        private bool VerifyLogin(string username, string password)
        {
            string allUsersFilePath = Path.Combine(Application.StartupPath, "All_User_Accounts.txt");

            try
            {
                if (File.Exists(allUsersFilePath))
                {
                    // Load data into a 2D array
                    string[,] userData = UserDataTracking.LoadUserData(allUsersFilePath);

                    // Iterate through the array to find a username and password match
                    for (int i = 0; i < userData.GetLength(0); i++)
                    {
                        string currentUsername = userData[i, 3].Trim(); 
                        string currentPassword = userData[i, 4].Trim(); 

                        if (currentUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            if (currentPassword.Equals(password))
                            {

                                UserSession.CurrentUserID = userData[i, 0].Trim(); 
                                UserSession.CurrentFirstName = userData[i, 1].Trim(); 
                                UserSession.CurrentLastName = userData[i, 2].Trim(); 
                                UserSession.CurrentCheckingBalance = double.Parse(userData[i, 5].Replace("$", ""));
                                UserSession.CurrentSavingsBalance = double.Parse(userData[i, 6].Replace("$", ""));

                                TransactionLogger.InitializeReceipt();

                                return true; // Correct username and password match
                            }
                            else
                            {
                                MessageBox.Show("Invalid password. Please try again.");
                                return false; // Password does not match
                            }
                        }
                    }
                    MessageBox.Show("Username not found. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username and password: {ex.Message}");
            }
            return false; // Username not found or password does not match
        }


        //This is the method I've been using to swap windows everytime a new window is opened.
        //Without it, the user would have every window open at once.
        //I implemented this before I knew about public classes so every form has a unique ShowForm.
        private void ShowForm(Form form)
        {
            this.Hide(); // Hide the main menu
            //form.FormClosed += (s, args) => this.Show(); // Show the main menu again when the form is closed
            form.Show(); // Show the form
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            // Check if the close reason is user closing the form via the 'X' button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ask the user to confirm they want to exit
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks 'No', cancel the closing of the form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            // If the form is closing for other reasons (like shutdown, system restart, etc.)
        }



        public Form1_LoginFrm()
        {
            InitializeComponent();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new CreateAccountFrm());
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            if (VerifyLogin(username, password))
            {
                UserSession.CurrentUsername = username;

                MessageBox.Show("Login successful!");

                ShowForm(new mainmenuFrm());
            }
            else
            {
                MessageBox.Show("Invalid username/password, please try again.");
            }
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
