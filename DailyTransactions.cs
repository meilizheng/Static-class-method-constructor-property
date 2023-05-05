using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Meili Zheng;
//5/4/2023;
//Static class method constructor property;

namespace Static_class_method_constructor_property
{
    internal class DailyTransactions
    {
       static List<Transaction> _transactions; //create a list;

        static DailyTransactions()
        {
            _transactions = new List<Transaction>(); //create a new instance for list;
        }        

        public static void AddTransaction(string name, DateTime dateTime, double amount) //create a method with two arguments;
        {
            Transaction transaction = new Transaction(name, dateTime, amount);
            _transactions.Add(transaction); // Add transaction to list
        }

        public static double CalculateTotal()  //create a method to calculate the total amount;
        {
            double totalAmount = 0.0;
            foreach (Transaction transaction in _transactions) //use foreach add each transaction amount to tatal amount;
            {
                totalAmount += transaction.Amount; 
            }
            double totalWithTax = totalAmount * (1 + BusinessInfo.TaxAmount); // Add tax to total amount
            return totalWithTax; //return totalamount with tax;
        }

        public static void DisplayAllInfo() //dispaly the transaction information;
        {
            foreach (Transaction transaction in _transactions)
            {
                Console.WriteLine(transaction.ToString()); // Print details of each transaction
            }
            Console.WriteLine($"Tax is { BusinessInfo.TaxAmount}");
            Console.WriteLine($"Total Amount with Tax: {CalculateTotal():C}"); // Print total amount with tax
        }
    }
}
