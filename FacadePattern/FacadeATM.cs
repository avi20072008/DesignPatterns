using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Bank; 

namespace FacadePattern
{
    public class FacadeATM
    {
        private bool _validateUser = false;
        private int _userID;

        public void ValidateCard(int CardNo, int Pin)
        {
            UserOps userOps = new UserOps();
            User user = userOps.getUserInfo(CardNo, Pin);
            bool validateUser = userOps.ValidateUser(user);

            _validateUser = validateUser;
            _userID = user.Id;
        }

        public void WithdrawCash(int amount)
        {
            if (_validateUser)
            {
                BankOps bankOps = new BankOps();
                bankOps.getUserBankBalance(_userID);
                bankOps.withdrawCash(amount);
                bankOps.printReceipt();
            }
        }
    }
}
