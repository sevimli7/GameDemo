using MernisTest.Abstract;
using MernisTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisTest.Concrete
{
   public class StarbucksCustomerManager:BaseCustomerManager
    {
     private  IChecIfkRealPersonService _checkIfRealPersonService;

        public StarbucksCustomerManager(IChecIfkRealPersonService checkIfRealPersonService)
        {
            _checkIfRealPersonService = checkIfRealPersonService;
        }

        public override void Add(Customer customer)
        {
            if (_checkIfRealPersonService.CheckIfRealPerson(customer)==true)
            {
                base.Add(customer);
            }
            else
            {
                Console.WriteLine("kullanıcı doğrulanmadı");
            }
                
           

        }
    }
}
