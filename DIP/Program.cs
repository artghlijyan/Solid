using System;

namespace DIP
{
    class Program
    {
        //Модули верхнего уровня не должны зависеть от модулей нижнего уровня. 
        //И те и другие должны зависеть от абстракций.
        //Оба типа модулей должни зависеть от абстракций

        //Абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций.

        static void Main(string[] args)
        {
            Sim sim = new Sim(new VivaCellMts());
            string operatorName = sim.ShowOperatorName();
            Console.WriteLine(operatorName);

            sim.mobileOperator = new Beeline();
            operatorName = sim.ShowOperatorName();
            Console.WriteLine(operatorName);

            sim.mobileOperator = new Ucom();
            operatorName = sim.ShowOperatorName();
            Console.WriteLine(operatorName);
        }
    }
}
