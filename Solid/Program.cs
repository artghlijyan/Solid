﻿using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartWatch device = new SmartWatch();
            Client client = new Client();
            client.UseDevice(device);
        }
    }
}
