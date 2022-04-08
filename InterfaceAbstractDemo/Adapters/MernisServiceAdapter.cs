using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            var locale = new CultureInfo("tr-TR", false);
            var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            {
                var cmd = svc.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
                return cmd.Result.Body.TCKimlikNoDogrulaResult;
            };
        }
    }
}
