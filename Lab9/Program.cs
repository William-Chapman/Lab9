using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        static List<Car> cars = new List<Car>();

        static void Main()
        {
            do
            {
                if(cars.Count == 0)
                {
                    Console.WriteLine("Please add a car and its information.");
                    CarApp.AddListing(cars);
                }
                string addOrLearn = CarApp.Ask("Would you like to add a car or read the information about one? (add/read)", @"^\b(add|read)\b$", "Please choose a proper option.").ToLower();
                if(addOrLearn == "add")
                {
                    CarApp.AddListing(cars);
                }
                else if(addOrLearn == "read")
                {
                    CarApp.WriteInfo(cars);
                    int userNum = CarApp.Ask("Which car would you like to know about (enter a number).", cars.Count, $"Please be sure you enter a number between 1 and {cars.Count}");
                    CarApp.WriteInfo(cars, userNum);
                }
            }
            while (Continue() == 1);
        }
        
        static int Continue()
        {
            string response;
            int situ = 3;
            while (situ == 3)
            {
                Console.WriteLine("Continue ? (y/n): ");
                response = Console.ReadLine().ToLower();
                Console.Clear();

                if (response == "y" || response == "yes")
                {
                    //if yes, restart at main
                    situ = 1;
                }
                else if (response == "n" || response == "no")
                {
                    //if no, exit
                    situ = 0;
                }
                else if (response != "n" || response != "no" || response != "y" || response != "yes")
                {
                    situ = 3;
                }

                if (situ == 3)
                {
                    Console.WriteLine("Please enter valid response.");
                }
            }
            return situ;
        }
    }
}
