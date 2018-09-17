using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.GetDescription() + "$" + beverage.Cost());

            Console.ReadLine();
        }
    }
}
