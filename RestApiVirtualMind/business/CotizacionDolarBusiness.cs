using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApiCotizacion.DTO;
using System.Net.Http;

namespace RestApiCotizacion.business
{
    public class CotizacionDolarBusiness : ICotizacionBusiness
    {

        public CotizacionDTO GetCotizacion()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.bancoprovincia.com.ar/Principal/Dolar"); 
            var response = client.GetAsync("").Result;
            var externalData = response.Content.ReadAsAsync<List<string>>().Result;

            externalData[0] = externalData[0].Replace(',', Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            externalData[0] = externalData[0].Replace('.', Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            externalData[1] = externalData[1].Replace(',', Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            externalData[1] = externalData[1].Replace('.', Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));

            return new CotizacionDTO()
            {
                ValorCompra = Convert.ToDouble(externalData[0]),
                ValorVenta = Convert.ToDouble(externalData[1]),
                FechaDeActualizacion = externalData[2],
            };
        }
    }
}