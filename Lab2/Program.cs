using System;
using System.ComponentModel.Design;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 0;
            Console.WriteLine("Hello, what is your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, please enter a number between 1 and 100 ");
            answer = int.Parse(Console.ReadLine());
            while (true)
            {
                if (answer <=0 )
                    Console.WriteLine("It clearly says between 1 and 100 dude. Press any any and get out of here.");
                                if (answer > 100)
                {
                    {
                        Console.WriteLine("It clearly says between 1 and 100 dude. Press any any and get out of here.");
                            
                        Console.ReadKey();
                        return;
                    }
                }
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

                else if (answer >60)
                {
                    Console.WriteLine($"{name}, your number is {answer}, even, and greater than 60");

                }

        }
    }
}





