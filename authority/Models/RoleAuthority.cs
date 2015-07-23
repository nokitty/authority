using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace authority.Models
{
    public class RoleAuthority
    {
        public int ID { get; set; }
        public DBC.Role Role { get; set; }
    }
}