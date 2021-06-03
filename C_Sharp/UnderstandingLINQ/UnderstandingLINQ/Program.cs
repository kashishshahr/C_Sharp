using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCar = new List<Car>()
            {
                new Car(){VIN="A1",Make="BMW",Model="550i",StickerPrice=55000,Year=1980},
                new Car(){VIN="B2",Make="Toyota",Model="4Runner",StickerPrice=35000,Year=1982},
                new Car(){VIN="C3",Make="BMW",Model="745li",StickerPrice=75000,Year=1985},
                new Car(){VIN="D4",Make="Ford",Model="Escape",StickerPrice=25000,Year=1978},
                new Car(){VIN="E5",Make="BMW",Model="55i",StickerPrice=57000,Year=1990}
            };

            //LINQ query
            //Language Integrated Query
            var bmws = from car in myCar
                       where car.Make == "BMW" && car.Year>1980
                       select car;
            var orderedCars1 = from car in myCar
                              orderby car.Year descending
                              select car;
            var orderedCars2 = myCar.OrderByDescending(p => p.Year);
            var car1 = myCar
                .OrderByDescending(p=>p.Year)
                .First(p => p.Make=="BMW");

            //LINQ method 
            var bmws1 = myCar.Where(p => p.Make == "BMW" && p.Year>1970);
            //foreach(var car in orderedCars){
            //Console.WriteLine("{2} {0} {1}",car1.Year,car1.Model,car1.VIN); 
            //myCar.ForEach(p=> Console.WriteLine("Year>1970?\n"+p.Year));
            //Console.WriteLine(myCar.TrueForAll(p => p.Year > 1970));
            //Console.WriteLine(myCar.Exists(p => p.Year == 1980));
            //Console.WriteLine(myCar.Sum(p=>p.StickerPrice));
            Console.WriteLine(myCar.GetType());
            Console.WriteLine(orderedCars1.GetType());


            //}


            var newCars = from car in myCar
                          where car.Make == "BMW"
                          && car.Year > 1980
                          select new { car.Make,car.Model };
            
            Console.WriteLine(newCars.GetType());

            Console.Read();
        }
    }
        class Car
        {
            public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice{ get; set; }
        }
}
