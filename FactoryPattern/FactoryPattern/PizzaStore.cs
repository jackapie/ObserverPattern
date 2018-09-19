using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        //This is the factory method. 
        //It isolates the PizzaStore class from knowing what kind of concrete product is created.
        //It has the form:
        //abstract Product FactoryMethod(string type) - NB the parentheses may be empty
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }


    }
}
