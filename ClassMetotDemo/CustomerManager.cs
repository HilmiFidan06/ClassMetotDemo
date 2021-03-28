using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Müşteri Kaydı Yapılıyor, Lütfen Bekleyiniz!");
            Console.WriteLine(customer.CustomerFirstName + " " + customer.CustomerLastName + " isimli " + customer.CustomerIdentificationNumber + " kimlik numaralı müşteri " + customer.CustomerId + " Id Numarası ile Eklenmiştir! ");
            Console.WriteLine("İşlem Başarıyla Tamamlandı!");
        }

        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("----- Müşteri Listeleme İşlemi Yapılıyor, Lütfen Bekleyiniz! -----");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id : " + customer.CustomerId);
                Console.WriteLine("Müşteri Adı Soyadı : " + customer.CustomerFirstName + " " + customer.CustomerLastName);
                Console.WriteLine("Müşteri Kimlik No : " + customer.CustomerIdentificationNumber);
                Console.WriteLine("Müşteri Doğum Yılı : " + customer.CustomerBirthYear);
                Console.WriteLine("Müşteri Kredi Notu : " + customer.CustomerCreditRating);
                Console.WriteLine("Müşteri TL Hesap Bakiyesi : " + customer.CustomerTlAccountBalance + " TL");
                Console.WriteLine("------------------------------------------------------------------");
            }
            Console.WriteLine("İşlem Başarıyla Tamamlandı!");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Silme İşlemi Yapılıyor, Lütfen Bekleyiniz!");
            Console.WriteLine(customer.CustomerFirstName + " " + customer.CustomerLastName + " isimli, " + customer.CustomerIdentificationNumber + " kimlik numaralı, " + customer.CustomerId + " Id Numarasına Sahip Müşteri Kayıtları Silinmiştir! ");
            Console.WriteLine("İşlem Başarıyla Tamamlandı!");
        }
    }
}
