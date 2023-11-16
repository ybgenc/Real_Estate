using RealEstate_Dapper_Api.Dtos.TipsAdviceDtos;

namespace RealEstate_Dapper_Api.Repositories.TipsAdviceRepositories
{
    public interface ITipsAdviceRepository
    {
        Task<List<ResultTipsAdviceDto>> GetAllTipsAdviceAsync();
    }
}
