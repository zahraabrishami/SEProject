using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class LicenseDescription
    {
        public float value;
        public int upperUnitPrice;
        public ProductDescription productDescription;

        public LicenseDescription(float _value, int _upperUnitPrice, ProductDescription _productDescription)
        {
            value = _value;
            upperUnitPrice = _upperUnitPrice;
            productDescription = _productDescription;
        }
    }
}
