using System;

namespace _9950163_task1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius = 0;
            double Fahrenheit = 0;

            Console.WriteLine("This program will convert Celcius to Fahrenheit");
            
            Console.WriteLine("\r\nEnter either Celcius or Fahrenheit: ");
            string userChoice = Console.ReadLine();

            if(userChoice == "Celcius")
            {
                Console.WriteLine("Enter the amount of Celcius you want to convert");
                Celcius = double.Parse(Console.ReadLine());
                Celcius = Fahrenheit - 32 * 5 / 9;
                Console.WriteLine("That in Fahrenheit is: ", Celcius);
            }
            else if(userChoice == "Fahrenheit")
            {
                Console.WriteLine("Enter the amount of Fahrenheit you want to convert");
                Fahrenheit = double.Parse(Console.ReadLine());
                Fahrenheit = Celcius * 9 / 5 + 32;
                Console.WriteLine("That in Celsius is: ", Fahrenheit);
            }
            Console.ReadLine();
        }
    }
}
