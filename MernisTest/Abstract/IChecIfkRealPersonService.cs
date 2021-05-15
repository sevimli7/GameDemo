using MernisTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisTest.Abstract
{
   public interface IChecIfkRealPersonService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
