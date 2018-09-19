using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            if (item == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if(item == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            else if(item == "clam")
            {
                return new NYStyleClamPizza();
            }

            else return null;
        }
    }
}
