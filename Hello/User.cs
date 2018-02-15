using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class User
    {
        private static int _counter = 0; //min max текущая

        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value == "" ? DefaultName : value; 
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set 
            {
                _age = (value < 18 || value > 100) ? DefaultAge : value;
            }
        }

        private Pay _pay;

        private const int DefaultAge = 18;
        private const string DefaultName = "Empty";
        private const decimal DefaultPay = 0;

        public User() : this(DefaultName, DefaultAge, DefaultPay) { }

        public User(string n) : this(n, DefaultAge, DefaultPay) { }

        public User(string n, int a, decimal pay)
        {
            Name = n;
            Age = a;
            _pay = new Pay(pay);

            _counter++;
        }

        public string About()
        {
            return string.Format("{0}, {1}, pay = {2:C}", Name, Age, _pay.Value);
        }

        public static int UsersAmount()
        {
            return _counter;
        }
    }
}