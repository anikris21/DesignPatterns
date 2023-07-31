using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     class ManualLawnmowerCatalog:ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new Lawnmower[] { new Lawnmower() { Name = "manual lawnmower" } };
        }
    }
    class ToyotaManualLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new Lawnmower[] { new Lawnmower() { Name = "manual lawnmower" } };
        }
    }

}
