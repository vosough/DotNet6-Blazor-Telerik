using Microsoft.EntityFrameworkCore;
using proUserInfoManagement.Api.Data;
using proUserInfoManagement.Api.Entities;
using proUserInfoManagement.Api.Repositories.Contracts;

namespace proUserInfoManagement.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserInfoManagementDbContext _UserInfoManagementDbContext;
        public UserRepository(UserInfoManagementDbContext userInfoManagementDbContext)
        {
            this._UserInfoManagementDbContext = userInfoManagementDbContext;
        }

        public UserInfoManagementDbContext UserInfoManagementDbContext { get; }

        public Task<User> GetItem(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetItems()
        {
           var Users = await this._UserInfoManagementDbContext.Users.ToListAsync();
            return Users;
        }
    }
}
