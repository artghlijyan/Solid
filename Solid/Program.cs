using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            WatchButton client = new WatchButton();
            string res = client.UseDevice();
            Console.WriteLine(res);
            res = client.UseDevice();
            Console.WriteLine(res);
            res = client.UseDevice();
            Console.WriteLine(res);
            res = client.UseDevice();
            Console.WriteLine(res);
            res = client.UseDevice();
            Console.WriteLine(res);
        }
    }
}
