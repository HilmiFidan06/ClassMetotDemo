using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 100;
            customer1.CustomerFirstName = "Hilmi";
            customer1.CustomerLastName = "Fidan";
            customer1.CustomerIdentificationNumber = "12345678910";
            customer1.CustomerBirthYear = 1996;
            customer1.CustomerCreditRating = 1850;
            customer1.CustomerTlAccountBalance = 350000;

            Customer customer2 = new Customer();
            customer2.CustomerId = 101;
            customer2.CustomerFirstName = "Engin";
            customer2.CustomerLastName = "Demiroğ";
            customer2.CustomerIdentificationNumber = "12345678911";
            customer2.CustomerBirthYear = 1985;
            customer2.CustomerCreditRating = 1800;
            customer2.CustomerTlAccountBalance = 5000000;

            Customer customer3 = new Customer();
            customer3.CustomerId = 102;
            customer3.CustomerFirstName = "Kerem";
            customer3.CustomerLastName = "Varış";
            customer3.CustomerIdentificationNumber = "12345678912";
            customer3.CustomerBirthYear = 1989;
            customer3.CustomerCreditRating = 1799;
            customer3.CustomerTlAccountBalance = 50000;

            Customer customer4 = new Customer();
            customer4.CustomerId = 103;
            customer4.CustomerFirstName = "Tuğçe";
            customer4.CustomerLastName = "Kandemir";
            customer4.CustomerIdentificationNumber = "12345678913";
            customer4.CustomerBirthYear = 1990;
            customer4.CustomerCreditRating = 1500;
            customer4.CustomerTlAccountBalance = 250000;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            Console.WriteLine("FidanBank Yetkili Paneline Hoş Geldiniz!");

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            customerManager.ListCustomer(customers);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            customerManager.DeleteCustomer(customer4);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

        }

    }
}
