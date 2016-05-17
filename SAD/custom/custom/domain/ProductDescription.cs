using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class ProductDescription
    {
        public string name;
        public string company;
        public string originCountry;
        public string enteranceApproach;
        public string productDescriptionID;

        private static int counter = 1;

        public ProductDescription(string _name, string _company, string _originCountry, string _enteranceApproach)
        {
            name = _name;
            company = _company;
            originCountry = _originCountry;
            enteranceApproach = _enteranceApproach;
            productDescriptionID = counter.ToString();
            counter++;
        }
    }
}
