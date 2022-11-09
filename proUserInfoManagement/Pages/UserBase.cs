using Microsoft.AspNetCore.Components;
using proUserInfoManagement.Models.Dtos;
using proUserInfoManagement.Services;
using proUserInfoManagement.Services.Contract;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Telerik.Blazor.Components;

namespace proUserInfoManagement.Pages
{
    public class UserBase:ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        public IEnumerable<UserDto> Users { get; set; }

     



    }
    public class BatchEditModel : UserDto
    {
        public bool IsDeleted { get; set; }
        public bool IsChanged { get; set; }
        public bool IsNew { get; set; }
        public bool IsDirty => this.IsDeleted || this.IsChanged || this.IsNew;
        public List<string> DirtyFields { get; set; }

        public BatchEditModel(UserDto user)
        {
            UserName = user.UserName;
            Id = user.Id;
            CreateDateTime = user.CreateDateTime;
            ExpireDateTime = user.ExpireDateTime;
            FName = user.FName;
            LName = user.LName;
            PassWord = user.PassWord;
            DirtyFields = new List<string>();
        }

        public BatchEditModel() { DirtyFields = new List<string>(); }
    }
}
