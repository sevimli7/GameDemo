using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber == 123456789 && gamer.BirthYear == 1985 && gamer.FirstName == "SEVİM" && gamer.LastName == "TAŞ")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
