using System;
using System.Collections.Generic;
using System.Text;

namespace ElthamBank
{
    class Savings : Account
    {
        private double IR;

        public Savings(double iR)
        {
            IR = iR;
        }
    }
}
