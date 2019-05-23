using System;
using System.Globalization;

namespace Produtos.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct( DateTime manuFactureDate)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + "(Used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "Manufacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
