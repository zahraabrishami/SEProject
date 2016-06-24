using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public class CustomAdmin : Employee
    {
        public CustomAdmin(string name, string family, string staffNo, string password)
            : base(name, family, staffNo, password) { }

        public Rule curRule = null;
        private static int counter = 1;

        public string signUp(string name, string family, string role, string organ, string password)
        {
            string staffNo = counter.ToString();
            counter++;
            Employee newEmp = new Employee(name, family, staffNo, password, organ);
            EmployeeDB.addEmployeeToDB(newEmp, role);
            return staffNo;
        }

        public void enterRuleInfo(float startValue, float endValue, DateTime startDate, DateTime endDate, int startUnitPrice, int endUnitPrice)
        {
            if (curRule == null)
                curRule = new Rule(startValue, endValue, startDate, endDate, startUnitPrice, endUnitPrice);
            else
            {
                curRule.startValue = startValue;
                curRule.endValue = endValue;
                curRule.startUnitPrice = startUnitPrice;
                curRule.endUnitPrice = endUnitPrice;
                curRule.startDate = startDate;
                curRule.endDate = endDate;
            }
        }

        public void enterProductDescription(string pName, string company, string originCountry, string enteranceApproach, string material)
        {
            ProductDescription pd = ProductDB.getProductDescription(pName, company, originCountry, enteranceApproach, material);
            if (pd == null)
                pd = new ProductDescription(pName, company, originCountry, enteranceApproach, material); 
            curRule.pDescriptions.Add(pd);
        }

        public void enterLicenseName(string licenseName)
        {
            curRule.licenseNames.Add(licenseName);
        }

        public void submitRule()
        {
            if (RuleDB.getRuleByID(curRule.ruleID) != null)
                RuleDB.deleteRule(curRule.ruleID);
            RuleDB.addRule(curRule);
            curRule = null;
        }

        public List<Rule> getAllRules()
        {
            List<Rule> rules = RuleDB.getAllRules();
            return rules;
        }

        public void deleteRule(string ruleID)
        {
            RuleDB.deleteRule(ruleID);
        }     

    }
}
