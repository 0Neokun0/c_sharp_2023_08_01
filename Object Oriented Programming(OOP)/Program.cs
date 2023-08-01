using System;
namespace Object_Oriented_Programming_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4", 250, "blue");
            audi.Drive();
            audi.Details();
            Car bmw = new Car("BMW M5", 350);
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car!");

            string userInput = Console.ReadLine();
            if(userInput == "1")
                    {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely.");
            }

        }
    }
}
