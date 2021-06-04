using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQwithDEVU
{
    class devuLinq
    {
        static void devuMain(string[] args)
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
                       where car.Make == "BMW" && car.Year > 1980
                       select car;
            var orderedCars1 = from car in myCar
                               orderby car.Year descending
                               select car;
            var orderedCars2 = myCar.OrderByDescending(p => p.Year);
            var car1 = myCar
                .OrderByDescending(p => p.Year)
                .First(p => p.Make == "BMW");

            //LINQ method 
            var bmws1 = myCar.Where(p => p.Make == "BMW" && p.Year > 1970);
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
                          select new { car.Make, car.Model };

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
        public double StickerPrice { get; set; }
    }
}

namespace LinqWithChannel9
{
    class Product
    {
        public Product(string n, int p, int u)
        {
            ProductName = n;
            ProductPrice = p;
            UnitsInStock = u;
        }
        private string _productName;
        private int _productPrice;
        private int _unitsInStock;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public int ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                _productPrice = value;
            }
        }
        public int UnitsInStock
        {
            get
            {
                return _unitsInStock;
            }
            set
            {
                _unitsInStock = value;
            }
        }
    }
    class Customer
    {
        public List<Order> Orders;
        public Customer(string n, string r)
        {
            CustomerName = n;
            Region = r;
        }
        public Customer(string n, string r, List<Order> ol)
        {
            Orders = ol;
            CustomerName = n;
            Region = r;
        }
        private string _CustomerName;
        private string _Region;

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }
        public string Region
        {
            get
            {
                return _Region;
            }
            set
            {
                _Region = value;
            }
        }

    }
    class Order
    {

        public Order(int i, string d)
        {
            OrderId = i;
            OrderDate = d;
        }
        private int _OrderId;
        private string _OrderDate;
        public int OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                _OrderId = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                _OrderDate = value;
            }
        }
    }
    class Linq

    {
        //https://github.com/dotnet/try-samples
        //101 LINQ samples

        static List<Product> GetProductList()
        {
            List<Product> list = new List<Product> { new Product("pen", 10, 5), new Product("Rubber", 40, 0), new Product("Cheese", 40, 0), new Product("Glue", 40, 0), new Product("Socks", 40, 10) };
            return list;
        }
        static int id = 0;
        static List<Customer> GetCustomerList()
        {
            id++;
            List<Order> ol = new List<Order> { new Order(id + 1, "04-06-2021") };
            id++;

            List<Order> ol1 = new List<Order> { new Order(id + 1, "07-06-2021") };
            id++;

            List<Order> ol2 = new List<Order> { new Order(id + 1, "10-06-2021") };
            id++;

            //List<Order> ol3 = new List<Order> { new Order(id + 1, "13-06-2021"), new Order(id + 2, "14-06-2021"), new Order(id + 3, "15-06-2021") };
            List<Order> ol3 = new List<Order> { new Order(id + 1, "13-06-2021") };

            List<Customer> list = new List<Customer> { new Customer("Peter", "WA", ol), new Customer("Nairobi", "WA", ol2), new Customer("Toko", "WA", ol3), new Customer("Kamila", "WA", ol1) };
            return list;
        }
        public static void _1Main(string[] args)
        {
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            List<int> numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;
            Console.WriteLine("Numbers<5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);

            }
            Console.Read();

        }
        public static void productListQueryMain(string[] args)
        {
            List<Product> products = GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;
            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine($"{product.ProductName} is sold out!");
            }
            Console.Read();

        }

        public static void Function_LINQ_Main(string[] args)
        {
            string[] digits = { "Zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            Console.WriteLine("Short Digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($" The word {d} is shorter than its value.");
            }
            Console.Read();
        }

        private static void Function_linq_numbers()
        {
            int[] numberse = { 5, 4, 1, 3, 9, 8, 0 };
            var firstNumbers = numberse.Take(3);
            Console.WriteLine("First 3 Numbers:");
            foreach (var n in firstNumbers)
            {
                Console.WriteLine(n);
            }
        }
        static void Function_LINQ_Customer()
        {

            List<Customer> customers = GetCustomerList();

            var first3WAOrders =
                (
                    from customer in customers
                    from order in customer.Orders
                    where customer.Region == "WA"
                    select (customer.CustomerName, order.OrderId, order.OrderDate)

                ).Take(3);
            Console.WriteLine("First 3 orders in WA");
            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }
        }
        private static void TAKE_WHILE_Function_linq_numbers()
        {
            int[] numberse = { 5, 4, 1, 3, 9, 8, 0, 19, 18, -2 };
            var firstNumbers = numberse.TakeWhile(n => n > 3);//take from begining until that condition is false
            Console.WriteLine(" Numbers less than 3:");
            foreach (var n in firstNumbers)
            {
                Console.WriteLine(n);
            }
        }
        static void BasicMain(string[] args)
        {
            //Function_linq_numbers();
            //Function_LINQ_Customer();
            //TAKE_WHILE_Function_linq_numbers();//take from begining until that condition is false

            Console.Read();

        }


    }

    class SequenceLinq
    {
        static void Main(string[] args)
        {
            var wordsA = new string[] { "cherry", "apple", "berry" };
            var wordsB = new string[] { "cherry", "apple", "berry" };
            var wordsC = new string[] { "cherry", "berry", "apple"  };

            Console.WriteLine(wordsA.SequenceEqual(wordsB));
            Console.WriteLine(wordsA.SequenceEqual(wordsC));

            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };
            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();
            Console.WriteLine("vectorA.Zip(vectorB, (a, b) => a * b).Sum();\n"+dotProduct);

            Console.Read();

        }
    }
}