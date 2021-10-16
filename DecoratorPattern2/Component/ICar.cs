using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2.Component
{
    public abstract class ICar
    {
        public string name;
        public int horsePower;
        public double price;

        public ICar(string name, int horsePower, double price)
        {
            this.name = name;
            this.horsePower = horsePower;
            this.price = price;
        }

        public virtual void GetDescription()
        {
            Console.WriteLine(name);
            Console.WriteLine("Horse power: ", horsePower);
        }

        public virtual double GetCost()
        {
            return price;
        }
    }
}
