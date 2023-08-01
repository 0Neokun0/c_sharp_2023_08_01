using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";

            while (string.IsNullOrEmpty(enteredText))
            {
                Console.WriteLine("Please press enter to increase the amount by one, or type anything else and press enter to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }

            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
            Console.Read();
        }
    }
}

