using RealEstate_Dapper_Api.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        void DeleteBottomGrid(int id);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
