using RealEstate_Dapper_Api.Dtos.AboutUsDetailDtos;

namespace RealEstate_Dapper_Api.Repositories.AboutUsRepository
{
    public interface IAboutUsDetailRepository
    {
        Task<List<ResultAboutUsDetailDto>> GetAllAboutUsDetailAsync();

        void CreateAboutUsDetail(CreateAboutUsDetailDto createAboutUsDetailDto);
        void DeleteAboutUsDetail(int id);
        void UpdateAboutUsDetail(UpdateAboutUsDetailDto updateAboutUsDetailDto);
        Task<GetByIdAboutUsDetailDto> GetAboutUsDetail(int id);
        

    }
}
