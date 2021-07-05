using System;
using System.Diagnostics;
namespace DotNetDebugging
{
    class Program
    {
        static int Fibonacci(int n){
            int n1=0;
            int n2=1;
            int sum=0;
            for(int i=2;i<=n;i++)//0 0 1 2 3 5
            {
                sum=n1+n2;
                n1=n2;n2=sum;
                 Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
            }
            Debug.Assert(n2==5,"The returnvalue is not 5 and it should be");
            return n==0?n1:n2;
        }
        static void Main(string[] args)
        {
            int n=4;
            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
            
            Debug.WriteLine($"We are looking for the {n}th number");
            Console.WriteLine(Fibonacci(n));
        }
    }
}
