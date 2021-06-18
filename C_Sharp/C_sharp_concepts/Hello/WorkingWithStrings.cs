using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class WorkingWithStrings
    {
        static void StringMain(string[] args)
        {
            //string myString = "GO to \\n GO GO GO";
            //Console.WriteLine(myString);
            //myString = "GO to  \"GO GO GO\"";
            //Console.WriteLine(myString);
            //myString = @"GO to \n GO GO GO";
            //Console.WriteLine(myString);
            //myString = @"GO to  'GO GO \ GO";
            //Console.WriteLine(myString);
            //myString = String.Format("{0} = {1}", "First", "Second");
            //Console.WriteLine(myString);

            //myString = String.Format("{0} = {0}", "First", "Second");
            //Console.WriteLine(myString);

            //myString = String.Format("{1} = {0}", "First", "Second");
            //Console.WriteLine(myString);

            //myString = string.Format("{0:C}", 123.45);
            //Console.WriteLine(myString);

            //double value = 123.45;
            //myString= value.ToString("C3", CultureInfo.CurrentCulture);
            //Console.WriteLine(myString);


            //myString = string.Format("{0:N}", 123456789.45);
            //Console.WriteLine(myString);
            //myString = string.Format("Percentage: {0:P}", .45);
            //Console.WriteLine(myString);


            //myString = string.Format("PHONE: {0:+(###) ##### #####}", 919408956502);
            ////Right to Left formating
            //Console.WriteLine(myString);

            //string myString = "";
            //for(int i=0;i<100;i++)
            //{
            //    myString += "--" + i.ToString();
            //}
            //Console.WriteLine(myString);    
            //String myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}
            //Console.WriteLine(myString);
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--").Append(i.ToString());
            }
            Console.WriteLine(myString);
            Console.Read();
        }
    }
}
