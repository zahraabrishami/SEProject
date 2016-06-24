using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using dataAccess;
using domain;

namespace customUnitTest
{    
    [TestClass]
    public class determinNeededLicenses
    {
        CustomExpert cExpert = null;
        CustomAdmin cAdmin = null;

        public void initiate()
        {
            DB.deleteAllExceptAdmin();

            // get admin
            Employee emp = EmployeeDB.getEmployeeByLoginInfo("0", "a");
            cAdmin = new CustomAdmin(emp.name, emp.family, emp.staffNo, emp.password);

            //sign up custom expert
            string customExpertStaffNo1 = cAdmin.signUp("نام 1", "فامیلی 1", "کارشناس گمرک", "گمرک", "ب");
            emp = EmployeeDB.getEmployeeByLoginInfo(customExpertStaffNo1, "ب");
            cExpert = new CustomExpert(emp.name, emp.family, emp.staffNo, emp.password);
        }

        // 1- summary :
        // one rule with one productDescription and one LicenseName
        // no boundarry
        [TestMethod]
        public void NormalCase1()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("NormalCase1");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 2- summary :
        // two rule with multiple productDescriptions and LicenseNames
        // no boundarry
        [TestMethod]
        public void NormalCase2()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2",  "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.enterLicenseName("نام مجوز 3");
            cAdmin.enterLicenseName("نام مجوز 4");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(1000, 2000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 2000, 3000);
            cAdmin.enterProductDescription("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            cAdmin.enterProductDescription("نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            cAdmin.enterProductDescription("نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            cAdmin.enterProductDescription("نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            cAdmin.enterLicenseName("نام مجوز 5");
            cAdmin.enterLicenseName("نام مجوز 6");
            cAdmin.enterLicenseName("نام مجوز 7");
            cAdmin.enterLicenseName("نام مجوز 8");
            cAdmin.submitRule();                   

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500,  1500);
            cExpert.enterProduct("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5", 1500, 2500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");
            result.Add("نام مجوز 3");
            result.Add("نام مجوز 4");
            result.Add("نام مجوز 5");
            result.Add("نام مجوز 6");
            result.Add("نام مجوز 7");
            result.Add("نام مجوز 8");

            Console.WriteLine("NormalCase2");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 3- summary :
        // two rules with multiple productDescriptions and LicenseNames
        // one licenseName is shared between two rules
        [TestMethod]
        public void shared_LicenseName()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.enterLicenseName("نام مجوز 3");
            cAdmin.enterLicenseName("نام مجوز 4");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(1000, 2000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 2000, 3000);
            cAdmin.enterProductDescription("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            cAdmin.enterProductDescription("نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            cAdmin.enterProductDescription("نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            cAdmin.enterProductDescription("نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 5");
            cAdmin.enterLicenseName("نام مجوز 6");
            cAdmin.enterLicenseName("نام مجوز 7");
            cAdmin.enterLicenseName("نام مجوز 8");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            cExpert.enterProduct("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5", 1500, 2500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");
            result.Add("نام مجوز 3");
            result.Add("نام مجوز 4");
            result.Add("نام مجوز 5");
            result.Add("نام مجوز 6");
            result.Add("نام مجوز 7");
            result.Add("نام مجوز 8");

            Console.WriteLine("shared_LicenseName");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 4- summary :
        // two rules with multiple productDescriptions and LicenseNames 
        // two rules are applied on a productDescription  
        [TestMethod]
        public void shared_productDescription_between_rules()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.enterLicenseName("نام مجوز 3");
            cAdmin.enterLicenseName("نام مجوز 4");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 2000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 3000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            cAdmin.enterProductDescription("نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            cAdmin.enterProductDescription("نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            cAdmin.enterProductDescription("نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            cAdmin.enterLicenseName("نام مجوز 5");
            cAdmin.enterLicenseName("نام مجوز 6");
            cAdmin.enterLicenseName("نام مجوز 7");
            cAdmin.enterLicenseName("نام مجوز 8");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");
            result.Add("نام مجوز 3");
            result.Add("نام مجوز 4");
            result.Add("نام مجوز 5");
            result.Add("نام مجوز 6");
            result.Add("نام مجوز 7");
            result.Add("نام مجوز 8");

            Console.WriteLine("shared_productDescription_between_rules");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 5- summary :
        // no boundary is set on rule's info
        [TestMethod]
        public void noBoundary_onRuleInfo()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 9");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 2500, 3500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 9");

            Console.WriteLine("noBoundary_onRuleInfo");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 6- summary :
        // rule is out of date and shouldnot be considered
        [TestMethod]
        public void outOfDate_rule()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2002, 1, 1), new DateTime(2008, 1, 1), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 9");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 2500, 3500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();

            Console.WriteLine("outOfDate_rule");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 7- summary :
        // product's date is on boudary
        [TestMethod]
        public void date_onBoundary()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(2000, 3000, DateTime.Now, new DateTime(2020, 1, 1), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2002, 1, 1), DateTime.Now, 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 2500, 3500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 2500, 3500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");

            Console.WriteLine("date_onBoundary");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 8- summary :
        // product's value is out range and should not be considered
        [TestMethod]
        public void productsValue_outOfRange()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 9");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 50000, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();

            Console.WriteLine("productsValue_outOfRange");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 9- summary :
        // product's price is out range and should not be considered
        [TestMethod]
        public void productsPrice_outOfRange()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 9");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 500, 50000);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();

            Console.WriteLine("productsPrice_outOfRange");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 10- summary : 
        // product's value and price is on boundary and should not be considered
        [TestMethod]
        public void productsPriceAndValue_onBoundary()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.submitRule();

            //rule3
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 3", "شرکت 3", "3 کشور مبدا", "3 دریایی", "ماده 3");
            cAdmin.enterLicenseName("نام مجوز 3");
            cAdmin.submitRule();

            //rule4
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 4", "شرکت 4", "4 کشور مبدا", "4 دریایی", "ماده 4");
            cAdmin.enterLicenseName("نام مجوز 4");
            cAdmin.submitRule();

            //add declaration

            // product's value is on start of boundary
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 0, 1500);
            cExpert.enterProduct("نام کالا 2", "شرکت 2", "2 کشور مبدا", "2 دریایی", "ماده 2", 1000, 1500);
            cExpert.enterProduct("نام کالا 3", "شرکت 3", "3 کشور مبدا", "3 دریایی", "ماده 3", 500, 1000);
            cExpert.enterProduct("نام کالا 4", "شرکت 4", "4 کشور مبدا", "4 دریایی", "ماده 4", 500, 2000);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            foreach(string i in licensesToDesplay)
                 Console.WriteLine(i);

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");
            result.Add("نام مجوز 3");
            result.Add("نام مجوز 4");

            Console.WriteLine("productsPriceAndValue_onBoundary");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 11- summary :
       // product's name of rule is empty
        [TestMethod]
        public void empty_rulesProductName()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProductName");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 12- summary :
        // product's company of rule is empty
        [TestMethod]
        public void empty_rulesProductCompany()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProductCompany");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 13- summary :
        // product's originCountry of rule is empty
        [TestMethod]
        public void empty_rulesProduct_OriginCountry()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProduct_OriginCountry");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 14- summary :
        // product's enteranceAppoach of rule is empty
        [TestMethod]
        public void empty_rulesProduct_enteranceAppoach()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProduct_enteranceAppoach");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 15- summary :
        // product's material of rule is empty
        [TestMethod]
        public void empty_rulesProduct_material()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProduct_material");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 16- summary :
        // product's name and company and origin and enteranceApproach of rule are empty
        [TestMethod]
        public void empty_rulesProduct_feilds_1()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");

            Console.WriteLine("empty_rulesProduct_feilds_1");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }
        
        // 17- summary :
        // product's name and company and origin and enteranceApproach of rule are empty
        [TestMethod]
        public void empty_rulesProduct_feilds_2()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");

            Console.WriteLine("empty_rulesProduct_feilds_2");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }
        
        // 18- summary :
        // no match for rule's product's fields
        [TestMethod]
        public void noMatch_productFields()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("تمنعتخمتیمس ", "تنتنتیبسنب ", "تنسیتومسن ", "1 سشنیدس", "ن سی سیئ نن 1 ", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();

            Console.WriteLine("noMatch_productFields");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 19- summary :
        // no productDescription in rule
        //rule that should be implemented on every declaration in range of rule
        [TestMethod]
        public void noProductDescription_inRule()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterLicenseName("مجوزی که همه باید داشته باشند");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("مجوزی که همه باید داشته باشند");

            Console.WriteLine("noProductDescription_inRule");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 20- summary :
        // productDescription with all empty fields in rule
        //rule that should be implemented on every declaration in range of rule
        [TestMethod]
        public void noProductDescriptionFields_inRule()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "", "");
            cAdmin.enterLicenseName("مجوزی که همه باید داشته باشند");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("مجوزی که همه باید داشته باشند");

            Console.WriteLine("noProductDescriptionFields_inRule");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 21- summary :
        // productDescription with all empty fields in rule and no bound is on rule
        //rule that should be implemented on every declaration product
        [TestMethod]
        public void noProductDescriptionFields_noBound_inRule()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("", "", "", "", "");
            cAdmin.enterLicenseName("مجوزی که همه باید داشته باشند");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("کمککنمئذ", "فقلبلبل", "قثقثیق", "فبفل", "اننتت", 500000, 1500000);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("مجوزی که همه باید داشته باشند");

            Console.WriteLine("noProductDescriptionFields_noBound_inRule");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 22- summary :
        // shared fields in rules
        [TestMethod]
        public void shared_Fields_inRules()
        {
            initiate();

            //submit some rules
            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "", "1 کشور مبدا", "", "ماده 1");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "", "1 کشور مبدا", "", "ماده 2");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 2", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 2");

            Console.WriteLine("empty_rulesProduct_enteranceAppoach");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 23- summary :
        // this test case is from sample 1
        [TestMethod]
        public void sample1()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("گندم",   "", "", "", "");
            cAdmin.enterProductDescription("برنج",   "", "", "", "");
            cAdmin.enterProductDescription("حبوبات", "", "", "", "");
            cAdmin.enterLicenseName("مجوز سلامت محصول غذایی");
            cAdmin.submitRule();

            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("برنج", "الکی", "چین", "الکی", "الکی", 50, 0);
            cExpert.enterProduct("گندم", "الکی", "چین", "الکی", "الکی", 100, 0);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("مجوز سلامت محصول غذایی");

            Console.WriteLine("sample1");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 24- summary :
        // this test case is from sample 2
        [TestMethod]
        public void sample2()
        {
            initiate();

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
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("بشکه", "الکی", "الکی", "الکی", "فلزی", 200, 250);
            cExpert.enterProduct("ورق آهنی", "الکی", "الکی", "الکی", "فلزی", 90, 400);
            cExpert.enterProduct("بنزین سوپر", "الکی", "الکی", "الکی", "نفتی", 1000, 987);
            cExpert.enterProduct("میل گرد", "الکی", "الکی", "الکی", "فلزی", 300, 170);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();            

            List<string> result = new List<string>();
            result.Add("مجوز واردات کالای خارجی تولید داخل");
            result.Add("مجوز واردات کالاهای فلزی");
            result.Add("مجوز واردات فرآورده های نفتی");

            Console.WriteLine("sample2");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }

        // 25- summary :
        // collectoin of all        
        [TestMethod]
        public void collectionOfAll()
        {
            initiate();

            //rule1
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1");
            cAdmin.enterProductDescription("نام کالا 2", "2 شرکت", "کشور مبدا 2", "زمینی 2", "ماده 2");
            cAdmin.enterProductDescription("3 نام کالا", "3 شرکت", "کشور مبدا 3", "دریایی 3", "ماده 3");
            cAdmin.enterProductDescription("نام کالا 4", "4 شرکت", "کشور مبدا 4", "زمینی 4", "ماده 4");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 2");
            cAdmin.enterLicenseName("نام مجوز 3");
            cAdmin.enterLicenseName("نام مجوز 4");
            cAdmin.submitRule();

            //rule2
            cAdmin.enterRuleInfo(1000, 2000, new DateTime(2002, 1, 1), new DateTime(2020, 1, 1), 2000, 3000);
            cAdmin.enterProductDescription("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5");
            cAdmin.enterProductDescription("نام کالا 6", "شرکت 6", "6 کشور مبدا", "6 دریایی", "ماده 6");
            cAdmin.enterProductDescription("نام کالا 7", "شرکت 7", "7 کشور مبدا", "7 دریایی", "ماده 7");
            cAdmin.enterProductDescription("نام کالا 8", "شرکت 8", "8 کشور مبدا", "8 دریایی", "ماده 8");
            cAdmin.enterLicenseName("نام مجوز 1");
            cAdmin.enterLicenseName("نام مجوز 5");
            cAdmin.enterLicenseName("نام مجوز 6");
            cAdmin.enterLicenseName("نام مجوز 7");
            cAdmin.enterLicenseName("نام مجوز 8");
            cAdmin.submitRule();

            //rule3
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2001, 1, 1), new DateTime(2022, 1, 1), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 9");
            cAdmin.submitRule();

            //rule4
            cAdmin.enterRuleInfo(2500, 4000, new DateTime(2000, 1, 1), new DateTime(2022, 1, 1), 3500, 5000);
            cAdmin.enterProductDescription("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9");
            cAdmin.enterLicenseName("نام مجوز 10");
            cAdmin.submitRule();

            //rule5
            cAdmin.enterRuleInfo(0, int.MaxValue, DateTime.MinValue, DateTime.MaxValue, 0, int.MaxValue);
            cAdmin.enterProductDescription("نام کالا 11", "شرکت 11", "11 کشور مبدا", "11 دریایی", "ماده 11");
            cAdmin.enterLicenseName("نام مجوز 11");
            cAdmin.submitRule();

            //rule6
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2002, 1, 1), new DateTime(2008, 1, 1), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 12", "شرکت 12", "12 کشور مبدا", "12 دریایی", "ماده 12");
            cAdmin.enterLicenseName("نام مجوز قانون انقضا شده");
            cAdmin.submitRule();

            //rule7
            cAdmin.enterRuleInfo(2000, 3000, DateTime.Now, new DateTime(2020, 1, 1), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 13", "شرکت 13", "13 کشور مبدا", "13 دریایی", "ماده 13");
            cAdmin.enterLicenseName("نام مجوز 13");
            cAdmin.submitRule();

            //rule8
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2002, 1, 1), DateTime.Now, 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 14", "شرکت 14", "14 کشور مبدا", "14 دریایی", "ماده 14");
            cAdmin.enterLicenseName("نام مجوز 14");
            cAdmin.submitRule();

            //rule9 
            cAdmin.enterRuleInfo(2000, 3000, new DateTime(2002, 1, 1), new DateTime(2022, 2, 2), 3000, 4000);
            cAdmin.enterProductDescription("نام کالا 15", "شرکت 15", "15 کشور مبدا", "15 دریایی", "ماده 15");
            cAdmin.enterLicenseName("نام مجوز 15");
            cAdmin.submitRule();

            //rule10
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "", "ماده 16");
            cAdmin.enterLicenseName("نام مجوز 16");
            cAdmin.submitRule();

            //rule11
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterProductDescription("", "", "", "16 دریایی", "ماده 16");
            cAdmin.enterLicenseName("نام مجوز 17");
            cAdmin.submitRule();

            //rule12
            cAdmin.enterRuleInfo(0, 1000, new DateTime(2008, 1, 1), new DateTime(2020, 1, 1), 1000, 2000);
            cAdmin.enterLicenseName("مجوزی که همه باید داشته باشند");
            cAdmin.submitRule();


            //add declaration
            cExpert.newDeclaration();
            cExpert.enterBusinessmanInfo("نام تاجر 1", "نام خانوادگی تاجر 1", "کد ملی تاجر 1");
            cExpert.enterProduct("نام کالا 1", "شرکت 1", "1 کشور مبدا", "1 دریایی", "ماده 1", 500, 1500);
            cExpert.enterProduct("نام کالا 5", "شرکت 5", "5 کشور مبدا", "5 دریایی", "ماده 5", 1500, 2500);
            cExpert.enterProduct("نام کالا 9", "شرکت 9", "9 کشور مبدا", "9 دریایی", "ماده 9", 2700, 3700);
            cExpert.enterProduct("نام کالا 11", "شرکت 11", "11 کشور مبدا", "11 دریایی", "ماده 11", 1, 1);
            cExpert.enterProduct("نام کالا 12", "شرکت 12", "12 کشور مبدا", "12 دریایی", "ماده 12", 2500, 3500);
            cExpert.enterProduct("نام کالا 13", "شرکت 13", "13 کشور مبدا", "13 دریایی", "ماده 13", 2500, 3500);
            cExpert.enterProduct("نام کالا 14", "شرکت 14", "14 کشور مبدا", "14 دریایی", "ماده 14", 2500, 3500);
            cExpert.enterProduct("نام کالا 15", "شرکت 15", "15 کشور مبدا", "15 دریایی", "ماده 15", 999999, 99999);
            cExpert.enterProduct("الرددلبیفب", "ثسقیبز", "عغلبزارذ", "16 دریایی", "ماده 16", 500, 1500);
            List<string> licensesToDesplay = cExpert.curDeclaration.getLicensesToDisplay();

            List<string> result = new List<string>();
            result.Add("نام مجوز 1");
            result.Add("نام مجوز 2");
            result.Add("نام مجوز 3");
            result.Add("نام مجوز 4");
            result.Add("مجوزی که همه باید داشته باشند");
            result.Add("نام مجوز 5");
            result.Add("نام مجوز 6");
            result.Add("نام مجوز 7");
            result.Add("نام مجوز 8");
            result.Add("نام مجوز 9");
            result.Add("نام مجوز 10");
            result.Add("نام مجوز 11");
            result.Add("نام مجوز 13");
            result.Add("نام مجوز 14");
            result.Add("نام مجوز 16");
            result.Add("نام مجوز 17");


            Console.WriteLine("collectionOfAll");
            foreach (string str in licensesToDesplay)
                Console.WriteLine(str);
            Console.WriteLine("***************************");

            CollectionAssert.AreEqual(licensesToDesplay, result);
        }        
    }
}