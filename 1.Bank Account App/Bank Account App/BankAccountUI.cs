using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_App
{
    public partial class BankAccountUI : Form
    {
        private Customer customerObj;
        private double amount;

        public BankAccountUI()
        {
            InitializeComponent();
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            customerObj = new Customer();
            Account anAccount = new Account(accountNumberEntryTextBox.Text,
            openingDateEntryTextBox.Text);
            customerObj.Name = customerNameEntryTextBox.Text;
            customerObj.Email = emailEntryTextBox.Text;
            customerObj.CustomerAccount = anAccount;
            MessageBox.Show(customerObj.Name + " has opened an account with " +
                            customerObj.CustomerAccount.Number + " number");

        }

        private void depositeButton_Click(object sender, EventArgs e)
        {

            amount = Convert.ToDouble(amountTextBox.Text);
            customerObj.CustomerAccount.Deposit(amount);
          //  if (customerObj.AnAccount.Deposit(amount))
            //{
                MessageBox.Show(amount + " Tk. has been deposited");
            //}
            //else
            //{
            //    MessageBox.Show("Operation failed");
           // }

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

            amount = Convert.ToDouble(amountTextBox.Text);
            try
            {

                customerObj.CustomerAccount.Withdraw(amount);
                MessageBox.Show(amount + " Tk. has been withdrawn");
            }
            catch (Exception)
            {
                MessageBox.Show("Not possible, your are vey poor");
                // throw;
            }
          //  if (customerObj.AnAccount.Withdraw(amount))
            //{
                
            //}
            //else
           // {
             //   MessageBox.Show("Insufficient amount");
            //}

        }

        private void showMeDetailsButton_Click(object sender, EventArgs e)
        {

            customerNameDisplayTextBox.Text = customerObj.Name;
            emailDisplayTextBox.Text = customerObj.Email;
            accountNumberDisplayTextBox.Text = customerObj.CustomerAccount.Number;
            openingDateTextBox.Text = customerObj.CustomerAccount.OpeningDate;
            balanceDisplayTextBox.Text = customerObj.CustomerAccount.Balance.ToString();

        }

    }
}
