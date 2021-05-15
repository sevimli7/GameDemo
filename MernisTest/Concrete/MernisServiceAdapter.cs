using MernisService;
using MernisTest.Abstract;
using MernisTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisTest.Concrete
{
    public class MernisServiceAdapter : IChecIfkRealPersonService
    {
        public bool  CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(),
                                                          customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
                

          return response.Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
