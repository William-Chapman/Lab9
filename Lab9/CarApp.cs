using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab9
{
    class CarApp
    {
        public static int Ask(string question, int max, string errorMessage)
        {
            int intResponse;
            do
            {
                Console.WriteLine(question);
                if (Int32.TryParse(Console.ReadLine(), out intResponse))
                {
                    Console.Clear();
                    if (intResponse > max || intResponse < 1)
                    {
                        Console.WriteLine(errorMessage);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number.");
                    intResponse = 0;
                }
            }
            while (intResponse > max || intResponse < 1);
            return intResponse;
        }

        public static string Ask(string question, string pattern, string errorMessage)
        {
            string response;
            do
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
                Console.Clear();
                if (!Regex.IsMatch(response, pattern))
                {
                    Console.WriteLine(errorMessage);
                }
            }
            while (!Regex.IsMatch(response, pattern));
            return response;
        }
            
        public static void WriteInfo(List<Car> cars)
        {
            int i = 1;
            foreach (var item in cars)
            {
                Console.WriteLine($"{i}. {cars[i - 1].Year} {cars[i - 1].Model}");
                i++;
            }
        }

        public static void AddListing(List<Car> cars)
        {
            string choice = "";
            do
            {
                Console.WriteLine("Is this car new or used?");
                string newOrUsed = Console.ReadLine();
                Console.Clear();

                if (newOrUsed.ToLower() == "used")
                {
                    UsedCar temp = new UsedCar();
                    Console.WriteLine("Please provide the car's make.");
                    temp.Make = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Please provide the car's model.");
                    temp.Model = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Please provide the car's year.");
                    temp.Year = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please provide the car's price.");
                    temp.Price = double.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please provide the car's mileage.");
                    temp.Milage = double.Parse(Console.ReadLine());
                    Console.Clear();

                    cars.Add(temp);
                }
                else if (newOrUsed.ToLower() == "new")
                {
                    Car temp = new Car();
                    Console.WriteLine("Please provide the car's make.");
                    temp.Make = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Please provide the car's model.");
                    temp.Model = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Please provide the car's year.");
                    temp.Year = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please provide the car's price.");
                    temp.Price = double.Parse(Console.ReadLine());
                    Console.Clear();

                    cars.Add(temp);
                }
                

                Console.WriteLine("Do you want to add another car? (y/n)");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
            }
            while (choice == "y" || choice == "yes");
        }
    }
}