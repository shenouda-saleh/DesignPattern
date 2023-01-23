using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.FactoryMethod
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();

    }
}
