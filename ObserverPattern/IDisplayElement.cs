using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IDisplayElement
    {
        //This method is called when the display element needs to be displayed
        void Display();
    }
}
