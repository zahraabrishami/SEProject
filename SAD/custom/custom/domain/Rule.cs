using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class Rule
    {
        public string ruleID;
        public float startValue;
        public float endValue;
        public DateTime startDate;
        public DateTime endDate;
        public int startUnitPrice;
        public int endUnitPrice;
        public ProductDescription pDescription;

        private static int counter = 1;

        public Rule(float _startValue, float _endValue, DateTime _startDate, DateTime _endDate, int _startUnitPrice, int _endUnitPrice, ProductDescription _pDescription)
        {
            ruleID = counter.ToString();
            counter++;
            startValue = _startValue;
            endValue = _endValue;
            startDate = _startDate;
            endDate = _endDate;
            startUnitPrice = _startUnitPrice;
            endUnitPrice = _endUnitPrice;
            pDescription = _pDescription;
        }
        public Rule(string _ruleID, float _startValue, float _endValue, DateTime _startDate, DateTime _endDate, int _startUnitPrice, int _endUnitPrice, ProductDescription _pDescription)
        {
            ruleID = _ruleID;
            startValue = _startValue;
            endValue = _endValue;
            startDate = _startDate;
            endDate = _endDate;
            startUnitPrice = _startUnitPrice;
            endUnitPrice = _endUnitPrice;
            pDescription = _pDescription;
        }
    }
}


   
