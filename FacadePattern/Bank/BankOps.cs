using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Bank;

namespace FacadePattern.Bank
{
    public class BankOps
    {
        private int _currentBalance = 0;
        private bool _transactionResult = false;

        public void getUserBankBalance(int userID)
        {
            _currentBalance = 500;
        }
        public void withdrawCash(int amount)
        {
            if (_currentBalance > amount)
            {
                _currentBalance = _currentBalance - amount;
                Console.WriteLine("After {0} widthrawal, your current balance is {1}", amount,  _currentBalance);
                _transactionResult = true;
            } else
            {
                Console.WriteLine("Insufficient funds");
                _transactionResult = false;
            }
        }

        public void printReceipt()
        {
            if(_transactionResult)
                Console.WriteLine("Transaction successful. Your available Balance is {0}. Printing receipt.....", _currentBalance);
            else
                Console.WriteLine("Transaction failed... Try again.");
        }
    }
}
