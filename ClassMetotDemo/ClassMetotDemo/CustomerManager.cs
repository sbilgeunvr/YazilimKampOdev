using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
            }
            Console.WriteLine("Müşteriler Eklendi...");
            Console.WriteLine("---------------------------");
        }
        public void Delete(Customer[] customers)
        {
            Console.WriteLine("Müşteri Silindi : ");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
            }
            Console.WriteLine("---------------------------");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.Job);
            }

        }
    }
}
