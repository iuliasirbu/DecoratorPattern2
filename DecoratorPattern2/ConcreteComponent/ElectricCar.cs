using DecoratorPattern2.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2.ConcreteComponent
{
    public class ElectricCar:ICar
    {
        public ElectricCar(string name, int horsePower, double price) : base(name, horsePower, price)
        {
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\nElectric engine");
        }

        public override double GetCost()
        {
            return base.GetCost();
        }
    }
}
