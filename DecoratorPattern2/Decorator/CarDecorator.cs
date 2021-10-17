using DecoratorPattern2.Component;

namespace DecoratorPattern2.Decorator
{
    public abstract class CarDecorator:AbstractCar
    {
        AbstractCar _car;

        public CarDecorator(AbstractCar car) : base(car.name, car.horsePower, car.price)
        {
            _car = car;
        }

        public override double GetCost()
        {
            return base.GetCost();
        }

        public override string GetDescription()
        {
            return base.GetDescription();
        }
    }
}
