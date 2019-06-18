using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Redmond Library!");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Checkout a book");
                Console.WriteLine("3. Check in book");
                Console.WriteLine("4. See books in stock");
                Console.WriteLine("5. See your account information");

                Console.Write("Select an option: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Redmond Library!\n");
                        Console.WriteLine();
                        return;
                    case "1":
                        Console.Write("Set up account information here\n");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("Show books in stock\n");
                        Console.Write("Ask what book whats\n");
                        Console.Write("Assign book to user\n");
                        Console.Write("Ask if done - if yes exit else repeat\n");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Write("Ask account info\n");
                        Console.Write("Ask what book whats to give back\n");
                        Console.Write("Check back in\n");
                        Console.Write("Ask if done - if yes exit else repeat\n");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Print out list of books in stock\n");
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.Write("Print out all account info\n");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Your selection is not included in the options listed. Please try again.\n");
                        Console.WriteLine();
                        break;

                }
            } 
        }
    }
}
