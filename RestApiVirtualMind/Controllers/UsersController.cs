using RestApiUsers.Business;
using RestApiUsers.DTO;
using RestApiUsers.Interfaces;
using System.Web.Http;

namespace RestApiUsers.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        private IUsersBusiness _bus;
        public UsersController()
        {
            _bus = new UsersBusiness();
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            return Json(_bus.GetAll());
        }

        [HttpGet]
        [Route("GetById/{userId}")]
        public IHttpActionResult GetById(int userId)
        {
            return Json(_bus.GetById(userId));
        }

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create(UserDTO user)
        {
            return Json(_bus.Create(user));
        }

        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(int userId)
        {
            _bus.Delete(userId);//If this routine finish means that the process ended successfully
            return Json(true);
        }


    }
}
