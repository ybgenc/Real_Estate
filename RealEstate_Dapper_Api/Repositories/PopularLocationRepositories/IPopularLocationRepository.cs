using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto popularLocationDto);
        void UpdatePopularLocation(UpdatePopularLocationDto popularLocationDto);
        void DeletePopularLocation(int id);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
    }
}
