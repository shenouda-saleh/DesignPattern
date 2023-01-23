using ITIDesignPattern.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.AbstractFactory.Classes
{
    internal class ModernChair : IChair
    {
        public ModernChair() {
            Console.WriteLine("Created Modern chair");
        }

        public void HasLegs()
        {
            throw new NotImplementedException();
        }

        public void SitOn()
        {
            throw new NotImplementedException();
        }
    }
}
