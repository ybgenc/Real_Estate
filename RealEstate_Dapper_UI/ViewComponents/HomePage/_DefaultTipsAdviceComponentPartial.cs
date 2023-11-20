using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ProductDtos;
using RealEstate_Dapper_UI.Dtos.TipsAdviceDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultTipsAdviceComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultTipsAdviceComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var clientTips = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44333/api/Products/ProductlistWithCategory");
            var responseMessageTips = await clientTips.GetAsync("https://localhost:44333/api/TipsAdvice");
            if (responseMessage.IsSuccessStatusCode && responseMessageTips.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonDataTips = await responseMessageTips.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Dtos.ProductDtos.ResultProductDto>>(jsonData);
                var valuesTips = JsonConvert.DeserializeObject<List<ResultTipsAdviceDto>>(jsonDataTips);

                // Set ViewBag.productCoverImages to the last three productCoverImages
                ViewBag.productCoverImages = values.TakeLast(3).Select(x => x.productCoverImage).ToList();

                return View(valuesTips);
            }
            return View();
        }

    }
}
