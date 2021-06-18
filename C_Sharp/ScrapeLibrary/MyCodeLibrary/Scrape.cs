using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Scrape
    {
        private string GetWebPage(string url)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return reply;
        }
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);
        }
        public string ScrapeWebPage(string url,string filepath)
        {
            string reply=GetWebPage(url);
            System.IO.File.WriteAllText(filepath, reply);
            return reply;
        }
    }
}
