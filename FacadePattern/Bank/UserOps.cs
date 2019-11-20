using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Bank;

namespace FacadePattern.Bank
{
    public class UserOps
    {
        private bool _IsUserValid = false;
        public User getUserInfo(int CardNumber, int PIN)
        {
            User user = new User
            {
                Id = 1, Name = "Robert"
            };

            return user;
        }

        public bool ValidateUser(User user)
        {
            if(user != null)
            {
                _IsUserValid = true;
            }
            else
            {
                _IsUserValid = false;
            }

            return _IsUserValid;
        }
    }
}
