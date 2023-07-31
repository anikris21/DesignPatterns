using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CatalogFactory
{
     class LawnmowerCatalogAbstractFactory : ILawnmowerCatalogAbstractFactory
    {
        public ILawnmowerCatalogFactory CreateCatalogFactory(string manufactorer)
        {
            switch (manufactorer)
            {
                case "toyota": return new ToyotaLawnmowerCatalogFactory();
                default: return new LawnmowerCatalogFactory();
            }
        }
    }
}
