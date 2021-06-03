using System;
using System.IO;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);
        }
        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(url, filepath);
            return reply;
        }
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);

        }
    }

}
