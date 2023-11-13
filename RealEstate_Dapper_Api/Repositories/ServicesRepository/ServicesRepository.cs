using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RealEstate_Dapper_Api.Dtos.ServicesDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServicesRepository
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly Context _context;
        public ServicesRepository(Context context)
        {
            _context = context; 
        }
        public async void CreateService(CreateServiceDto createServiceDto)
        {
            string query = "insert into Service (ServiceName,ServiceStatus) values (@serviceName,@serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", createServiceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async void DeleteService(int id)
        {
            string query = "Delete From Service where ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters); 
            }

        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDServiceDto> GetService(int id)
        {
            string query = "Select * From Service Where ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDto>(query,parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDto updateServiceDto)
        {
            string query = "Update Service set ServiceName=@serviceName, ServiceStatus=@serviceStatus where ServiceID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", updateServiceDto.ServiceID);
            parameters.Add("@serviceName", updateServiceDto.ServiceName);
            parameters.Add("@serviceStatus", updateServiceDto.ServiceStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }
    }
}
