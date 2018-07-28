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
        static List<string> students = new List<string>();
        static List<string> ages = new List<string>();
        static List<string> hometowns = new List<string>();
        static List<string> foods = new List<string>();

        static void Main()
        {
            do
            {
                if(students.Count == 0)
                {
                    Console.WriteLine("Please add a student and their information");
                    AddStudent();
                }
                string addOrLearn = Ask("Would you like to add a student or read information about one? (add/read)", @"^\b(add|read)\b$", "Please choose a proper option.").ToLower();
                if(addOrLearn == "add")
                {
                    AddStudent();
                }
                else if(addOrLearn == "read")
                {
                    int userNum = Ask("Which student would you like to know about (enter a number).", students.Count, $"Please be sure you enter a number between 1 and {students.Count}");
                    string userInfo = Ask($"What would you like to know about {students[userNum - 1]}? (age, hometown or favorite food)", @"^\b(age|hometown|favorite food)\b$", "Please ensure you are entering a proper option.").ToLower();
                    WriteInfo(userNum, userInfo, students[userNum - 1], ages[userNum - 1], hometowns[userNum - 1], foods[userNum - 1]);
                }
            }
            while (Continue() == 1);
        }

        static int Ask(string question, int max, string errorMessage)
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

        static string Ask(string question, string pattern, string errorMessage)
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

        static void WriteInfo(int userNum, string userQuestion, string name, string age, string hometown, string favoriteFood)
        {
            if (userQuestion == "age")
            {
                Console.WriteLine($"Student #{userNum} is {name}. They are {age} years old");
            }
            else if (userQuestion == "hometown")
            {
                Console.WriteLine($"Student #{userNum} is {name}. They are from {hometown}.");
            }
            else if (userQuestion == "favorite food")
            {
                Console.WriteLine($"Student #{userNum} is {name}. Their favorite food is {favoriteFood}.");
            }
        }

        static void AddStudent()
        {
            string stuName = "";
            do
            {
                Console.WriteLine("Please enter this student's name.");
                stuName = Console.ReadLine();
                Console.Clear();
                if (stuName == "" || stuName == " ")
                {
                    Console.WriteLine("Please enter a name.");
                }
                else
                {
                    students.Add(stuName);
                }
            }
            while (stuName == "" || stuName == " ");

            string stuAge = "";
            do
            {
                Console.WriteLine("Please enter this student's age");
                stuAge = Console.ReadLine();
                Console.Clear();
                if (stuAge == "" || stuAge == " ")
                {
                    Console.WriteLine("Please enter an age.");
                }
                else
                {
                    ages.Add(stuAge);
                }
            }
            while (stuAge == "" || stuAge == " ");

            string stuTown = "";
            do
            {
                Console.WriteLine("Please enter this student's hometown.");
                stuTown = Console.ReadLine();
                Console.Clear();
                if (stuTown == "" || stuTown == " ")
                {
                    Console.WriteLine("Please enter a town.");
                }
                else
                {
                    hometowns.Add(stuTown);
                }
            }
            while (stuTown == "" || stuTown == " ");

            string stuFood = "";
            do
            {
                Console.WriteLine("Please enter this student's favorite food.");
                stuFood = Console.ReadLine();
                Console.Clear();
                if (stuFood == "" || stuFood == " ")
                {
                    Console.WriteLine("Please enter a food.");
                }
                else
                {
                    foods.Add(stuFood);
                }
            }
            while (stuFood == "" || stuFood == " ");
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
