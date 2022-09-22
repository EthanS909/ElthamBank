using System;

namespace ElthamBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accType;
            string accName;
            double accBal;
            double withdraw;
            int age;
            string bankName;

            bool exit = false;
            string option;

            do
            {
                Console.WriteLine("1 - Open New Account");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Check Account Balance");
                Console.WriteLine("4 - Fast Forward");
                Console.WriteLine("5 - Exit");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter Bank Name");
                    bankName = Console.ReadLine();

                    Console.WriteLine("Enter Name");
                    accName = Console.ReadLine();

                    Console.WriteLine("Enter Age");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Balance");
                    accBal = Convert.ToDouble(Console.ReadLine());

                    Bank b1 = new Bank(bankName, accName, age, accBal);
                    b1.open(accBal, accName, age);

                }
                if (option == "2")
                {

                }
                if (option == "3")
                {

                }
                if (option == "4")
                {

                }
                if (option == "5")
                {
                    exit = true;
                }

            } while (exit == false);

            /*Console.WriteLine("Enter Account Type");
            accType = Console.ReadLine();

            Console.WriteLine("Enter Account Name");
            accName = Console.ReadLine();

            Console.WriteLine("Enter Account Number");
            accNum = Console.ReadLine();

            Console.WriteLine("Enter Account Balance");
            accBal = Convert.ToInt32(Console.ReadLine());

            if (accType == "Savings")
            {
                Console.WriteLine("Enter Account Intrest Rate %");
                double iR = Convert.ToDouble(Console.ReadLine());
                Savings acc = new Savings(iR, accBal, accName, accNum);

                Console.WriteLine("Enter Amount to Withdraw");
                withdraw = Convert.ToDouble(Console.ReadLine());
                acc.withdraw(withdraw);

                Console.WriteLine("Enter Amount of Years to Fast Forward");
                int years = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("New Balance: £{0:0.00}", acc.fastForward(years));
            }

            if (accType == "Student")
            {
                Console.WriteLine("Enter Overdraft Limit");
                double overdraft = Convert.ToDouble(Console.ReadLine());
                Student acc = new Student(overdraft, accBal, accName, accNum);

                Console.WriteLine("Enter Amount to Withdraw");
                withdraw = Convert.ToDouble(Console.ReadLine());
                acc.withdraw(withdraw);
            }

            if (accType == "Current")
            {
                Current acc = new Current(accBal, accName, accNum);

                Console.WriteLine("Enter Amount to Withdraw");
                withdraw = Convert.ToDouble(Console.ReadLine());
                acc.withdraw(withdraw);
            }

            if (accType == "Business")
            {
                if (accBal >= 1000000)
                {
                    Business acc = new Business(accBal, accName, accNum);
                    Console.WriteLine("Enter Amount to Withdraw");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    acc.withdraw(withdraw);
                }
                else
                {
                    Console.WriteLine("Insuficient Funds to Create Business Account");
                }
            }*/
        }
    }
}
