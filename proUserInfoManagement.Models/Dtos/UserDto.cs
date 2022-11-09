using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proUserInfoManagement.Models.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string NationalCode { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }


    }
}
