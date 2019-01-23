using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiCotizacion.DTO
{
    public class CotizacionDTO
    {
        public double ValorCompra { get; set; }
        public double ValorVenta { get; set; }
        public string FechaDeActualizacion { get; set; }
    }
}