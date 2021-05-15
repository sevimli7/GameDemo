using MernisTest.Concrete;
using MernisTest.Entities;
using System;

namespace MernisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager( new MernisServiceAdapter());
            customerManager.Add(new Customer { NationalityId = 00000000000, FirstName = "sevim", LastName = "taş", DateOfBirth=new DateTime(1985,01,01) });
           

        }
    }
}
