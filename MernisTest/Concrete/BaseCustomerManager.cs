using MernisTest.Abstract;
using MernisTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisTest.Concrete
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer) {
            Console.WriteLine("Müşteri eklendi : " + customer.FirstName + " " + customer.LastName);

        }
    }
}
