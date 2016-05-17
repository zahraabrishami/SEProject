using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public class OrganizationAgent : Employee
    {
        public OrganizationAgent(string name, string family, string staffNo, string password)
            : base(name, family, staffNo, password) { }

        BusinessMan bMan = null;

        public void enterBusinessmanInfo(string name, string family, string ssn)
        {
            BusinessMan bMan = DB.getBusinessmanBySSN(ssn);
            if (bMan == null)
            {
                bMan = new BusinessMan(name, family, ssn);
            }
        }

  /*      public string issueLicense(string _pname, string _company, string _originCountry, string _enteranceApproach, int _goodsNumber, int _upperPrice, DateTime _expireDate)
        {
            ProductDescription pd = new ProductDescription(_pname, _company, _originCountry, _enteranceApproach);
            LicenseDescription ld = new LicenseDescription(DateTime.Now, _expireDate, _goodsNumber, _upperPrice, pd);
            License l = new License(ld);
            bMan.addLicense(l);
            return l.getLicenseID();
        }*/
    }
}
