using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }

    }
    class B : A
    {
        //as virtual written we can override A's virtual methods
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }

    }
    class C : A
    {
        //as virtual written we can override A's virtual methods
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }

    }
    //class D : B,C
    //{
    //ERRORRR
    //}
    class multipleInterface
    {
        public static void MiMain(string[] args)
        {
            A a = new A();
            B b = new B();
            A a1 = new B();
            a.Print();
            b.Print();
            a1.Print();
            Console.Read();
        }
    }
}
//multiple Interface

namespace multipleInterface
{
    interface IA
    {
        void APrint();
    }
    class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("A Inheriting Interface IA");
        }
    }
    interface IB
    {
        void BPrint();
    }
    class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("B Inheriting Interface IB");
        }
    }
    //class AB : A,B -> Error
    class AB : IA, IB
    {
        public void APrint()
        {
            Console.WriteLine("AB Inheriting Interface IA,IB");
        }
        public void BPrint()
        {
            Console.WriteLine("AB Inheriting Interface IA,IB");
        }
    }

}