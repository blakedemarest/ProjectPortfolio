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
    public partial class balanceFrm : Form
    {
        public balanceFrm()
        {
            InitializeComponent();
            this.FormClosing += FormUtilities.CloseFormHandler;
            UpdateBalanceLabels();
        }

        private void ShowForm(Form form)
        {
            this.Hide(); // Hide the main menu
            form.FormClosed += (s, args) => this.Show(); // Show the main menu again when the form is closed
            form.Show(); // Show the form
        }

        private void checkingsBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void balanceFrm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new mainmenuFrm());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBalanceLabels()
        {
            // Assuming UserSession holds the current balances or has methods to fetch them
            label3.Text = $"${UserSession.CurrentCheckingBalance:0.00}";  // Format as currency
            label4.Text = $"${UserSession.CurrentSavingsBalance:0.00}";   // Format as currency
        }
    }
}
