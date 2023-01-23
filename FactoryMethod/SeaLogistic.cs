using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.FactoryMethod
{
    public class SeaLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            ITransport transport = new ship();
            return transport;
        }
    }
}
