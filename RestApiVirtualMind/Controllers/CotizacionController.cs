using RestApiCotizacion.Models;
using System.Web.Http;

namespace RestApiCotizacion.Controllers
{
    [RoutePrefix("api/Cotizacion")]
    public class CotizacionController : ApiController
    {
        [HttpGet]
        [Route("Get/{moneda}")]
        public IHttpActionResult Get(string moneda)
        {
            var model = new CotizacionModel();
            return Json(model.GetCotizacion(moneda));
        }
    }
}
