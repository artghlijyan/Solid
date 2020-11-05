﻿using System;

namespace ISP
{
    //слишком «толстые» интерфейсы необходимо разделять на более маленькие и специфические, 
    //чтобы программные сущности маленьких интерфейсов знали только о методах, 
    //которые необходимы им в работе. 
    //В итоге, при изменении метода интерфейса не должны меняться программные сущности, 
    //которые этот метод не используют.

    //Клиенты не должны зависеть от методов, которые они не используют.

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
