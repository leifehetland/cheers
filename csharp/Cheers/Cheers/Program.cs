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
            Console.Write("What is your name? ");

            string entry = Console.ReadLine();
            char[] array = entry.ToCharArray();
            string vowels = "halfnorsemix";
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                if (vowels.Contains(letter))
                {
                    Console.WriteLine("Give me an " + letter + "..." + letter);
                }
                else
                {
                    Console.WriteLine("Give me a " + letter + "..." + letter);
                }
            }
            Console.Write(entry.ToUpper() + " is... GRAND!" + "\r\n");
            

            Console.Write("What is your birthday?");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            DateTime todayIs = DateTime.Today;
            var myBdayArray = userInput.Split('/');
            int m = int.Parse(myBdayArray[0]);
            int d = int.Parse(myBdayArray[1]);
            DateTime myBday = new DateTime(todayIs.Year, m, d);

            Console.WriteLine(myBday);
            if (todayIs == myBday)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else if (myBday > todayIs)
            {
                TimeSpan difference = myBday - todayIs;
                Console.WriteLine("Your birthday is " + difference.Days + " days away!");

            }
            else if (myBday < todayIs)
            {
                 myBday = new DateTime(todayIs.Year + 1, m, d);
                TimeSpan difference = myBday - todayIs;
                Console.WriteLine("Your birthday is " + difference.Days + " days away!");
            }
            Console.ReadLine();

        }
    }
}
