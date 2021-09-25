using ProvinceRD.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProvinceRD.Services
{
    public class ProvinceApiService : IProvinceApiService
    {
        IJsonSerializerService serializer = new JsonSerializerService();

        public async Task<ProvinceResponse> GetProvinceAsync(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://eladio37-001-site1.ftempurl.com/api/Province/{id}");

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var provinceResponse = serializer.Deserialize<ProvinceResponse>(responseString);
                return provinceResponse;
            }

            return null;
        }
    }
}
