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
    public partial class CreateAccountFrm : Form
    {
        public CreateAccountFrm()
        {
            InitializeComponent();
        }

        private bool UsernameExists(string username)
        {
            string allUsersFilePath = Path.Combine(Application.StartupPath, "All_User_Accounts.txt");
            try
            {
                if (File.Exists(allUsersFilePath))
                {
                    string[] lines = File.ReadAllLines(allUsersFilePath);
                    // Skip the header line by starting the loop from index 1
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] columns = lines[i].Split(',');
                        // Checking the Username field (index 3)
                        if (columns.Length > 3 && columns[4].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            return true; // Username found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username: {ex.Message}");
            }
            return false; // Username not found
        }



        private string GenerateUserID(int length)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(chars);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameInput.Text;
            string lastName = lastNameInput.Text;
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            double checkingAccountBalance = 0.00; //Account balance initialized at 0
            double savingsAccountBalance = 0.00; //Savings account balance initialized at 0

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if the username already exists
            if (UsernameExists(username))
            {
                MessageBox.Show("This username is already taken. Please choose another one.");
                return;
            }

            //generates a random user ID
            string userID = GenerateUserID(20);
            string filename = $"Account_Information_{firstName}_{lastName}.txt";
            string filepath = Path.Combine(Application.StartupPath, filename);

            // Add username and password to All_User_Accounts.txt
            string allUsersFilePath = Path.Combine(Application.StartupPath, "All_User_Accounts.txt");
            using (StreamWriter writer = new StreamWriter(allUsersFilePath, true))
            {
                // Checks if the file is new or empty and add headers if necessary.
                if (new FileInfo(allUsersFilePath).Length == 0)
                {
                    writer.WriteLine("UserID,First Name,Last Name,Username,Password,Checking Account Balance,Savings Account Balance");
                }

                // Write user information in CSV format
                writer.WriteLine($"{userID},{firstName},{lastName},{username},{password},${checkingAccountBalance},${savingsAccountBalance}");

                MessageBox.Show($"Account created successfully! File saved: {filename}");
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_LoginFrm settingsForm = new Form1_LoginFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }

        private void CreateAccountFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
