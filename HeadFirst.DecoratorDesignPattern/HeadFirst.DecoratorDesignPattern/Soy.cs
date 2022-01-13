using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.DecoratorDesignPattern
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return 0.25 + beverage.cost();
        }
    }
}
