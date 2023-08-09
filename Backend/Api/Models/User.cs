using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }

        public static List<User> Users = new List<User>(){
            new User(){Id=1,Username="selcukshn",Password="asdasd",UserRoleId=1},
            new User(){Id=2,Username="canbayazit",Password="asdasd",UserRoleId=2}
        };
    }
}