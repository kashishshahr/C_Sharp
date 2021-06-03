using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//Language Integrated query  
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("OldsMobile","Cutlas Supreme");
            //Object Initializer syntax
            //Car car1 = new Car() { "OldsMobile", "Cutlas Supreme" };
            Car car2 = new Car("Geo","Prism");
            
            Book book1 = new Book("Robert Tabor","Ms .NET XML Web Services","0-000-00000-0");

            ////ArrayLists are dynamically sized to sort remove search
            //ArrayList myList = new ArrayList();
            //myList.Add(car1);
            //myList.Add(car2);
            ////problem here is no easy way to enter type of data for eg
            //myList.Add(book1);
            //myList.Remove(book1);

            //foreach(Car car in myList)
            //{
            //    Console.WriteLine(car.make());
            //}
            //-------------OLD----------

            //Generics....Generic Collection
            //List<T>
            //List<Car> clist = new List<Car>();
            //clist.Add(car1);
            //clist.Add(car2);
            //List<Book> blist = new List<Book>();
            //blist.Add(book1);


            //Generic Dictionary
            //Dictionary<TKey, Value>;
            Dictionary<int, Car> dCar=new Dictionary<int, Car>();
            dCar[0] = car1;
            dCar[1]=(car2);
            Dictionary<string, Car> dSCar=new Dictionary<string, Car>();
            dSCar[car1.vin()] = car1;
            dSCar.Add(car2.vin(), car2);

            
                Console.WriteLine(dSCar["1"].make());
                Console.WriteLine(dSCar["1"].model());

            //Collection Initializer
            List<Car> mylist = new List<Car>() {
            new Car("A","G"),
            new Car("B","J"),
            };
            foreach(Car c in mylist)
            {
                Console.WriteLine(c.make());
            }
            Console.Read();
        }
        class Car
        {
            private static int count=0;
            private string VIN { get; set; }
            private string Make { get; set; }
            private string Model { get; set; }
            public Car()
            {

            }
            public Car(string make, string model)
            {
                Make = make;
                Model = model;
                VIN = (count++).ToString();
            }
            public string vin()
            {
                return VIN;
            }
            public string make()
            {
                return Make;
            }public string model()
            {
                return Model;
            }
        }
        class Book
        {
            private string Author { get; set; }
            private string ISBN { get; set; }
            private string Title { get; set; }
            public Book(string title,string Author,string ISBN)
              {
                this.Title = title;
                this.Author = Author;
                this.ISBN = ISBN;

               }
            public string title()
            {
                return Title;
            }
            public string author()
            {
                return Author;
            }
            public string isbn()
            {
                return ISBN;
            }
        }
    }
}
