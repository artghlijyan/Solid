﻿using System;

namespace SRP
{
    class Program
    {
        //каждый объект должен иметь одну обязанность 
        //и эта обязанность должна быть полностью инкапсулирована в класс, 
        //а все его сервисы должны быть направлены исключительно на обеспечение этой обязанности.
        static void Main(string[] args)
        {
            SmartWatch smartWatch = new SmartWatch();
            smartWatch.On();
        }
    }
}
