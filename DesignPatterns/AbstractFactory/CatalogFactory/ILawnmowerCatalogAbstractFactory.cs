using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CatalogFactory
{
     interface ILawnmowerCatalogAbstractFactory
    {
        ILawnmowerCatalogFactory CreateCatalogFactory(string manufactorer);

    }
}
