using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
//Concrete objects are created in the subclasses, thus the abstract PizzaStore class is decoupled.

        protected override Pizza CreatePizza(string item)
        {
            if (item == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if(item == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if(item == "clam")
            {
                return new ChicagoStyleClamPizza();
            }

            else return null;
        }
    }
}
