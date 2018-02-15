using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Pay
    {

        private const decimal DefaultMinPay = 100;
        private const decimal DefaultMaxPay = 12000;

        private decimal _value;
        public decimal Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (value < DefaultMinPay)
                    _value = DefaultMinPay;
                if (value > DefaultMaxPay)
                    _value = DefaultMaxPay;
            }
        }

        public Pay(decimal v)
        {
            Value = v;
        }

    }
}
