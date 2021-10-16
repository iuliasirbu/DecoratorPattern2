using DecoratorPattern2.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2.Decorator
{
    public abstract class CarDecorator:ICar
    {
        public ICar _car;
        public string _name;
        public double _price;

        protected CarDecorator(ICar car, string name, double price)
        {
            _car = car;
            _name = name;
            _price = price;
        }

        public override double GetCost()
        {
            return base.GetCost() + _price;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\nExtra: ", _name);
        }
    }
}
