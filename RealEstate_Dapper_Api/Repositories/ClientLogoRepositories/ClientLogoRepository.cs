using Dapper;
using RealEstate_Dapper_Api.Dtos.ClientLogoDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ClientLogoRepositories
{
    public class ClientLogoRepository : IClientLogoRepository
    {
        private readonly Context _context;
        public ClientLogoRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultClientLogoDto>> GetAllClientLogoAsync()
        {
            string query = "Select * From ClientLogo";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultClientLogoDto>(query);   
                return values.ToList();
            }
        }
    }
}
