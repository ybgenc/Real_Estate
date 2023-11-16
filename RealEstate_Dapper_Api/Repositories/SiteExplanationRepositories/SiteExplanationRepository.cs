using Dapper;
using RealEstate_Dapper_Api.Dtos.SiteExplanationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.SiteExplanationRepositories
{
    public class SiteExplanationRepository : ISiteExplanationRepository
    {
        private readonly Context _context;
        public SiteExplanationRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultSiteExplanationDto>> GetAllSiteExplaantionAsync()
        {
            string query = "Select * From SiteExplanation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultSiteExplanationDto>(query);
                return values.ToList();
            }
        }
    }
}
