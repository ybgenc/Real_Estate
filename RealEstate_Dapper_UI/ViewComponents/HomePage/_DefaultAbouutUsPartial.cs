﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.AboutUsDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultAbouutUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAbouutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44333/api/AboutUs");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultAboutUsDto>>(jsonData);
                ViewBag.title = value.Select(x => x.Title).FirstOrDefault();
                ViewBag.subtitle = value.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description1 = value.Select(x => x.Description1).FirstOrDefault();
                ViewBag.description2 = value.Select(x => x.Description2).FirstOrDefault();

                return View();
            }
            return View();
        }
    }
}
