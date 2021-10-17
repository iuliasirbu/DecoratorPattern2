using DecoratorPattern2.Component;
using DecoratorPattern2.Decorator;

namespace DecoratorPattern2.ConcreteDecorator
{
    public class RimDecorator:CarDecorator
    {
        public string rim;
        public double rimPrice;

        public RimDecorator(string rim, double rimPrice, AbstractCar car) : base(car)
        {
            this.rim = rim;
            this.rimPrice = rimPrice;
        }

        public override double GetCost()
        {
            return base.GetCost()+rimPrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nRim model: " + rim;
        }
    }
}
