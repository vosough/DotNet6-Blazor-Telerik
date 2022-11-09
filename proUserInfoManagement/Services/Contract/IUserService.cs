using proUserInfoManagement.Models.Dtos;

namespace proUserInfoManagement.Services.Contract
{
    public interface IUserService
    {

        Task<IEnumerable<UserDto>> GetItems();
    }
}
