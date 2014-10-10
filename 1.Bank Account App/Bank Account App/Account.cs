using System;

namespace Bank_Account_App
{
    public class Account
    {
        public string Number { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public Account(string number, string openingDate) : this()
        {
            Number = number;
            OpeningDate = openingDate;
        }

        public Account()
        {
            Balance = 0;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
           // return "Deposited";
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
               // return "Withdrawn";
            }
            else
            {
                throw new Exception();
                //return "No sufficient balance to withdraw";
            }
        }


        

    }
}