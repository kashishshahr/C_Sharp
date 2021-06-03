using System;
namespace Hello
{
    class SimpleClasses
    {
        static void ClassesMain(string[] args)
        {
            Car myCar=new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year=1986;
            myCar.Color = "Silver";
            Console.WriteLine("{0}, {1},{2},{3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            decimal carValue=myCar.DetermineMarketValue();
            Console.WriteLine("{0:C}", carValue);
            Console.Read();
        }
       
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Yearr{ get; set; }
        public string Color { get; set; }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public decimal DetermineMarketValue()
        {
            decimal carValue = 100.0M;
            if(Year>1990)
            {
                carValue=10000;
            }
            else
            {
                carValue = 2000;

            }
            return carValue;
        }
    }
}
