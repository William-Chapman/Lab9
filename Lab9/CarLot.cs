using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CarLot
    {
        private List<Car> cars;
        private List<NewCar> newCars;
        private List<UsedCar> usedCars;

        public List<Car> Cars { set; get; }
        public List<NewCar> NewCars { set; get; }
        public List<UsedCar> UsedCars { set; get; }

        public CarLot(NewCar newCar)
        {
            Cars.Add(newCar);
            NewCars.Add(newCar);
        }

        public CarLot(UsedCar usedCar)
        {
            Cars.Add(usedCar);
            UsedCars.Add(usedCar);
        }

        public static void InitList()
        {
            NewCar n1 = new NewCar();
            n1.Make = "Tesla";
            n1.Model = "Model S";
            n1.Year = 2018;
            n1.Price = 165000;

            NewCar n2 = new NewCar();
            n2.Make = "Dodge";
            n2.Make = "Demon";
            n2.Year = 2018;
            n2.Price = 84000;

            NewCar n3 = new NewCar();
            n3.Make = "DF";
            n3.Model = "Goblin";
            n3.Year = 2018;
            n3.Price = 15000;

            UsedCar u1 = new UsedCar();
            u1.Make = "Chevy";
            u1.Model = "Impala";
            u1.Year = 2008;
            u1.Price = 2000;
            u1.Milage = 150000;

            UsedCar u2 = new UsedCar();
            u2.Make = "Jeep";
            u2.Model = "Wrangler";
            u2.Year = 2016;
            u2.Price = 15000;
            u2.Milage = 65000;

            UsedCar u3 = new UsedCar();
            u3.Make = "GMC";
            u3.Model = "Astro";
            u3.Year = 2005;
            u3.Price = 500;
            u3.Milage = 300000;

            Cars.Add(n1);
            NewCars.Add(n1);
            Cars.Add(n2);
            NewCars.Add(n2);
            Cars.Add(n3);
            NewCars.Add(n3);
            Cars.Add(u1);
            UsedCars.Add(u1);
            Cars.Add(u2);
            UsedCars.Add(u2);
            Cars.Add(u3);
            UsedCars.Add(u3);
        }
    }
}
