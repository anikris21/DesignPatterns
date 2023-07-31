using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     class DieselLawnmowerCatalog :ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers() { 
            return new Lawnmower[] { new Lawnmower() { Name = "Diesel lawnmower" } };
        }
    }


    class ToyotaDieselLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new Lawnmower[] { new Lawnmower() { Name = "Diesel lawnmower" } };
        }
    }
}
