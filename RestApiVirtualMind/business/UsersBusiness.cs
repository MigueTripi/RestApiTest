using RestApiUsers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApiUsers.DTO;
using RestApiCotizacion.DAO;

namespace RestApiUsers.Business
{
    public class UsersBusiness : IUsersBusiness
    {
        private IUsersDAO _dao;

        public UsersBusiness()
        {
            _dao = new UsersDAO();//Should be inyected or ask to some factory.
        }

        public int Create(UserDTO user)
        {
            return _dao.Create(user);
        }

        public void Delete(int userId)
        {
            _dao.Delete(userId);
        }

        public List<UserDTO> GetAll()
        {
            return _dao.GetAll();
        }

        public UserDTO GetById(int userId)
        {
            return _dao.GetById(userId);
        }
    }
}