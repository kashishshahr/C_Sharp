using System;
using System.IO;
using System.Net;

namespace Hello
{
    class AddembliesandNamespaces
    {
        static void AsndNMain(string[] args)
        {
            //string text="A class is the most powerful data type in C#. Like a structure, " +
            //"a class defines the data and behavior of the data type. ";
            //File.WriteAllText(@"C:\Users\Kashish\Desktop\WriteText.txt",text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://html.spec.whatwg.org/multipage/forms.html");
            File.WriteAllText(@"C:\Users\Kashish\Desktop\WriteText.txt", reply);

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
