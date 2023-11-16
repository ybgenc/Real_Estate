using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.SiteExplanationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteExplanationController : ControllerBase
    {
        private readonly ISiteExplanationRepository _siteExplanationRepository;
        public SiteExplanationController(ISiteExplanationRepository siteExplanationRepository)
        {
            _siteExplanationRepository = siteExplanationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> SiteExplantionList()
        {
            var values = await _siteExplanationRepository.GetAllSiteExplaantionAsync();
            return Ok(values);
        }
    }
}
