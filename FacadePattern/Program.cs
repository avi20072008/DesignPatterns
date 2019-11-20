using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Bank;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction Start");

            FacadeATM atm = new FacadeATM();
            atm.ValidateCard(124, 1234);
            atm.WithdrawCash(100);

            Console.WriteLine("Transaction Finished");

            Console.ReadLine();
        }
    }
}
