using AtoCash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoCash.Authentication
{
    public class UserToRoleModel
    {
        public string UserId { get; set; }
        public List<string> RoleIds { get; set; }
       

    }


    public class UserByRole : EmployeeDTO
    {
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public string Department { get; set; }

        public string JobRole { get; set; }
        public string StatusType { get; set; }

        public string AccessRole { get; set; }

    }


   
}
