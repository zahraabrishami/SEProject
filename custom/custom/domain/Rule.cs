using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class Rule
    {
        public string ruleID;
        public string شناسه { get { return ruleID; } }
        public float startValue;
        public float ازمقدار { get { return startValue; } }
        public float endValue;
        public float تامقدار { get { return endValue; } }
        public DateTime startDate;
        public DateTime ازتاریخ { get { return startDate; } }
        public DateTime endDate;
        public DateTime تاتاریخ { get { return endDate; } }
        public int startUnitPrice;
        public int ازقیمت { get { return startUnitPrice; } }
        public int endUnitPrice;
        public int تاقیمت { get { return endUnitPrice; } }
        public List<ProductDescription> pDescriptions;
        public List<string> licenseNames;

        private static int counter = 1;

        public Rule(float _startValue, float _endValue, DateTime _startDate, DateTime _endDate, int _startUnitPrice, int _endUnitPrice)
        {
            ruleID = counter.ToString();
            counter++;
            startValue = _startValue;
            endValue = _endValue;
            startDate = _startDate;
            endDate = _endDate;
            startUnitPrice = _startUnitPrice;
            endUnitPrice = _endUnitPrice;
            pDescriptions = new List<ProductDescription>();
            licenseNames = new List<string>();
        }

        public Rule(string _ruleID, float _startValue, float _endValue, DateTime _startDate, DateTime _endDate, int _startUnitPrice, int _endUnitPrice, List<ProductDescription> _pDescriptions, List<string> _licenseNames)
        {
            ruleID = _ruleID;
            startValue = _startValue;
            endValue = _endValue;
            startDate = _startDate;
            endDate = _endDate;
            startUnitPrice = _startUnitPrice;
            endUnitPrice = _endUnitPrice;
            pDescriptions = _pDescriptions;
            licenseNames = _licenseNames;
        }

    }
}



