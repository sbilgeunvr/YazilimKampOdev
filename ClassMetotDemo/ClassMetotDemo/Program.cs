using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 100;
            customer1.Name = "Emre";
            customer1.Surname = "Güneş";
            customer1.Age = 25;
            customer1.Job = "Teacher";

            Customer customer2 = new Customer();
            customer2.Id = 200;
            customer2.Name = "Elif";
            customer2.Surname = "Ay";
            customer2.Age = 30;
            customer2.Job = "Architect";

            Customer customer3 = new Customer();
            customer3.Id = 300;
            customer3.Name = "Selim";
            customer3.Surname = "Yıldız";
            customer3.Age = 35;
            customer3.Job = "Doctor";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customers);
            customerManager.Delete(customers);
            customerManager.List(customers);

        }
    }
}
