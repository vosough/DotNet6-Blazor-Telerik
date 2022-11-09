using proUserInfoManagement.Api.Entities;

namespace proUserInfoManagement.Api.Repositories.Contracts
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> GetItems();

        Task<User> GetItem(int Id);

    }
}
