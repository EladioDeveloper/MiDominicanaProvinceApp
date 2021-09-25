using ProvinceRD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProvinceRD.Services
{
    public interface IProvinceApiService
    {
        Task<ProvinceResponse> GetProvinceAsync(int id);
    }
}
