using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name
            Console.Write("What is your name or type \"quit\" to exit: ");

            string entry = Console.ReadLine();


            // Display user name
            Console.WriteLine("You're name is " + entry);

        }
    }
}
