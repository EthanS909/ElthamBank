﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Current : Account
    {
        private bool canCashCheck;

        public Current(double bal, string accName, string accNum) : base(bal, accName, accNum)
        {
            canCashCheck = true;
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
