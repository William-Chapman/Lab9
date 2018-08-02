using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class NewCar : Car
    {
        public NewCar() : base()
        {

        }

        public NewCar(string ma, string mo, int y, double p)
            : base(ma, mo, y, p)
        {
            
        }

        public override void PrintInfo()
        {
            const string format = "{0, -10} {1, -10} {2, -10} {3, -10}";
            Console.WriteLine(string.Format(format, "Make", "Model", "Year", "Price"));
            Console.WriteLine(string.Format(format, Make, Model, Year, $"${Price:c}"));
        }
    }
}
