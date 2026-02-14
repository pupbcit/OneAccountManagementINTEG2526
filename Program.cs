using System;

namespace OneAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCOUNT MANAGEMENT SYSTEM");

            string username = "admin";
            string password = "admin123!";

            Console.Write("Enter username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == username && passwordInput == password)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }
    }
}
