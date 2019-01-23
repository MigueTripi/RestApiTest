using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiUsers.Constants
{
    public abstract class UserConstants
    {
        //it is not needed to split constants by kind (DAO, Business, etc) due to it is just an exercise


        public const string SP_CREATE_USER = "dbo.CreateUser";
        public const string SP_DELETE_USER = "dbo.DeleteUser";
        public const string SP_GET_USER_BY_ID = "dbo.GetUser";
        public const string SP_GET_USERS = "dbo.GetAllUsers";
    }
}