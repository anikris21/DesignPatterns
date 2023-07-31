using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CatalogFactory
{
     class LawnmowerCatalogFactory: ILawnmowerCatalogFactory
    {
        public LawnmowerCatalogFactory() { }

        public ILawnmowerCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "Diesel" => new DieselLawnmowerCatalog(),
                "Electirc" => new ElectricLawnmowerCatalog(),
                "Manual" => new ManualLawnmowerCatalog()
            };
        }
    }
}
