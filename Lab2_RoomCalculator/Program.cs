using System;

namespace Lab2_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // const UNITS
            const string UNITS = "feet";

            string input = "y";
            Boolean valid = false;

            // variable declarations
            double length;
            double width;
            double height;

            // result declarations
            double perimeter;
            double area;
            double volume;

            string result = "";

            Console.WriteLine("Room Calculator\n");

            while (input == "y")
            {
                // prompt and get input.
                Console.WriteLine($"Enter length of the room in {UNITS}: ");
                input = Console.ReadLine();
                length = double.Parse(input);

                Console.WriteLine($"Enter width of the room in {UNITS}: ");
                input = Console.ReadLine();
                width = double.Parse(input);

                Console.WriteLine($"Enter height of the room in {UNITS}: ");
                input = Console.ReadLine();
                height = double.Parse(input);
                

                // calculate results
                perimeter = width * 2 + length * 2;
                area = width * length;
                volume = area * height;

                result = $"Perimeter: {perimeter} {UNITS}.\nArea: {area} square {UNITS}.\nVolume: {volume} cubic {UNITS}.";
                Console.WriteLine(result);

                valid = false;
                while (!valid)
                {
                    //ask again
                    Console.WriteLine("\nWould you like to calculate another room? (y/n)\n");
                    input = Console.ReadLine();
                    input = input.Substring(0,1).ToLower();
                    if ((input == "y") | (input == "n"))
                        valid = true;
                    else
                        Console.WriteLine("Invalid entry. Try again.");
                }
            }
        }
    }
}
