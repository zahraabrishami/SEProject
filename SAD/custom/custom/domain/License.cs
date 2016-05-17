using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public class License
    {
        private static int counter = 1;

        public string licenseID;
        public BusinessMan bMan;
        public DateTime issuanceDate;
        public DateTime expireDate;
        public int goodsNumber;
        public int upperPrice;
        public ProductDescription productDescription;
        public List<Rule> rules;

        public License(string _licenseID, BusinessMan _bMan, DateTime _issuanceDate, DateTime _expireDate, int _goodsNumber, int _upperPrice, ProductDescription _productDescription)
        {
            licenseID = _licenseID;
            bMan = _bMan;
            issuanceDate = _issuanceDate;
            expireDate = _expireDate;
            goodsNumber = _goodsNumber;
            upperPrice = _upperPrice;
            productDescription = _productDescription;
        }

        public License(BusinessMan _bMan, DateTime _issuanceDate, DateTime _expireDate, int _goodsNumber, int _upperPrice, ProductDescription _productDescription)
        {
            string _licenseID = licenseID = counter.ToString();
            counter++;
            bMan = _bMan;
            issuanceDate = _issuanceDate;
            expireDate = _expireDate;
            goodsNumber = _goodsNumber;
            upperPrice = _upperPrice;
            productDescription = _productDescription;
        }

        public Boolean isValid()
        {
            return expireDate.Date < DateTime.Now.Date;
        }
    }
}

     