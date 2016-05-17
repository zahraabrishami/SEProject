using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

public enum status { notExist = -3, notBelongTo = -2, notValid = -1, valid = 1 };

namespace domain
{
    public class CustomExpert : Employee
    {
        public CustomExpert(string name, string family, string staffNo, string password)
            : base(name, family, staffNo, password) { }
 
        public Declaration curDeclaration = null;
        public BusinessMan bMan = null;

        public void newDeclaration() {
            bMan = null;
            curDeclaration = new Declaration(this.staffNo);
        }

        public void enterBusinessmanInfo(string name, string family, string ssn)
        {
            BusinessMan bMan = dataAccess.DB.getBusinessmanBySSN(ssn); 
            if(bMan==null){
                bMan = new BusinessMan(name, family, ssn);
            }
            bMan.addDeclaration(ref curDeclaration);     
        }
        
        public void enterProduct(string name, string company, string originCountry, string enteranceApproach, float value, int unitPrice)
        {
            ProductDescription pd = DB.getProductDescription(name, company, originCountry, enteranceApproach);
            if (pd.Equals(null))
                pd = new ProductDescription(name, company, originCountry, enteranceApproach);
            Product p = new Product(value, unitPrice, pd);
            curDeclaration.addProduct(p);
        }

        public int enterLicense(string licenseID)
        {
            License l = DB.getLicense(licenseID);
            if (l.Equals(null))
                return (int)status.notExist;
            if (!bMan.hasLicense(l))
                return (int)status.notBelongTo;
            if (!l.isValid())
                return (int)status.notValid;
            curDeclaration.addLicense(l);
            return (int)status.valid;
        }

        public Boolean validateLicenses()
        {
          // if(//validate with rules)
           return true;      
        }

        public void printReport()
        { ;}
       
    }
}
