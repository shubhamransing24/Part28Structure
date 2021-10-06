using System;

namespace Part28Structure
{
   public struct Customer
    {
        public int id;
        public string name;
        public Customer(int id,string name)
        {
            this.id = id;
            this.name = name;
            
        }
        public void PrintCustomerName()
        {
            Console.WriteLine("Customer Id={0}\n Customer Name ={1} ", id, name);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(11,"Rhoit Sharma");
            c.PrintCustomerName();
            Customer c2 = new Customer();
            c2.id = 101;
            c2.name = "Hitman";
            c2.PrintCustomerName();
            Customer c1 = new Customer()
            {
                id = 21,
                name="Shubham"
            };
            c1.PrintCustomerName();
            
        }
    }
}
