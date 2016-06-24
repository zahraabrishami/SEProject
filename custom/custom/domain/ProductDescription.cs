using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class ProductDescription
    {
        public string name;
        public string نام { get { return name; } }
        public string company;
        public string شرکت { get { return company; } }
        public string originCountry;
        public string کشور_مبدا { get { return originCountry; } }
        public string enteranceApproach;
        public string نحوه_ورود { get { return enteranceApproach; } }
        public string productDescriptionID;
        public string شناسه { get { return productDescriptionID; } }
        public string material;
        public string جنس { get { return material; } }

        private static int counter = 1;

        public ProductDescription(string _name, string _company, string _originCountry, string _enteranceApproach, string _material)
        {
            name = _name;
            company = _company;
            originCountry = _originCountry;
            enteranceApproach = _enteranceApproach;
            productDescriptionID = counter.ToString();
            counter++;
            material = _material;
        }

        public ProductDescription(string _productDescriptionID, string _name, string _company, string _originCountry, string _enteranceApproach, string _material)
        {
            name = _name;
            company = _company;
            originCountry = _originCountry;
            enteranceApproach = _enteranceApproach;
            productDescriptionID = _productDescriptionID;
            material = _material;
        }
    }
}
