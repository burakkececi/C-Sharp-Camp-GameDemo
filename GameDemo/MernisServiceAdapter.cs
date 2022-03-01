using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimlik;

namespace GameDemo
{
    public class MernisServiceAdapter
    {
        public bool TCKimlikDogrula(string NationalId, string Name, string Surname, int DateOfBirth)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(long.Parse(NationalId), Name, Surname, DateOfBirth).Result.Body.TCKimlikNoDogrulaResult;


        }
    }
}

      