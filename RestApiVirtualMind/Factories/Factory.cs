using RestApiCotizacion.business;
using RestApiCotizacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiCotizacion.Factories
{
    public class Factory : IFactory
    {
        private Dictionary<string, ICotizacionBusiness> _cotizacionBusinesses;

        public Factory()
        {
            _cotizacionBusinesses = new Dictionary<string, ICotizacionBusiness>();
            _cotizacionBusinesses.Add("DOLAR", new CotizacionDolarBusiness());
            _cotizacionBusinesses.Add("PESOS", new CotizacionSinAutorizacionBusiness());
            _cotizacionBusinesses.Add("REAL", new CotizacionSinAutorizacionBusiness());
        }

        public ICotizacionBusiness GetCotizacionBusiness(string moneda)
        {
            if (!_cotizacionBusinesses.Any(x => x.Key.Equals(moneda.ToUpper())))
            {
                throw new Exception("Cotizacion no encontrada para la moneda " + moneda);
            }
            return _cotizacionBusinesses[moneda.ToUpper()]; 
        }
    }
}