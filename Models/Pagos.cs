﻿using System;

namespace Inmobiliaria.Models
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public int NumPago { get; set; }
        public int IdContr { get; set; }
        public Contratos Contratos { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Importe { get; set; }
    }
}
