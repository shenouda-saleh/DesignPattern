using ITIDesignPattern.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.AbstractFactory.Classes
{
    internal class ModernSofa:ISofa
    {
        public ModernSofa()
        {
            Console.WriteLine("Created Modern Sofa");
        }
    }
}
