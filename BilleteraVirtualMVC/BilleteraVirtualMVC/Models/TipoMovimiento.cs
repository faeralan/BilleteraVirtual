using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BilleteraVirtualMVC.Models
{
    public enum TipoMovimiento
    {
        [Display(Name = "Ingreso")]
        Ingreso=1,
        [Display(Name = "Egreso")]
        Egreso=2
    }

    
}
