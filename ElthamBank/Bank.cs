using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElthamBank
{
    class Bank
    {
        private string bankName;

        private Current[] CA;
        private int createdAccounts = 0;

        public Bank(string bankName, string name, int age, double bal)
        {
            this.bankName = bankName;
        }

        public int open(double bal, string name, int age)
        {
            CA[createdAccounts] = new Current(bal, name, age);
            createdAccounts++;

            return createdAccounts;
        }
    }
}
