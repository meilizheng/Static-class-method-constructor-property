using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class_method_constructor_property
{
    internal class BusinessInfo  
    {
       static string _businessName; //creat static field;
       static double _taxAmount;

        static BusinessInfo()   //creat static contructor;
        {
            _businessName = "Mylife";  //Initialize both fields inside of the constructor;
            _taxAmount = 0.1;
        }

        public static string BusinessName { get => _businessName; } //create a property, read only;
        public static double TaxAmount { get => _taxAmount;}
    } 
}
