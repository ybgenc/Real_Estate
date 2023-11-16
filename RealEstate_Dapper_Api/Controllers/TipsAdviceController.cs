using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.TipsAdviceRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsAdviceController : ControllerBase
    {
        private readonly ITipsAdviceRepository _tipsAdviceRepository;
        public TipsAdviceController(ITipsAdviceRepository tipsAdviceRepository)
        {
            _tipsAdviceRepository = tipsAdviceRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTipsAdviceList()
        {
            var values = await _tipsAdviceRepository.GetAllTipsAdviceAsync();
            return Ok(values);
        }
    }
}
