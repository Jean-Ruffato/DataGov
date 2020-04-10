using DataGov.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataGov.Core.DataAccess
{
    public class AcordosLeniencia
    {
        public async Task<List<AcordosLenienciaTO>> AcordosLeniencias()
        {
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("http://www.transparencia.gov.br/api-de-dados/acordos-leniencia");
                return JsonConvert.DeserializeObject<List<AcordosLenienciaTO>>(content);
            }
        }
    }
}
