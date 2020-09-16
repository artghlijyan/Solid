using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartWatch_2 newDevice = new SmartWatch_2();
            Client client = new Client();
            client.UseDevice(newDevice);
        }
    }
}
