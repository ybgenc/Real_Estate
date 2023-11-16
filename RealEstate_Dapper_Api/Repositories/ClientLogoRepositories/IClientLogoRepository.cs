using RealEstate_Dapper_Api.Dtos.ClientLogoDtos;

namespace RealEstate_Dapper_Api.Repositories.ClientLogoRepositories
{
    public interface IClientLogoRepository
    {
        Task<List<ResultClientLogoDto>> GetAllClientLogoAsync();
    }
}
