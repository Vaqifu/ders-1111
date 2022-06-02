using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Usubzade");


                user1.Password = "Salamatcilq1";

            Console.WriteLine($"  {user1.UserName} Password {user1.Password}");

        }
    }
}
