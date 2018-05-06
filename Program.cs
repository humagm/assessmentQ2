using System;
namespace assessmentQ2

{
    class Program
        {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter new car details below:");

            Console.Write("Colour: ");

            var colour = Console.ReadLine();

            Console.Write("Make: ");

            var make = Console.ReadLine();

            Console.Write("Gearbox: ");

            var gearbox = Console.ReadLine();

            Console.WriteLine();


            var car = new Car();

            car.Make = make;

            car.Colour = colour;

            car.Gearbox = gearbox;

            Console.WriteLine(car.DescribeCar());

            Console.ReadKey();

        }

    }

}
