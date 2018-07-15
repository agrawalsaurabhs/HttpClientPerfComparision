using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MultipleHttpClient
{
    class MultipleHttpClient
    {
        public static void Run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var t1 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 1 complete");
            });


            var t2 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 2 complete");
            });

            var t3 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 3 complete");
            });

            var t4 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 4 complete");
            });

            var t5 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 5 complete");
            });

            var t6 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 6 complete");
            });

            var t7 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 7 complete");
            });

            var t8 = Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync("http://localhost/welcome.png");
                        Console.WriteLine(await result.Content.ReadAsByteArrayAsync() + " number " + i);
                    }
                }
                Console.WriteLine("Task 8 complete");
            });
            Task.WhenAll(t1, t2, t3, t4, t5, t6, t7, t8).Wait();
            watch.Stop();
            Console.WriteLine("total time when using different httpclient for each request " + watch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
