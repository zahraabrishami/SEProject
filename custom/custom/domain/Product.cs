using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class Product
    {
        public float value;
        public int unitPrice;
        public ProductDescription pDescription;

        public Product(float _value, int _unitPrice, ProductDescription pd){
            value = _value;
             unitPrice = _unitPrice;
             pDescription = pd;
         }
        
    }

   
}
