using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public class OrganizationAgent : Employee
    {
        List<string> licensesCanIssue;
        BusinessMan bMan;
        public License curLicense;

        public OrganizationAgent(string name, string family, string staffNo, string password, string organ)
            : base(name, family, staffNo, password, organ)
        {
            licensesCanIssue = EmployeeDB.getLicensesCanIssue(this.organization);
            bMan = null;
            curLicense = null;
        }

        public void enterBusinessmanInfo(string ssn, string name, string family)
        {
            bMan = BusinessmanDB.getBusinessmanBySSN(ssn);
            if (bMan == null)
            {
                bMan = new BusinessMan(name, family, ssn);
            }
        }

        public bool enterLicenseInfo(string licenseName, DateTime expireDate)
        {
            if (this.licensesCanIssue.Any(lName => lName == licenseName))
            {
                curLicense = new License(licenseName, bMan.ssn, DateTime.Now.Date, expireDate);
                return true;
            }
            return false;
        }

        public void enterLicenseDescription(float value, int upperPrice, string pName, string company, string originCountry, string enteranceApproach, string material)
        {
            ProductDescription pd = ProductDB.getProductDescription(pName, company, originCountry, enteranceApproach, material);
            if (pd == null)
                pd = new ProductDescription(pName, company, originCountry, enteranceApproach, material);

            LicenseDescription ld = new LicenseDescription(value, upperPrice, pd);
            curLicense.descriptions.Add(ld);
        }

        public string issuanceLicense()
        {
            bMan.addToDB();
            ProductDB.addIssuancedProductDescriptionsToDB(curLicense);
            LicenseDB.addIssuancedLicenseToDB(curLicense, bMan.ssn, this.staffNo);                   
            return curLicense.licenseID;
        }       

    }
}