using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.DecoratorDesignPattern
{
    public class DarkRoast : Beverage
    {
        public override double cost()
        {
            return 2.99;
        }

        public override string getDescription()
        {
            return "Dark Roast";
        }
    }
}
