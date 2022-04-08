using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;

using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2000, 4, 1),
                FirstName = "Muhammet Furkan",
                LastName = "Seymen",
                NationalityId = "14389162396"
            }) ;
        }
    }
}
