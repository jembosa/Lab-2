using System;
using System.ComponentModel.Design;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stoploop = "";
            int answer = 0;

            Console.WriteLine("Hello, what is your name?");

            string name = Console.ReadLine();

            
            while (stoploop == "")
            {
                Console.WriteLine($"Hello {name}, please enter a number between 1 and 100 ");

                while (true)
                {
                    answer = int.Parse(Console.ReadLine());

                    if (answer <= 0 || answer > 100)
                    {
                        Console.WriteLine($"{name}, it clearly says between 1 and 100 dude. Please enter a number between 1 and 100.");
                    }
                    else
                    {                        
                        break;
                    }
                }
                //odd
                if (answer % 2 != 0)

                    if (answer < 60)
                    {
                        Console.WriteLine($"{name}, your number is {answer}, odd, and less than 60");
                    }
                    else if (answer > 60)
                    {
                        Console.WriteLine($"{name}, your number is {answer}, odd, and greater than 60");
                    }
                //even
                if (answer % 2 == 0)

                    if (answer < 24 && answer > 0)
                    {
                        Console.WriteLine($"{name}, your number is {answer}, even, and less than 25");
                    }
                    else if (answer < 60 && answer > 0)
                    { Console.WriteLine($"{name}, your number is {answer}, even, and between 24 and 60 inclusively"); }

                    else if (answer > 60)
                    {
                        Console.WriteLine($"{name}, your number is {answer}, even, and greater than 60");

                    }

                //ask to stop here
                Console.WriteLine("Enter 'stop' to exit.");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "stop")
                {
                    break;
                }
            }//end stop loop
        }
    }
}

