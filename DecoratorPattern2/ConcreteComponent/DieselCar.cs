using DecoratorPattern2.Component;

namespace DecoratorPattern2.ConcreteComponent
{
    public class DieselCar : AbstractCar
    {
        public DieselCar(string name, int horsePower, double price) : base(name, horsePower, price)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nDiesel engine";
        }

        public override double GetCost()
        {
            return base.GetCost();
        }

    }
}
