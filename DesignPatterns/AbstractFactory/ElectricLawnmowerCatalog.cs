using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     class ElectricLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new Lawnmower[] { new Lawnmower() { Name = "Electric lawnmower" } };
        }
    }

    class ToyotaElectricLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new Lawnmower[] { new Lawnmower() { Name = "Electric lawnmower" } };
        }
    }
}
