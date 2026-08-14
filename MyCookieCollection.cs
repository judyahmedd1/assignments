using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOPs2ass
{
    internal class MyCookieCollection
    {
        private Dictionary<string, string> cookies = new Dictionary<string, string>();
        public string this[string key]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException("invalid, cookie name can't be empty");
                if (cookies.ContainsKey(key))
                    return cookies[key];
                //if key doesn't exist, stops crashing 
                return null;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException("invalid, cookie name can't be empty");
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("invalid, cookie value can't be empty");
                cookies[key] = value;
            }
        }
        public void printcookies()
        {
            for (int i = 0; i < cookies.Count; i++) {
                Console.WriteLine(cookies.ElementAt(i).Key + " = " + cookies.ElementAt(i).Value);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCookieCollection cookies = new MyCookieCollection();

            cookies["username"] = "MaiHesham";
            cookies["theme"] = "dark";
            Console.WriteLine("Language: " + (cookies["language"] ?? "Not Set"));

            Console.WriteLine(cookies["username"]);
        }
    }
}
