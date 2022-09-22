using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Student : Account
    {
        private double overdraft;

        public Student(double overdraft, double bal, string accName, int age) : base(bal, accName, age)
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
