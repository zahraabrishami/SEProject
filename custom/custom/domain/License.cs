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

        public string name;
        public string licenseID;
        public string bManSSN;
        public DateTime issuanceDate;
        public DateTime expireDate;
        public List<LicenseDescription> descriptions;

        public License(string _licenseID, string _name, String _bManSSN, DateTime _issuanceDate, DateTime _expireDate, List<LicenseDescription> _descriptions)
        {
            name = _name;
            licenseID = _licenseID;
            bManSSN = _bManSSN;
            issuanceDate = _issuanceDate;
            expireDate = _expireDate;
            descriptions = _descriptions;
        }

        public License(string _name, string _bManSSN, DateTime _issuanceDate, DateTime _expireDate)
        {
            string _licenseID = licenseID = counter.ToString();
            counter++;
            name = _name;
            bManSSN = _bManSSN;
            issuanceDate = _issuanceDate;
            expireDate = _expireDate;
            descriptions = new List<LicenseDescription>();
        }

        public Boolean isValid()
        {
            return expireDate.Date >= DateTime.Now.Date;
        }
    }
}

     