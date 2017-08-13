using System;

namespace _9950163_task1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables for Celcius and Fahrenheit
            double Celcius = 0;
            double Fahrenheit = 0;

            Console.WriteLine("This program will convert Celcius to Fahrenheit");
            
            //ask for user input
            Console.WriteLine("\r\nEnter either Celcius or Fahrenheit: ");
            //store the users input
            string userChoice = Console.ReadLine();

            if(userChoice == "Celcius")
            {
                //asks user for an amount in Celcius
                Console.WriteLine("Enter the amount of Celcius you want to convert");
                Celcius = double.Parse(Console.ReadLine());
                //set the calculation to convert Celcius to Fahrenheit
                Celcius = Fahrenheit - 32 * 5 / 9;
                //outputs the Fahrenheit value
                Console.WriteLine("That in Fahrenheit is: ", Celcius);
            }
            else if(userChoice == "Fahrenheit")
            {
                //asks user for an amount in Fahrenheit
                Console.WriteLine("Enter the amount of Fahrenheit you want to convert");
                Fahrenheit = double.Parse(Console.ReadLine());
                //set the calculation to convert Fahrenheit to Celcius
                Fahrenheit = Celcius * 9 / 5 + 32;
                //outputs the Celcius value
                Console.WriteLine("That in Celsius is: ", Fahrenheit);
            }
            Console.ReadLine();
        }
    }
}
