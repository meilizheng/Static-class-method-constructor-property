using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class_method_constructor_property
{
    internal class Transaction
    {
        DateTime _now = DateTime.Now;  //creat field;
        string _name;
        double _amount;

        public Transaction(string name, DateTime dateTime, double amount) //creat constructor with three arguments;
        {
            _name = name;
            _amount = amount;
        }

        public string Name { get => _name; } //creat property;
        public double Amount { get => _amount; }

        public override string ToString() //use override tostring display information;
        {
            return $"{_name} {_now.ToShortTimeString()} {_amount.ToString("c")}";
        }
    }
}
