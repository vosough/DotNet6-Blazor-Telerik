using proUserInfoManagement.Api.Entities;
using proUserInfoManagement.Models.Dtos;

namespace proUserInfoManagement.Api.Extentions
{
    public static class DtoConversation
    {


        public static IEnumerable<UserDto> ConvertToDto(this IEnumerable<User> Users)
        {
            return (from User in Users
                        //join Personal in Personals
                        //on Personal.PersonalId equals User.UserId
                    select new UserDto
                    {
                        CreateDateTime = User.CreateDateTime
                        ,ExpireDateTime = User.ExpireDateTime
                        ,FName = User.LName
                        ,LName = User.LName 
                        ,Id = User.Id   
                        ,UserName = User.UserName
                        ,NationalCode = User.NationalCode
                        ,PassWord = User.PassWord
                    }
                   ).ToList();

        }
    }
}
