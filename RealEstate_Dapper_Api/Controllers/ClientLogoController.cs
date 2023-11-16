using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ClientLogoRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientLogoController : ControllerBase
    {
        private readonly IClientLogoRepository _clientLogoRepository;
        public ClientLogoController(IClientLogoRepository clientLogoRepository)
        {
            _clientLogoRepository = clientLogoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllClientLogoList ()
        {
            var values = await _clientLogoRepository.GetAllClientLogoAsync();
            return Ok(values);
        }

    }
}
