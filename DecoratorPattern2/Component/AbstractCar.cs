using System;

namespace DecoratorPattern2.Component
{
    public abstract class AbstractCar
    {
        public string name;
        public int horsePower;
        public double price;

        public AbstractCar(string name, int horsePower, double price)
        {
            this.name = name;
            this.horsePower = horsePower;
            this.price = price;
        }

        public virtual double GetCost()
        {
            Console.WriteLine("\nFinal price:");
            return price;
        }

        public virtual string GetDescription()
        {
            var text = "Car model: " + name + "\nHorse power: " + horsePower;

            return text;
        }
    }
}
