using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BilleteraVirtual
{
    class Cuenta
    {
        public int CuentaId { get; set; }
        public double Saldo { get; set; }

        public List<Movimiento> Movimiento { get; set; }
    }
}
