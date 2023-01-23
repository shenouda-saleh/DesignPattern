using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.Builder
{
    internal class House
    {
       public GardenBuilder Garden { get; set; }
       public PoolBuilder Pool { get; set; }
    }
}
