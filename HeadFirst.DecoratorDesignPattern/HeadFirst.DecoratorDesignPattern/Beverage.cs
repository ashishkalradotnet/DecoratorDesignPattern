using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.DecoratorDesignPattern
{
    public abstract class Beverage
    {        
        public abstract string getDescription();        
        public abstract double cost();
    }
}
