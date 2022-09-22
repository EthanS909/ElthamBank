using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElthamBank
{
    class Savings : Account
    {
        private double IR;

        public Savings(double iR, double bal, string accName, int age) : base(bal, accName, age)
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
            double interest = IR / 100;
            for (int x = 0; years > x; x++)
            {
                changeBal(getBal() * interest);
            }
            return getBal();
        }
    }
}
