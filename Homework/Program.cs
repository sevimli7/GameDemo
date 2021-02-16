using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.BirthYear = 1985;
            gamer.FirstName = "SEVİM";
            gamer.LastName = "TAŞ";
            gamer.IdentityNumber = 123456789;


            GamerManager gamerManager = new GamerManager( new UserValidationManager());
            gamerManager.Add(gamer);

        }
    }
}
