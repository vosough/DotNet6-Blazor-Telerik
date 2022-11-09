using proUserInfoManagement.Models.Dtos;
using proUserInfoManagement.Services.Contract;
using System.Net.Http.Json;

namespace proUserInfoManagement.Services
{
    public class UserService:IUserService
    {

        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<UserDto>> GetItems()
        {
            try
            {
                var Users = await this.httpClient.GetFromJsonAsync<IEnumerable<UserDto>>("api/User");
                return Users;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
