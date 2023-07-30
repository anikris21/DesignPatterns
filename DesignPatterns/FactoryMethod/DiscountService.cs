using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;
        public CountryDiscountService(string countryId)
        {
            _countryIdentifier = countryId;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch(_countryIdentifier)
                {
                    case "US": return 20;

                    case "ME": return 10;
                    default: return 10;
                }
            }

        }
    }

    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        public override int DiscountPercentage
        {
            get
            {
                return 15;
            }
        }
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryId;
        public CountryDiscountFactory(string countryId) { _countryId = countryId; }
        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryId);
        }
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code) { _code = code; }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}
