
using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customfee) 
            : base (name, price)
        {
            CustomsFee = customfee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}