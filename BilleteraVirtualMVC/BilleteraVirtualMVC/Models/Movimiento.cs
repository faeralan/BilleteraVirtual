using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BilleteraVirtualMVC.Models
{
    public class Movimiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovimientoId { get; set; }
        public int Importe { get; set; }

        public String Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        [EnumDataType(typeof(TipoMovimiento))]
        public TipoMovimiento TipoMovimiento { get; set; }
    }
}
