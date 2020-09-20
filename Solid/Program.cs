using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            WatchButton client = new WatchButton();
            client.UseDevice();
            client.UseDevice();
        }
    }
}
