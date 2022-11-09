using System.ComponentModel.DataAnnotations.Schema;

namespace proUserInfoManagement.Api.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
