using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    abstract class Account
    {
        private double balance = 0;
        private string accName;
        private string accNum;

        public double getBal()
        {
            return balance;
        }

        public void addBal(double funds)
        {
            balance += funds;
        }

        public string getName()
        {
            return accName;
        }

        public void setName(string name)
        {
            accName = name;
        }

        public string getAccNum()
        {
            return accNum;
        }

        public void setAccNum(string accNum)
        {
            this.accNum = accNum;
        }
    }
}
