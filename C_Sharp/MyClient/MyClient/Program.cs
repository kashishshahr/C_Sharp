using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            Console.WriteLine(myScrape.ScrapeWebPage("https://html.spec.whatwg.org/multipage/forms.html"));
            myScrape.ScrapeWebPage("https://html.spec.whatwg.org/multipage/forms.html",@"C:\Users\Kashish\Desktop\WriteText.txt");
            Console.Read();
        }
    }
}
