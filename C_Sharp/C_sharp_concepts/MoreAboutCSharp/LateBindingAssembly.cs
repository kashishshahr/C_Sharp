using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutCSharp
{
    class LateBindingAssembly
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("MoreAboutCSharp.Customer1");
            object customerInstance=Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod=customerType.GetMethod("GetFullName");
            string[] param= new string[2];
            param[0] = "Kashish";
            param[1] = "Shah";
            string fullName=(string)getFullNameMethod.Invoke(customerInstance, param);

            Console.WriteLine("Full Name ={0}", fullName);
            Console.Read();
        }
    }
    public class Customer1
    {
             public string GetFullName(string FN,string SN)
            {
                return FN + SN;
            }
        
    }
}
