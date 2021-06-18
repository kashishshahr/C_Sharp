using System;


//AN ABSTRACT cannot be sealed
namespace abstractPractice
{
    //public sealed abstract class CannotBeSealed
    //{
    //ERROR
    //}
    public abstract class Customer
    {
        //public abstract void Print()
        //{
        //    //abstract method cannot have body
        //} THUS ERROR
        public abstract void Print();
        public void Prin1()
        {
            Console.WriteLine("Printing from abstract class");
        }

    }
    public class Program : Customer//when Non Abstract Class inherit abstract class it has to implement abstract methods
    {
        public static void AbstractMain()
        {
            Program p = new Program();
            p.Print();
            Customer c =new  Program();
            c.Print();
            c.Prin1();
            p.Prin1();
            Console.Read();
        }

        public override void Print()
        {
            Console.WriteLine("Print Method! from non absract class");
        }
    }
    //If the class doesnot wish to provide implementation for all the abstract members inherited from the abstract class then class has  to be marked as abstract
    abstract class Customer1:Customer
    {

    }
}



//Abstract class can have  implementation for some of its member but interface cant have implementation for any
//of its members.

//NO fields in interface....Abstract classes can have fields

////No access Modifiers in interface...all are public by default
//abstract class can have Access modifiers..private by default

//interface can inherit from an interface
//abstract class can inherit from interface And Abstract class


//multiple interface at same time possible
//class cannot