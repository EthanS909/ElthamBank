using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElthamBank
{
    class Savings : Account
    {
        private double IR;

        public Savings(double iR, double bal, string accName, string accNum) : base(bal, accName, accNum)
        {
            IR = iR;
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

        public double fastForward(int years)
        {
            for (int x = 0; years > 0; x++)
            {
                return getBal();
            }
        }
    }
}
