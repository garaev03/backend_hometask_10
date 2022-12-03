namespace hometask_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer<object>[] customers = new Customer<object>[0];

            Customer<object> custom1 = new Customer<object> { Salary = 20 };
            Customer<object> custom2 = new Customer<object> { Salary = 15 };
            Customer<object> custom3 = new Customer<object> { Salary = 55 };
            Customer<object> custom4 = new Customer<object> { Salary = 5 };
      
            customers = AddTo(customers, custom1);
            customers = AddTo(customers, custom2);
            customers = AddTo(customers, custom3);
            customers = AddTo(customers, custom4);

            Array.Sort(customers);              
                
            foreach (var item in customers)
            {
                Console.WriteLine(item.Salary);
            }
        }
        static Customer<object>[] AddTo(Customer<object>[] customers, Customer<object> customer)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = customer;
            return customers;
        }
    }
}