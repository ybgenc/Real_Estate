using RealEstate_Dapper_Api.Dtos.SiteExplanationDtos;

namespace RealEstate_Dapper_Api.Repositories.SiteExplanationRepositories
{
    public interface ISiteExplanationRepository 
    {
        Task<List<ResultSiteExplanationDto>> GetAllSiteExplaantionAsync();
    }
}
