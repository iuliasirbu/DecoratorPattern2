using DecoratorPattern2.ConcreteComponent;
using DecoratorPattern2.ConcreteDecorator;
using System;

namespace DecoratorPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            DieselCar car1 = new DieselCar("911 Turbo S", 350, 500000);
            RimDecorator rim1 = new RimDecorator("22 inch", 3000, car1);
            SoftwareDecorator software1 = new SoftwareDecorator("Auto Pilot Premium", 8000, rim1);
            Console.WriteLine(software1.GetDescription());
            Console.WriteLine(software1.GetCost());
            Console.WriteLine("\n////////////\n");

            ElectricCar car2 = new ElectricCar("Mach E", 300, 80000);
            RimDecorator rim2 = new RimDecorator("21 inch", 2900, car2);
            SoftwareDecorator software2 = new SoftwareDecorator("Auto Pilot Basic", 5000, rim2);
            Console.WriteLine(software2.GetDescription());
            Console.WriteLine(software2.GetCost());
            Console.WriteLine("\n////////////\n");


        }
    }
}
