using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct product)
        {
            UnitPrice = (int)product.PricePerUnit;
            BarCode = product.EANCode;
            Title = product.Description;
        }
        private decimal unitPrice;
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }
        private string barCode;
        public string BarCode
        {
            get
            {
                return barCode;
            }
            set
            {
                barCode = value;
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
}
