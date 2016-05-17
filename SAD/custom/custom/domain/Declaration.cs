using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class Declaration
    {
        public DateTime declareDate;
        public bool granted;
        public string cExpertStaffNo;
        public List<Product> products;
        public List<Rule> rulesOnDec;
        public List<License> ownedLicensesForDec; 

        public Declaration(string _cExpertStaffNo)
        {
            declareDate = DateTime.Now;
            granted = false;
            cExpertStaffNo = _cExpertStaffNo;
            products = new List<Product>();
            rulesOnDec = new List<Rule>();
            ownedLicensesForDec = new List<License>();
        }

        public void addLicense(License l)
        {
            ownedLicensesForDec.Add(l);
        }

        public void addProduct(Product p)
        {
            products.Add(p);
        }

        public void findRequiredLicenses()
        {
            /////////////////////////
        }

        public List<Rule> gatherRequiredLicenses()
        {
            return rulesOnDec;
        }
    } 
}
