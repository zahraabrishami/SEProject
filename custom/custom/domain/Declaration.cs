using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public struct reductionOfLicense
    {
        public string licenseID;
        public ProductDescription pDescription;
        public float value;
    }

    public class Declaration
    {
        public DateTime declareDate;
        public bool granted;
        public string cExpertStaffNo;
        public List<Product> products;
        public List<License> ownedLicensesForDec;
        public List<reductionOfLicense> listOfReduction;

        public Declaration(string _cExpertStaffNo)
        {
            declareDate = DateTime.Now;
            granted = false;
            cExpertStaffNo = _cExpertStaffNo;
            products = new List<Product>();
            ownedLicensesForDec = new List<License>();
            listOfReduction = new List<reductionOfLicense>();
        }

        public void addLicense(License l)
        {
            ownedLicensesForDec.Add(l);
        }

        public void addProduct(Product p)
        {
            products.Add(p);
        }

        public List<string> getLicensesToDisplay()
        {
            List<string> lNames = new List<string>();
            foreach (Product p in products)
            {
                List<Rule> rulesForProduct = RuleDB.getRelatedRules(p);
                foreach (Rule r in rulesForProduct)
                    if (p.value >= r.startValue && p.value <= r.endValue && p.unitPrice >= r.startUnitPrice && p.unitPrice <= r.endUnitPrice && declareDate.Date >= r.startDate.Date && declareDate.Date <= r.endDate.Date)
                    {
                        foreach (string requiredLicense in r.licenseNames)
                            if (!lNames.Any(ln => ln == requiredLicense))
                                lNames.Add(requiredLicense);
                    }
            }
            return lNames;
        }

        public bool validateLicenses()
        {
            foreach (Product p in products)
            {
                List<Rule> rulesForProduct = RuleDB.getRelatedRules(p);
                foreach (Rule r in rulesForProduct)
                {
                    if (p.value >= r.startValue && p.value <= r.endValue && p.unitPrice >= r.startUnitPrice && p.unitPrice <= r.endUnitPrice && declareDate.Date >= r.startDate.Date && declareDate.Date <= r.endDate.Date)
                    {
                        foreach (string requiredLicense in r.licenseNames)
                        {
                            List<string> appliedLicense = new List<string>();
                            foreach (License ownLicense in ownedLicensesForDec)
                            {
                                if (requiredLicense == ownLicense.name && !appliedLicense.Any(al=> al==ownLicense.name))
                                {
                                    foreach (LicenseDescription ld in ownLicense.descriptions)
                                    {
                                        bool related = true;
                                        ProductDescription pd = ld.productDescription;
                                        if (pd.company != "" && pd.company != p.pDescription.company)
                                            related = false;
                                        if (pd.enteranceApproach != "" && pd.enteranceApproach != p.pDescription.enteranceApproach)
                                            related = false;
                                        if (pd.material != "" && pd.material != p.pDescription.material)
                                            related = false;
                                        if (pd.originCountry != "" && pd.originCountry != p.pDescription.originCountry)
                                            related = false;
                                        if (pd.name != "" && pd.name != p.pDescription.name)
                                            related = false;
                                        if (related)
                                        {
                                            if (ld.value >= p.value && ld.upperUnitPrice >= p.unitPrice)
                                            {
                                                appliedLicense.Add(ownLicense.name);
                                                reductionOfLicense reduce = new reductionOfLicense();
                                                reduce.licenseID = ownLicense.licenseID;
                                                reduce.pDescription = ld.productDescription;
                                                reduce.value = p.value;
                                                listOfReduction.Add(reduce);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            if (appliedLicense.Count==0)
                                return false;
                        }
                    }
                }
            }
            return true;
        }

        public void reduceFromLicenses()
        {
            foreach (reductionOfLicense rd in listOfReduction)
                foreach (License ownLicense in ownedLicensesForDec)
                    if (rd.licenseID == ownLicense.licenseID)
                        foreach (LicenseDescription ld in ownLicense.descriptions)
                            if (ld.productDescription.productDescriptionID == rd.pDescription.productDescriptionID)
                                ld.value -= rd.value;
        }

    }
}
