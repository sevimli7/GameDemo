using MernisTest.Abstract;
using MernisTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisTest.Concrete
{
    public class CheckIfRealPersonManager : IChecIfkRealPersonService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
