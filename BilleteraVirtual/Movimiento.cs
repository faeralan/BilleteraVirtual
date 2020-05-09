using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BilleteraVirtual
{
    class Movimiento
    {
        public int MovimientoId { get; set; }
        public int Importe { get; set; }

        public String Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }
    }
}
