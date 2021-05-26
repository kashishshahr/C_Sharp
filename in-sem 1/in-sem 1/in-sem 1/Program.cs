using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1
{
    class Program
    {
        static void Q1Main(string[] args)
        {
            int a = 10, b = 20;
            int sum = Calculator.AddNums(a, b);
            

            string output = "The sum of "+a+" and "+b+" is "+ sum;
            Console.WriteLine(output);
            Console.Read();
        }
    }
    class Calculator
    {
        public static int AddNums(int a,int b)
        {
            return a + b;
        }
    }
}


namespace Q2
{
    //    Q2.
    //What is the output of following program(assume it works).
    using System;
    class Program
    {
        static void Q2Main(string[] args)
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
            Console.Read();
        }
    }
    //    /*write your answer in the space below*/
    //Output :
    //hello world
    //
    //bcz Replace Returns a new string in which all occurrences of a specified string in the current
        //     instance are replaced with another specified string.

}

namespace Q3
{
    //    Q3.
    //Modify the code block below(represented by the comment) so that it will throw error at runtime if data
    //overflow occurs.
    // class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            /*
    //            * code block with lots of number calculations
    //            */
    //        }
    //    }
    class Program
    {
        private int _val;
        public int val
        {
            get
            {
                return val == 10 ? 1 : 0;//Because this is returning itself
            }
            set
            {
                _val = value;
            }
        }
        static void Q3Main(string[] args)
        {
            Program p = new Program();
            p.val = 4;
            Console.WriteLine(p.val);
            //System.StackOverflowException: 'Exception of type 'System.StackOverflowException' was thrown.'

            /*
            * code block with lots of number calculations
            */
            int[] a=new int[5];
            for(int i=0;i<6;i++)
            {
                a[i] = i;
            }
            //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

        }
    }

}

//Q4.
//Re - write the following code replacing the type declaration(s) with var keyword such that the
//program continues to compile without errors.
namespace Q4
{
    class Program
    {
        static void Q4Main(string[] args)
        {
            KnowVar kv = new KnowVar();
            kv.MyMethod(5,6);
        }
    }
    class KnowVar
    {
        //var _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            int n;
            string mul;
            n = i * j;
            mul = "The multiplication";
            var ob = new Program();
            KnowVar ob2 = null;
        }

    }
}

namespace Q5_Q6
{
    class Q5
    {
    //    Q5.
    //Complete the function AnArray() in the following program.The code in the function should create an
    //array.The 1st element of this array should have integer 10 as it’s value, the 2nd element should have
    //boolean false as its value, the 3rd element should store reference to a DateTime object (use new
    //DateTime(2019,01,01) to create the object). And, the 4th element of the array should have string
    //“sample string”.

    //Write foreach loop in the same function to print the elements of the array.
        static void AnArray()
        {
            /*your answer goes here*/
            DateTime dt = new DateTime(2019, 01, 01);
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(false);
            arr.Add(dt);
            arr.Add("sample string");

            foreach(var item in arr)
            {
                Console.Write(item+"\t");
            }
            Console.ReadLine();
        } static void AnArray2()
        {
            /*your answer goes here*/
            DateTime dt = new DateTime(2019, 01, 01);
            object[] arr = new object[4];
            arr[0] = 10;
            arr[1] = false;
            arr[2] = dt;
            arr[3] = "sample string";
            Console.WriteLine();
            foreach(var item in arr)
            {
                Console.Write(item+"\t");
            }
            Console.ReadLine();
        }
        static void Q5Main(string[] args)
        {
            AnArray();
            AnArray2();
        }
    }
    class Q6
    {
        //        Q6.
        //Write code to define a class Point that has:
        //a) Two read-only automatic public properties X and Y that return int.
        //b) A public constructor that takes two integers x and y as parameters and assigns them to the X
        //and Y properties(read-only properties can be assigned values in the constructor).
        //c) A public function Deconstruct that returns a tuple containing two integer values of X and Y

        static void Q6Main(string[] args)
        {
            Point p = new Point(400,3);
            
            Tuple<int, int> t = p.Deconstruct();

            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
            Console.Read();
        }

    }
    class Point
    {
        private int X { get;  }
        int Y { get;  }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        
        public Tuple<int,int> Deconstruct()
        {
            Tuple<int, int> t = new Tuple<int,int>(X,Y);
            
            return t;
        }
        //public readonly int x1 { get; }
        //public readonly int  z1 { get; }

        

    }
}
namespace Q7
{
//    Following table has information about two products to be sold to customers coming to a grocery shop:
//Product Wholesale Cost Tax Profit margin
//Wheat 5kg Bag 150 5 50
//Refined Oil 5Kg 280 10 70
//Based on content covered in our lectures of this course, design and implement an elegant solution such
//that the following Main() function outputs Total Bill = 770 when a customer purchases two wheat
//bags and one refined oil 5kg bottle. Note that cost price of the item is sum of Wholesale price, Tax and
//Profit margin.
//Instructions / help:
//1. Write separate functions to return cost of each type i.e.WholesaleCost(), Tax() and
//Profit() so that the item’s cost price will be WholesaleCost()+Tax()+Profit().
//2. The class Biller should not see the detail of how cost price of the item is calculated.All it does
//is to iterate over the items in the shopping cart to get their cost prices and return the total bill
//amount i.e.the sum of the cost prices of items in the shopping cart.
//3. No modification of class Buyer is allowed(other than to fill in the blank)
class ShopCart
    {
        public int wsc { get; set; }
        protected int tax { get; set; }
        protected int profit { get; set; }
        public ShopCart(int w,int t,int p)
        {
            wsc = w;
            tax= t;
            profit = p;
        }
        public int WholeSaleCost()
        {
            return wsc;
        }
        public int Tax()
        {
            return tax;
        }
        public int Profit()
        {
            return profit;
        }
    }
class Wheat5kgBag : ShopCart
    {
        public Wheat5kgBag():base(150,5,50)
        {
                
        }

    }
class RefinedOil5kg: ShopCart
    {
        public RefinedOil5kg() : base(280, 10, 70)
        {

        }

    }
class Buyer
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShopCart[3]; // fill this as per your solution
            shoppingCart[0] = new Wheat5kgBag();
            shoppingCart[1] = new Wheat5kgBag();
            shoppingCart[2] = new RefinedOil5kg();
            Biller biller = new Biller();
            float totalBill = biller.CalculateTotalBill(shoppingCart);
            Console.WriteLine($"Total Bill = {totalBill}");
            Console.ReadLine();
        }
    }
    /* write rest of the code below */
    class Biller
    {
        public float CalculateTotalBill(ShopCart[] Cart)
        {
            float total = 0f;
            foreach(ShopCart c in Cart)
            {
                total+=c.WholeSaleCost() + c.Tax() + c.Profit();
            }
            return total;
        }
    }
}
