using ProvinceRD.Models;
using ProvinceRD.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ProvinceRD.ViewModels
{
    public class ProvinceViewModel : BaseViewModel
    {
        public ProvinceResponse province { get; set; } = new ProvinceResponse();
        IProvinceApiService _provinceApiService;
        private IAlertService _alertService;
        public ProvinceViewModel(IProvinceApiService provinceApiService, IAlertService alertService)
        {
            _provinceApiService = provinceApiService;
            _alertService = alertService;
            GetProvince();
        }

        private async void GetProvince()
        {
            var rnd = new Random();
            var provinceId = rnd.Next(1, 32);
            try
            {
                var provinceResponse = await _provinceApiService.GetProvinceAsync(provinceId);
                if (provinceResponse != null)
                {
                    province = provinceResponse;
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("Unable to resolve host ") && Connectivity.NetworkAccess != NetworkAccess.Internet)
                    await App.Current.MainPage.DisplayAlert("Error", "NO HAY CONEXION A INTERNET", "OK");
            }
                
            //await _alertService.Alert("Error", "NO HAY CONEXION A INTERNET", "OK");
        }
    }
}
