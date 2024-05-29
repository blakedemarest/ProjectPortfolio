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
    public partial class mainmenuFrm : Form
    {
        public bool IsWithdrawal { get; set; } // True for withdrawal, false for deposit

        public mainmenuFrm()
        {
            InitializeComponent();
            this.FormClosing += FormUtilities.CloseFormHandler; //Calling the close handler.
        }



        private void ShowForm(Form form)
        {
            this.Hide(); // Hide the main menu

            form.Show(); // Show the form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void withdrawalBtn_Click(object sender, EventArgs e)
        {
            IsWithdrawal = true;
            ChooseAccountFrm settingsForm = new ChooseAccountFrm(true);
            FormUtilities.ShowForm(this, settingsForm);
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            balanceFrm settingsForm = new balanceFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            IsWithdrawal = false;
            ChooseAccountFrm settingsForm = new ChooseAccountFrm(false);
            FormUtilities.ShowForm(this, settingsForm); // Pass false for deposits
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            transferFrm settingsForm = new transferFrm();
            FormUtilities.ShowForm(this, settingsForm);
        }

        private void MainMenuFrm_Load(object sender, EventArgs e)
        {

        }

        private void mainmenuFrm_Load_1(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            FormUtilities.CloseApplication(sender, e);
        }
    }
}
