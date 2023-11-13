using Dapper;
using RealEstate_Dapper_Api.Dtos.AboutUsDetailDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.AboutUsRepository
{
    public class AboutUsDetailRepository : IAboutUsDetailRepository
    {
        private readonly Context _context;
        public AboutUsDetailRepository (Context context)
        {
            _context = context;
        }
        public async void CreateAboutUsDetail(CreateAboutUsDetailDto createAboutUsDetailDto)
        {
            string query = "insert into AboutUsDetail(Title, Subtitle, Description1, Description2) values (@title, @subtitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createAboutUsDetailDto.Title);
            parameters.Add("@subtitle", createAboutUsDetailDto.Subtitle);
            parameters.Add("@description1", createAboutUsDetailDto.Description1);
            parameters.Add("@description2", createAboutUsDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteAboutUsDetail(int id)
        {
            string query = "Delete From AboutUsDetail Where AboutUsDetailID = @aboutUsDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutUsDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdAboutUsDetailDto> GetAboutUsDetail(int id)
        {
            string query = "Select * From AboutUsDetail Where AboutUsDetailID = @aboutUsDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutUsDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdAboutUsDetailDto>(query, parameters);
                return values;
            }
        }

        public async  Task<List<ResultAboutUsDetailDto>> GetAllAboutUsDetailAsync()
        {
            string query = "Select * From AboutUsDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAboutUsDetailDto>(query);
                return values.ToList();
            }
        }

        public async void UpdateAboutUsDetail(UpdateAboutUsDetailDto updateAboutUsDetailDto)
        {
            string query = "Update AboutUsDetail set Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2 where AboutUsDetailID=@aboutUsDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutUsDetailID", updateAboutUsDetailDto.AboutUsDetailID);
            parameters.Add("@title", updateAboutUsDetailDto.Title);
            parameters.Add("@subtitle", updateAboutUsDetailDto.Subtitle);
            parameters.Add("@description1", updateAboutUsDetailDto.Description1);
            parameters.Add("@description2", updateAboutUsDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
