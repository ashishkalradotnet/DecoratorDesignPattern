using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.DecoratorDesignPattern
{
    public class HouseBlend : Beverage
    {       
        public override double cost()
        {
            return 0.89;
        }

        public override string getDescription()
        {
            return "House Blend Coffee";
        }
    }
}
