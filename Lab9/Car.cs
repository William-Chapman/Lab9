using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 1111;
            Price = 11.11;
        }

        public Car(string ma, string mo, int y, double p)
        {
            Make = ma;
            Model = mo;
            Year = y;
            Price = p;
        }

        public virtual void PrintInfo()
        {
            const string format = "{0, -10} {1, -10} {2, -10} {3, -10}";
            Console.WriteLine(string.Format(format, "Make", "Model", "Year", "Price"));
            Console.WriteLine(string.Format(format, Make, Model, Year, $"${Price:c}"));
        }
    }
}
