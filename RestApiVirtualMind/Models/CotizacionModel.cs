using RestApiCotizacion.DTO;
using RestApiCotizacion.Factories;
using RestApiCotizacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiCotizacion.Models
{
    public class CotizacionModel
    {
        private IFactory _factory;

        public CotizacionModel()
        {
            _factory = new Factory();
        }
        public CotizacionDTO GetCotizacion(string moneda)
        {
            var bus = _factory.GetCotizacionBusiness(moneda);
            return bus.GetCotizacion();
        }

    }
}