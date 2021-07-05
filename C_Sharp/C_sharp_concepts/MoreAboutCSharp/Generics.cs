using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    class Generics
    {
        static void Main(string[] args)
        {
            //bool Equal = Calculator.AreEqual(1, 2);
            bool Equal = Calculator.AreEqual<char>('a', 'a');
            Calculator c = new Calculator();
            
            Calculator c1 = new Calculator();
            c1.fn = "d";
            Calculator d = c;
            d.fn = "k";
            c.fn = "d";
            Console.WriteLine(d.fn+ " "+c.fn+" "+c1.fn);
            Console.WriteLine((d == c));
            Console.WriteLine(d.Equals(c));
            Console.WriteLine(d.Equals(c1));

            if (Equal)
            {
                
                Generics g=new Generics();
                Console.WriteLine("Equal "+g);
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public override string ToString()
        {
            return "ToString called?";
        }

    }
    public class Calculator{

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if(!(obj is Calculator))
            {
                return false;
            }
            return fn == ((Calculator)obj).fn;
        }
        public string fn { get; set; }
        string ln { get; set; }
        public static bool AreEqual<T>(T v1,T v2)
        {
            return v1.Equals(v2) ;
        }

        public override int GetHashCode()
        {
            return fn.GetHashCode() ^ ln.GetHashCode();
        }
    }

}
