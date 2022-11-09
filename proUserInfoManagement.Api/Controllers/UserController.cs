using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proUserInfoManagement.Api.Entities;
using proUserInfoManagement.Api.Extentions;
using proUserInfoManagement.Api.Repositories.Contracts;
using proUserInfoManagement.Models.Dtos;

namespace proUserInfoManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository )
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetItems()
        {
            try
            {
                var Users = await this.userRepository.GetItems();
                if (Users == null)
                {
                    return NotFound();
                }
                else {

                    //var UserDtos = Users.ConvertToDto(Personnels);
                    var UserDtos = Users.ConvertToDto();
                    return Ok(UserDtos);
                }
                
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error Rerieving data from the database");
            }
        }



    }
}
