using DecoratorPattern2.Component;

namespace DecoratorPattern2.ConcreteComponent
{
    public class ElectricCar:AbstractCar
    {
        public ElectricCar(string name, int horsePower, double price) : base(name, horsePower, price)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\nElectric engine";
        }

        public override double GetCost()
        {
            return base.GetCost();
        }
    }
}
