using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class UserRole
    {

        public int Id { get; set; }
        public string RoleName { get; set; }

        public static List<UserRole> Roles = new List<UserRole>(){
            new UserRole(){Id=1,RoleName="Teknisyen"},
            new UserRole(){Id=2,RoleName="Santral"}
        };
    }
}