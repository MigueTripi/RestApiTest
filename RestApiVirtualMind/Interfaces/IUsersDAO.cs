using RestApiUsers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiUsers.Interfaces
{
    public interface IUsersDAO
    {
        List<UserDTO> GetAll();
        UserDTO GetById(int userId);
        int Create(UserDTO user);
        void Delete(int userId);
    }
}
