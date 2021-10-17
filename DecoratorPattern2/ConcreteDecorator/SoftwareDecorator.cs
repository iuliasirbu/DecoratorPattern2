using DecoratorPattern2.Component;
using DecoratorPattern2.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2.ConcreteDecorator
{
    public class SoftwareDecorator:CarDecorator
    {
        public string software;
        public double softwarePrice;

        public SoftwareDecorator(string software, double softwarePrice, AbstractCar car) : base(car)
        {
            this.software = software;
            this.softwarePrice = softwarePrice;
        }

        public override double GetCost()
        {
            return base.GetCost() + softwarePrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nSoftware: " + software;
        }
    }
}

