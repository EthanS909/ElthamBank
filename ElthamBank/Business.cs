using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Business : Account
    {
        public Business(double bal, string accName, string accNum) : base(bal, accName, accNum)
        {

        }
        public void withdraw(double amount)
        {
            if (amount < getBal())
            {
                changeBal(-amount);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }
    }
}
