using RealEstate_Dapper_Api.Dtos.TestimonialDto;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimoialAsync();

    }
}
