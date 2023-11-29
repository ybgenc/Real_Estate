using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.AboutUsDetailDtos;
using RealEstate_Dapper_Api.Repositories.AboutUsRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsDetailRepository _aboutUsRepository;

        public AboutUsController(IAboutUsDetailRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> AboutUsDetailList()
        {
            var values = await _aboutUsRepository.GetAllAboutUsDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutUsDetail(CreateAboutUsDetailDto createAboutUsDetailDto)
        {
            _aboutUsRepository.CreateAboutUsDetail(createAboutUsDetailDto);
            return Ok("The about us  has been successfully added");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutUsDetail(int id)
        {
            _aboutUsRepository.DeleteAboutUsDetail(id);
            return Ok("The about us has been successfully deleted");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutUsDetail(UpdateAboutUsDetailDto updateAboutUsDetailDto)
        {
            _aboutUsRepository.UpdateAboutUsDetail(updateAboutUsDetailDto);
            return Ok("The about us has been successfully updated");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutUsDetail(int id)
        {
            var values = await _aboutUsRepository.GetAboutUsDetail(id);
            return Ok(values);

        }
        
    }
}
