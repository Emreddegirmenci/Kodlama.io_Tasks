using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1999, 1, 14),
                FirstName = "Emre",
                LastName = "Değirmenci",
                NationalityId = "12345678901"
            });
            Console.ReadLine();
        }
    }
   
}
