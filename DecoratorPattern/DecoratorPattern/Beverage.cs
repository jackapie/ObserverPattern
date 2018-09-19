using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //This is the superclass inherited by the components, DarkRoast, Decaf, HouseBlend and Espresso, 
    //as well as the decorators, so that they are all of the same type
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        //This function is virtual, so that it can be overriden by an inheriting object, if applicable
        public virtual string GetDescription()
        {
            return description;
        }

        //A choice of sizes was subsequently added
        public enum Size { TALL, GRANDE, VENTI};

        Size size = Size.TALL;

        public virtual void SetSize(Size size)
        {
            this.size = size;
        }

        public virtual Size GetSize()
        {
            return this.size;
        }

        public abstract double Cost();
    }
}
