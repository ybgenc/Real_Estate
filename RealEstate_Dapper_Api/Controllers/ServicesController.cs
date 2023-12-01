using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServicesDtos;
using RealEstate_Dapper_Api.Repositories.ServicesRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesRepository _servicesRepository;

        public ServicesController(IServicesRepository servicesRepository)
        {
           _servicesRepository = servicesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetService()
        {
            var values = await _servicesRepository.GetAllServiceAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _servicesRepository.CreateService(createServiceDto);
            return Ok("The service has been successfully added");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _servicesRepository.DeleteService(id);
            return Ok("The service has been successfully deleted");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _servicesRepository.UpdateService(updateServiceDto);
            return Ok("The service has been successfully updated");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _servicesRepository.GetService(id);
            return Ok(values);

        }
        
    }
}
