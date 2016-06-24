using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using dataAccess;
using domain;

namespace customUnitTest
{
    [TestClass]
    public class reduceLicense
    {
        CustomExpert cExpert = null;
        CustomAdmin cAdmin = null;
        OrganizationAgent oilAgent = null;
        OrganizationAgent FDIAgent = null;
        OrganizationAgent industryAgent = null;

        public void initiate()
        {
            DB.deleteAllExceptAdmin();

            // get admin
            Employee emp = EmployeeDB.getEmployeeByLoginInfo("0", "a");
            cAdmin = new CustomAdmin(emp. name, emp.family, emp.staffNo, emp.password);

            //sign up custom expert
            string customExpertStaffNo = cAdmin.signUp("نام 1", "فامیلی 1", "کارشناس گمرک", "گمرک", "ب");
            emp = EmployeeDB.getEmployeeByLoginInfo(customExpertStaffNo, "ب");
            cExpert = new CustomExpert(emp.name, emp.family, emp.staffNo, emp.password);

            //sign up oilAgent 
            string oilAgentStaffNo = cAdmin.signUp("نام 2", "فامیلی 2", "نماینده سازمان", "نفت", "پ");
            emp = EmployeeDB.getEmployeeByLoginInfo(oilAgentStaffNo, "پ");
            oilAgent = new OrganizationAgent(emp.name, emp.family, emp.staffNo, emp.password, "نفت");

            //sign up FDIAgent 
            string FDIAgentStaffNo = cAdmin.signUp("نام 3", "فامیلی 3", "نماینده سازمان", "بهداشت", "ت");
            emp = EmployeeDB.getEmployeeByLoginInfo(FDIAgentStaffNo, "ت");
            FDIAgent = new OrganizationAgent(emp.name, emp.family, emp.staffNo, emp.password, "بهداشت");

            //sign up oilAgent 
            string industryAgentStaffNo = cAdmin.signUp("نام 4", "فامیلی 4", "نماینده سازمان", "صنعت و معدن", "ث");
            emp = EmployeeDB.getEmployeeByLoginInfo(industryAgentStaffNo, "ث");
            industryAgent = new OrganizationAgent(emp.name, emp.family, emp.staffNo, emp.password, "صنعت و معدن");
        }

        
        [TestMethod]
        public void reduceValueBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

           /*FDIAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            FDIAgent.enterLicenseInfo("مجوز سلامت محصول غذایی", new DateTime(2020, 1, 1));
            FDIAgent.enterLicenseDescription(1000, 2000, "نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            FDIAgent.enterLicenseDescription(2000, 3000, "نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            FDIAgent.enterLicenseDescription(3000, 4000, "نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            FDIAgent.enterLicenseDescription(4000, 5000, "نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            string FDILicense = FDIAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(1000, 2000, "نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 10", "شرکت 10", "10 کشور مبدا", "10 دریایی", "ماده 10");
            industryAgent.enterLicenseDescription(3000, 4000, "نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            industryAgent.enterLicenseDescription(4000, 5000, "نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            string industryLicense = industryAgent.issuanceLicense();*/

            //rule1
            cAdmin.enterRuleInfo(0, 2000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 1000, 1500);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 0);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }


        [TestMethod]
        public void reduceValueOutOfBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 2000, 1500);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }

        [TestMethod]
        public void reducePriceBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 2000);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 500);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }

        [TestMethod]
        public void reducePriceOutOfBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 1000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 2000);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }

        [TestMethod]
        public void reducePriceOutOfBoundaryAndInBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 2000, 4000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 2500, 3500);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }

        [TestMethod]
        public void reduceValueMultipleRuleOutOfBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            string oilLicense = oilAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            industryAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string industryLicense = industryAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات کالای خارجی تولید داخل");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 2500, 3500);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            License newLicense2 = LicenseDB.getLicense(industryLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 500);
            Assert.AreEqual(newLicense2.descriptions[0].value, 2000);
            Assert.AreEqual(newLicense.descriptions[1].value, 3000);
            Assert.AreEqual(newLicense2.descriptions[1].value, 4000);
        }

        [TestMethod]
        public void reduceValueMultipleRuleBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            string oilLicense = oilAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            industryAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string industryLicense = industryAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات کالای خارجی تولید داخل");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 1000, 1500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 2500, 3500);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            License newLicense2 = LicenseDB.getLicense(industryLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 0);
            Assert.AreEqual(newLicense2.descriptions[0].value, 2000);
            Assert.AreEqual(newLicense.descriptions[1].value, 3000);
            Assert.AreEqual(newLicense2.descriptions[1].value, 4000);
        }

        [TestMethod]
        public void reducePriceAllBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 6000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 2000);
            cExpert.enterProduct("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2", 500, 3000);
            cExpert.enterProduct("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3", 500, 4000);
            cExpert.enterProduct("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4", 500, 5000);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 500);
            Assert.AreEqual(newLicense.descriptions[1].value, 1500);
            Assert.AreEqual(newLicense.descriptions[2].value, 2500);
            Assert.AreEqual(newLicense.descriptions[3].value, 3500);
        }

        [TestMethod]
        public void reduceValueAllOutOfBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 5000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 6000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 1500, 2000);
            cExpert.enterProduct("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2", 2500, 3000);
            cExpert.enterProduct("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3", 3500, 4000);
            cExpert.enterProduct("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4", 4500, 5000);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);
        }

        [TestMethod]
        public void reduceValueMultipleRuleOneLicenseBoundary()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            string oilLicense = oilAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            industryAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string industryLicense = industryAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 5000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 5000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 4000);
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 1000, 1500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 2000, 3500);
            cExpert.enterProduct("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3", 3000, 4000);
            cExpert.enterProduct("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4", 4000, 5000);
            int x = cExpert.enterLicense(oilLicense);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            License newLicense2 = LicenseDB.getLicense(industryLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 0);
            Assert.AreEqual(newLicense2.descriptions[0].value, 2000);
            Assert.AreEqual(newLicense.descriptions[1].value, 0);
            Assert.AreEqual(newLicense2.descriptions[1].value, 4000);
        }

        [TestMethod]
        public void reduce2LicenseForOneProduct()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense = oilAgent.issuanceLicense();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicense2 = oilAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 5000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 6000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 1500, 2000);
            cExpert.enterProduct("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2", 2000, 3000);
            cExpert.enterProduct("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3", 3000, 4000);
            cExpert.enterProduct("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4", 4000, 5000);
            int x = cExpert.enterLicense(oilLicense);
            int x2 = cExpert.enterLicense(oilLicense2);
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(oilLicense);
            Assert.AreEqual(newLicense.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense.descriptions[3].value, 4000);

            License newLicense2 = LicenseDB.getLicense(oilLicense2);
            Assert.AreEqual(newLicense2.descriptions[0].value, 1000);
            Assert.AreEqual(newLicense2.descriptions[1].value, 2000);
            Assert.AreEqual(newLicense2.descriptions[2].value, 3000);
            Assert.AreEqual(newLicense2.descriptions[3].value, 4000);
        }

        
        [TestMethod]
        public void reduceNormalCase1()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string licenseID = oilAgent.issuanceLicense();
           
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();
           
            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            int x = cExpert.enterLicense(licenseID);
            Console.WriteLine(x);        
            bool valid = cExpert.validateLicenses();
            License newLicense = LicenseDB.getLicense(licenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, 500);
            
        }

        [TestMethod]
        public void reduceNormalCase2()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            oilAgent.enterLicenseDescription(3000, 4000, "3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            oilAgent.enterLicenseDescription(4000, 5000, "نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            string oilLicenseID = oilAgent.issuanceLicense();

            FDIAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            FDIAgent.enterLicenseInfo("مجوز سلامت محصول غذایی", new DateTime(2020, 1, 1));
            FDIAgent.enterLicenseDescription(1000, 2000, "نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            FDIAgent.enterLicenseDescription(2000, 3000, "نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            FDIAgent.enterLicenseDescription(3000, 4000, "نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            FDIAgent.enterLicenseDescription(4000, 5000, "نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            string FDILicenseID = FDIAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(1000, 2000, "نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 10", "شرکت 10", "10 کشور مبدا", "10 دریایی", "ماده 10");
            industryAgent.enterLicenseDescription(3000, 4000, "نام کالا 11", "شرکت 11", "11 کشور مبدا", "11 دریایی", "ماده 11");
            industryAgent.enterLicenseDescription(4000, 5000, "نام کالا 12", "شرکت 12", "12 کشور مبدا", "12 دریایی", "ماده 12");
            string industryLicenseID = industryAgent.issuanceLicense();
           
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            cAdmin.enterLicenseName("مجوز سلامت محصول غذایی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("مجوز واردات کالای خارجی تولید داخل");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            cExpert.enterProduct("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5", 200, 1500);
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 300, 1500);
            cExpert.enterLicense(oilLicenseID);
            cExpert.enterLicense(FDILicenseID);
            cExpert.enterLicense(industryLicenseID);
            bool valid = cExpert.validateLicenses();

            License newLicense = LicenseDB.getLicense(oilLicenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, 500);

            newLicense = LicenseDB.getLicense(FDILicenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, 800);

            newLicense = LicenseDB.getLicense(industryLicenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, 700);
        }


        // 3- summary :
        // has license for product but no rule is implemented on it 
        [TestMethod]
        public void reduceNormalCase3()
        {
            initiate();

            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(1000, 2000, "نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            oilAgent.enterLicenseDescription(2000, 3000, "نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            string oilLicenseID = oilAgent.issuanceLicense();

            FDIAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            FDIAgent.enterLicenseInfo("مجوز سلامت محصول غذایی", new DateTime(2020, 1, 1));
            FDIAgent.enterLicenseDescription(1000, 2000, "نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            FDIAgent.enterLicenseDescription(2000, 3000, "نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            string FDILicenseID = FDIAgent.issuanceLicense();

            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(1000, 2000, "نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            industryAgent.enterLicenseDescription(2000, 3000, "نام کالا 10", "شرکت 10", "10 کشور مبدا", "10 دریایی", "ماده 10");
            string industryLicenseID = industryAgent.issuanceLicense();

            //rule1
            cAdmin.enterRuleInfo(0, 3000, new DateTime(2008, 1, 1), new DateTime(2020, 2, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();            

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2", 1900, 1500);
            cExpert.enterProduct("نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6", 1200, 1500);
            cExpert.enterProduct("نام کالا 10", "شرکت 10", "10 کشور مبدا", "10 دریایی", "ماده 10", 1300, 1500);
            cExpert.enterLicense(oilLicenseID);
            cExpert.enterLicense(FDILicenseID);
            cExpert.enterLicense(industryLicenseID);
            bool valid = cExpert.validateLicenses();

            License newLicense = LicenseDB.getLicense(oilLicenseID);
            Assert.AreEqual(newLicense.descriptions[1].value, 100);

            newLicense = LicenseDB.getLicense(FDILicenseID);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);

            newLicense = LicenseDB.getLicense(industryLicenseID);
            Assert.AreEqual(newLicense.descriptions[1].value, 2000);
        }

        // 3- summary :
        //this test case is from sample 1
        [TestMethod]
        public void reduce_sample1()
        {
            initiate();            

            FDIAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            FDIAgent.enterLicenseInfo("مجوز سلامت محصول غذایی", new DateTime(2020, 1, 1));
            FDIAgent.enterLicenseDescription(100, int.MaxValue, "برنج", "", "چین", "", "");
            FDIAgent.enterLicenseDescription(200, int.MaxValue, "گندم", "", "چین", "", "");
            string FDILicenseID = FDIAgent.issuanceLicense();            

            //rule1
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("برنج", "", "", "", "");
            cAdmin.enterProductDescription("گندم", "", "", "", "");
            cAdmin.enterProductDescription("حبوبات", "", "", "", "");
            cAdmin.enterLicenseName("مجوز سلامت محصول غذایی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("برنج", "الکی", "چین", "الکی", "الکی", 50, 0);
            cExpert.enterProduct("گندم", "الکی", "چین", "الکی", "الکی", 100, 0);

/*            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();
            foreach (string i in licensesToDesplay)
                Console.WriteLine(i);
 */

            cExpert.enterLicense(FDILicenseID);
            cExpert.validateLicenses();

            License newLicense = LicenseDB.getLicense(FDILicenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, 50);
            Assert.AreEqual(newLicense.descriptions[1].value, 100);
        }

            
        // 4- summary :
        // this test case is from sample 2
        [TestMethod]
        public void reduce_sample2()
        {
            initiate();

            //issue license1
            oilAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            oilAgent.enterLicenseInfo("مجوز واردات فرآورده های نفتی", new DateTime(2020, 1, 1));
            oilAgent.enterLicenseDescription(int.MaxValue, int.MaxValue, "بنزین سوپر", "", "", "", "");
            oilAgent.enterLicenseDescription(200000, int.MaxValue, "مایع CNG", "کاسترول", "", "", "");
            string oilLicenseID = oilAgent.issuanceLicense();

            //issue license2
            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالای خارجی تولید داخل", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(300, int.MaxValue, "بشکه خالی نفت", "", "", "دریا", "");
            industryAgent.enterLicenseDescription(400, 350, "تیرآهن", "", "", "", "");
            industryAgent.enterLicenseDescription(400, 200, "میلگرد", "", "", "", "");
            string industryLicenseID1 = industryAgent.issuanceLicense();

            //issue license3
            industryAgent.enterBusinessmanInfo("2131", "نام تاجر 1", "نام خانوادگی تاجر 1");
            industryAgent.enterLicenseInfo("مجوز واردات کالاهای فلزی", new DateTime(2020, 1, 1));
            industryAgent.enterLicenseDescription(300, int.MaxValue, "بشکه خالی نفت", "", "", "دریا", "");
            industryAgent.enterLicenseDescription(400, 350, "تیرآهن", "", "", "", "");
            industryAgent.enterLicenseDescription(400, 200, "میلگرد", "", "", "", "");
            string industryLicenseID2 = industryAgent.issuanceLicense(); 

            //rule1
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("", "", "", "", "نفتی");
            cAdmin.enterLicenseName("مجوز واردات فرآورده های نفتی");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(101, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 100, 10000);
            cAdmin.enterProductDescription("", "", "", "", "فلزی");
            cAdmin.enterLicenseName("مجوز واردات کالای خارجی تولید داخل");
            cAdmin.enterLicenseName("مجوز واردات کالاهای فلزی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "2131");
            cExpert.enterProduct("بشکه", "الکی", "الکی", "الکی", "فلزی", 200, 250);
            cExpert.enterProduct("ورق آهنی", "الکی", "الکی", "الکی", "فلزی", 90, 400);
            cExpert.enterProduct("بنزین سوپر", "الکی", "الکی", "الکی", "نفتی", 1000, 1000);
            cExpert.enterProduct("میل گرد", "الکی", "الکی", "الکی", "فلزی", 300, 170);
            cExpert.enterLicense(oilLicenseID);
            cExpert.enterLicense(industryLicenseID1);
            cExpert.enterLicense(industryLicenseID2);
            cExpert.validateLicenses();

            License newLicense = LicenseDB.getLicense(oilLicenseID);
            Assert.AreEqual(newLicense.descriptions[0].value, int.MaxValue);
            Assert.AreEqual(newLicense.descriptions[1].value, 200000);
        }
    }
}
