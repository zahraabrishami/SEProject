using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class BusinessMan
    {
        public string name;
        public string family;
        public string ssn;
        public List<Declaration> ownedDeclaration;
        public List<License> ownedLicenses;

        public BusinessMan(string _name, string _family, string _ssn){
            name = _name;
            family = _family;
            ssn = _ssn;
            ownedDeclaration = new List<Declaration>();
            ownedLicenses = new List<License>();
        }

        public void addDeclaration(ref Declaration d){
            ownedDeclaration.Add(d);
        }

        public Boolean hasLicense(License l)
        {
            return (ownedLicenses.Any(license => license.licenseID == l.licenseID));
        }

        public void addLicense(License l)
        {
            ownedLicenses.Add(l);
        }

    }
}
