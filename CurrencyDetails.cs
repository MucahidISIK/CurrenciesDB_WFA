using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrenciesDB_WFA
{
    internal class CurrencyDetails
    {
        string Currency;
        double Buying;
        double Selling;
        DateTime Date;

        public string Currency_
        {
            get { return Currency; }
            set { Currency = value; }
        }
        public double Buying_
        {
            get { return Buying; }
            set { Buying = value; }
        }
        public double Selling_
        {
            get { return Selling; }
            set { Selling = value; }
        }
        public DateTime Date_
        {
            get { return Date; }
            set { Date = value; }
        }
    }
}
