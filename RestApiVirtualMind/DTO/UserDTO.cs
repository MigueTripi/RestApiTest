using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiUsers.DTO
{
    public class UserDTO
    {
        public int userId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}