using System;

namespace Assignment2_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Intouch = new Account("Inn", 1000000);
            Console.WriteLine(Intouch.CheckBalance());


        }
    }
}
