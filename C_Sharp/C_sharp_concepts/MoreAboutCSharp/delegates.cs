using System;
using System.Collections.Generic;

namespace BasicDelegate_
{
    public delegate void HelloFunctionsDelegate(string Message);
    class Program
    {
        static void BasicDelegateMain(string[] args)
        {
            HelloFunctionsDelegate helloFunctionsDelegate = Hello;
            HelloFunctionsDelegate helloFunctionsDelegate2 = new HelloFunctionsDelegate(Hello);
            Console.Write("Hello ");
            helloFunctionsDelegate("kashish");
            Console.ReadLine();
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
namespace Delegate_1
{
    class Program
    {
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            { return true; }
            else
            {
                return false;
            }
        }
        public static void Delegate_1Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 1 });
            empList.Add(new Employee() { ID = 102, Name = "Mark", Salary = 15000, Experience = 6 });
            empList.Add(new Employee() { ID = 103, Name = "Marine", Salary = 25000, Experience = 15 });
            empList.Add(new Employee() { ID = 104, Name = "Clark", Salary = 5200, Experience = 2 });
            IsPromotable isPromotable = new IsPromotable(Promote);
            IsPromotable isPromotable1 = Promote;


            Employee.PromoteEmployee(empList, isPromotable);
            //Employee.PromoteEmployee(empList,emp=>emp.Experience>=5);//LAMBDAAAAAAAAAAAa
            //Employee.PromoteEmployee(empList,(emp)=> { return emp.Experience >= 5; });

            Console.Read();

        }
    }
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> employeelist, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employeelist)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }

    }

}
namespace MultiCastDelegates
{
    public delegate void SampleDelegate();
    class Program
    {
        public static void MCMain(string[] args)
        {
            //SampleDelegate sampleDelegate = new SampleDelegate(SampleMethod1);
            //sampleDelegate();

            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);
            del4 = del1 + del2 + del3;//Multicast delegate
            del4 -= del2;
            del4();//invokes all3 methods
            del4 += del2;
            Console.WriteLine("-------------");
            del4();


        }
        public static void SampleMethod1()
        {
            Console.WriteLine("Sample1 Called");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("Sample2 Called");
        }
        public static void SampleMethod3()
        {
            Console.WriteLine("Sample3 Called");
        }
    }
}
namespace MultiCastDelegates_1
{
    class MyClass
    {
        public delegate int SampleDelegate();
        public delegate void SampleDelegate1(out int x);

        public static int SampleMethod1()
        {
            Console.WriteLine("Sample1 Called");
            return 1;
        }
        public static int SampleMethod2()
        {
            Console.WriteLine("Sample1 Called");
            return 2;
        }
        public static void SampleMethod21(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethod22(out int Number)
        {
            Number = 2;
        }
        static void DelegReturnMain(string[] args)
        {
            SampleDelegate del1, del2,del3;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = del1 + del2;
            Console.WriteLine(del3());


            SampleDelegate1 dell=new SampleDelegate1(SampleMethod21);
            dell += new SampleDelegate1(SampleMethod22);
            int x=-1;
            dell(out x);
            Console.WriteLine(x);
            
        }
    }
}