using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    class ReflectionPractice
    {
        static void ReflectionMain(string[] args)
        {
            
            Type t = Type.GetType("System.Console");
            Customer c=new Customer();
            Type t1 = c.GetType();
            Type t2 = typeof(Customer);
            PropertyInfo[] propertyInfos = t.GetProperties();

            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Name);
            Console.WriteLine("..................................................\n");

            foreach (PropertyInfo property in propertyInfos)
            {
                
                Console.WriteLine(property.PropertyType+" "+property.PropertyType.Name);
                Console.WriteLine(property.Name);
                Console.WriteLine("\n==================================================================\n");

            }
            Console.Write("Methods:");
            MethodInfo[] methods= t.GetMethods();

            foreach (MethodInfo method in methods)
            {

                Console.WriteLine(method.Name +" "+method.ReturnType.Name);
                    Console.WriteLine("==================================================================");

            }
            ConstructorInfo[] ctors= t1.GetConstructors();
            Console.WriteLine("Ctors:");
            foreach (ConstructorInfo ctor in ctors)
            {

                Console.WriteLine(ctor.Name +" ");
                Console.WriteLine("Params:");
                foreach (ParameterInfo p in ctor.GetParameters())
                {
                    Console.WriteLine(p.Name + " ");

                }
                Console.WriteLine("==================================================================");

            }
           
            Console.Read();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Customer()
        {
            Id = -1;
            Name = string.Empty;
        }
        public void PrintId()
        {
                Console.WriteLine("ID={0}",Id);

        }
        public void PrintName()
        {
                Console.WriteLine("Name={1}",null,Name);

        }

    }
}
