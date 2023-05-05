namespace Static_class_method_constructor_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Display business name
                Console.WriteLine(BusinessInfo.BusinessName);

                // Add transactions
                DailyTransactions.AddTransaction("Banana",DateTime.Now, 2);
                DailyTransactions.AddTransaction("Nuts",DateTime.Now, 6);
                DailyTransactions.AddTransaction("Flour", DateTime.Now, 5);
                DailyTransactions.AddTransaction("Sugar", DateTime.Now, 5);
                DailyTransactions.AddTransaction("Yeast", DateTime.Now, 2);

                // Display all transactions
                DailyTransactions.DisplayAllInfo();
        }
    }
}