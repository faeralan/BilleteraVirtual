using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilleteraVirtualMVC.Models
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public double Saldo { get; set; }

        public List<Movimiento> Movimiento { get; set; }
    }
}
