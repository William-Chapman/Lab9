using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class UsedCar : Car
    {
        private double milage;

        public double Milage
        {
            set { milage = value; }
            get { return milage; }
        }

        public UsedCar ():base()
        {
            Milage = 0;
        }

        public UsedCar(string ma, string mo, int y, double p, double m)
            :base(ma, mo, y, p)
        {
            Milage = m;
        }

        public override void PrintInfo()
        {
            const string format = "{0, -10} {1, -10} {2, -10} {3, -10} {4, -10}";
            Console.WriteLine(string.Format(format, "Make", "Model", "Year", "Price", "Milage"));
            Console.WriteLine(string.Format(format, Make, Model, Year, $"${Price:c}", Milage));
        }
    }
}
