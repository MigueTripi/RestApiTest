using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApiCotizacion.DTO;
using System.Net;
using System.Web.Http;

namespace RestApiCotizacion.business
{
    public class CotizacionSinAutorizacionBusiness : ICotizacionBusiness
    {
        public CotizacionDTO GetCotizacion()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}