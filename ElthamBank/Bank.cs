using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace ElthamBank
{
    class Bank
    {
        private string bankName = "Ethan Bank";

        private Current[] CA = new Current[100];
        private Savings[] SA = new Savings[100];
        private Student[] StA = new Student[100];
        private int CAcreated = 0;
        private int SAcreated = 0;
        private int StAcreated = 0;

        public Bank()
        {

        }

        public string openAccount(double bal, string name, int age, string type, double IR, int overdraft)
        {
            if (type == "Current")
            {
                CA[CAcreated] = new Current(bal, name, age);
                CAcreated++;
                return Convert.ToString(CAcreated - 1);
            }
            if (type == "Savings")
            {
                SA[CAcreated] = new Savings(IR, bal, name, age);
                SAcreated++;
                return Convert.ToString(SAcreated - 1);
            }
            if (type == "Student")
            {
                StA[CAcreated] = new Student(overdraft, bal, name, age);
                StAcreated++;
                return Convert.ToString(StAcreated - 1);
            }
            else
            {
                return "Not a valid account type";
            }
        }

        public string withdraw(double withdraw, string type)
        {
            if (type == "Current")
            {
                CA[CAcreated - 1].withdraw(withdraw);
                return Convert.ToString(CA[CAcreated - 1].getBal());
            }
            if (type == "Savings")
            {
                SA[SAcreated - 1].withdraw(withdraw);
                return Convert.ToString(SA[SAcreated - 1].getBal());
            }
            if (type == "Student")
            {
                StA[StAcreated - 1].withdraw(withdraw);
                return Convert.ToString(StA[StAcreated - 1].getBal());
            }

            return "No Valid Account Created";
        }
    }
}
