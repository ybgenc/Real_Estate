using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            #region Active_Category_Number
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44333/api/Statistics/ActiveCategoryCount");
            var JsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = JsonData;
            #endregion
            #region Active_Employee_Number
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44333/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion
            #region Passive_Category_Number
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44333/api/Statistics/PassiveCategoryCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData3;
            #endregion
            #region Average_Product_By_Rent
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44333/api/Statistics/AverageProductByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductByRent =String.Format("{0:N0}", Math.Round(Convert.ToDouble(jsonData4)));
            #endregion
            #region Average_Product_By_Sale
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44333/api/Statistics/AverageProductBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averagePrdouctBySale =String.Format("{0:N0}" ,Math.Round(Convert.ToDouble(jsonData5)));
            #endregion
            #region Average_Room_Number 
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44333/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData6;
            #endregion
            #region Category_Number
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44333/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData7;
            #endregion
            #region Category_Most_Listing
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44333/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;
            #endregion
            #region City_Most_Listing
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44333/api/Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxPrdouctCount = jsonData9;
            #endregion
            #region Different_Country_Number
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44333/api/Statistics/DifferentCountryCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.differentCountryCount = jsonData10;
            #endregion
            #region Employee_Most_Listing
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44333/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductNumber = jsonData11;
            #endregion
            #region Last_Product_Price_Sale
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44333/api/Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice =String.Format("{0:N0}",Math.Round(Convert.ToDouble(jsonData12)));
            #endregion
            #region Last_Product_Price_Rent
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44333/api/Statistics/LastProductRentPrice");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.lastProductRentPrice = String.Format("{0:N0}", Math.Round(Convert.ToDouble((jsonData13))));
            #endregion
            #region Newest_Building_Year
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44333/api/Statistics/NewestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear =jsonData14;
            #endregion
            #region Oldest_Building_Year
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44333/api/Statistics/OldestBuildingYear");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData15;
            #endregion
            #region Product_Number
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44333/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCount = String.Format("{0:N0}", Math.Round(Convert.ToDouble(jsonData16)));
            #endregion
            
            return View();
        }
    }
}
