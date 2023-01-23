using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.FactoryMethod
{
    public class Truck : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Truck");
        }
    }
}
