using Dapper;
using RealEstate_Dapper_Api.Dtos.TipsAdviceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.TipsAdviceRepositories
{
    public class TipsAdviceRepository : ITipsAdviceRepository
    {
        private readonly Context _context;
        public TipsAdviceRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTipsAdviceDto>> GetAllTipsAdviceAsync()
        {
            string query = "Select * From TipsAdvice";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTipsAdviceDto>(query);
                return values.ToList();
            }
        }
    }
}
