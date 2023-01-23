using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.Builder
{
    internal class ModernBuilder : IHouseBuilder
    {

        GardenBuilder garden;
        PoolBuilder pool;

        public void AddGarden()
        {
            garden = new GardenBuilder();
        }

        public void AddPool()
        {
            pool = new PoolBuilder();
        }

        public House Build()
        {
            Console.WriteLine("Builder Run");
            House house = new House
            {
                Garden = garden,
                Pool = pool
            };

            return house;
        }
    }
}
