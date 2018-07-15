using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MultipleHttpClient
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("making calls using multiple httpclient");
            MultipleHttpClient.Run();
            Console.WriteLine("finished making calls using multiple httpclient, Press any key to continue...");
            Console.Read();
            Console.WriteLine("making calls using single httpclient");
            SingleHttpClient.Run();
            Console.WriteLine("finished making calls using single httpclient, Press any key to exit...");
            Console.Read();
        }
    }
}
