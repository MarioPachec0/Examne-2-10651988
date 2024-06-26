﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.Modelos
{
    public class DetalleIngresos
    {
        public int IdDetalleIng { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaVenc { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
