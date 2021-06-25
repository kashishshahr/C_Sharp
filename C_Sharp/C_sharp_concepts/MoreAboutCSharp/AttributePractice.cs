using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesPractice
{
    class AttributePractice
    {
        static void AttributeMain(string[] args)
        {
            string x="as";
            int xx=x.Length;
            switch(x)
            {
                case "aa":
                    break;    
                case "aaa":
                    break;
                default:
                    break;

            }
            List<int> s=new List<int>();
            
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            


        }
    }
    internal class Calculator
    {
        //Obselete
        //    WebMethod
        //    Serializable
        [Obsolete("List ",true)]//true -> to gice error to use

        //[Obsolete("List use karne")]
        internal static int Add(int FN,int SN)
        {
            return FN + SN;
        }
        //TO Make Add flexible for new Usr..Dont delete ..Keep it there and Make new Method
        //Give Old Method Attribute
        internal static int Add(List<int> Numbers)
        {
            int sum=0 ;
            foreach(int x in Numbers)
            {
                sum += x;
            }
            return sum;
        }
    }
}
