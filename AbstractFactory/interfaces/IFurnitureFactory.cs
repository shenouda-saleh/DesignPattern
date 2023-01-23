using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.AbstractFactory.interfaces
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
