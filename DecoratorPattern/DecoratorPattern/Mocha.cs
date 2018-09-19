using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override Size GetSize()
        {
            return beverage.GetSize();
        }
        public override double Cost()
        {
            double cost = beverage.Cost();
            if(beverage.GetSize() == Size.TALL)
            {
                cost += .10;
            }
            if (beverage.GetSize() == Size.GRANDE)
            {
                cost += .15;
            }
            if (beverage.GetSize() == Size.VENTI)
            {
                cost += .20;
            }

            return cost;
        }
    }
}
