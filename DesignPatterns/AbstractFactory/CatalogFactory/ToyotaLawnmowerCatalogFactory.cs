using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CatalogFactory
{
     class ToyotaLawnmowerCatalogFactory: ILawnmowerCatalogFactory
    {
        public ILawnmowerCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "Diesel" => new ToyotaDieselLawnmowerCatalog(),
                "Electirc" => new ToyotaElectricLawnmowerCatalog(),
                "Manual" => new ToyotaManualLawnmowerCatalog()
            };
        }
    }
}
