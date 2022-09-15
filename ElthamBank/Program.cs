using System;

namespace ElthamBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accType;
            string accName;
            string accNum;
            double accBal;

            Console.WriteLine("Enter Account Type");
            accType = Console.ReadLine();

            Console.WriteLine("Enter Account Name");
            accName = Console.ReadLine();

            Console.WriteLine("Enter Account Number");
            accNum = Console.ReadLine();

            Console.WriteLine("Enter Account Balance");
            accBal = Convert.ToInt32(Console.ReadLine());

            if (accType == "Savings")
            {
                Console.WriteLine("Enter Account Intrest Rate");
                double iR = Convert.ToDouble(Console.ReadLine());
                Savings s1 = new Savings(iR);
                s1.setName(accName);
                s1.setAccNum(accNum);
                s1.changeBal(accBal);
            }
        }
    }
}
