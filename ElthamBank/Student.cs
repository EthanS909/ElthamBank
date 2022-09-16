using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Student : Account
    {
        private double overdraft;

        public Student(double overdraft, double bal, string accName, string accNum) : base(bal, accName, accNum)
        {
            this.overdraft = overdraft;
        }

        public void withdraw(double amount)
        {
            if (amount < overdraft + getBal())
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
