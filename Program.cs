using System;

namespace carMake
{
    class Program
    {
        static void Main(string[] args)
        {
            Car thisCar = new Car();

            thisCar.Make = "Toyota";
            thisCar.Made = "Cambry";
            thisCar.Year = "2019";

            Console.WriteLine($"The car is {thisCar.Make} {thisCar.Made} {thisCar.Year}");

        }
    }
}
