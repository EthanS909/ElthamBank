using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Business : Account
    {
        public Business(double bal, string accName, int age) : base(bal, accName, age)
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
