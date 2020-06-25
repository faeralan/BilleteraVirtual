using Microsoft.AspNetCore.Html;
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

        [RegularExpression(@"^\d+(?:[\.\,]\d+)?$", ErrorMessage = "Valor invalido")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "El valor debe ser positivo.")]
        public int Importe { get; set; }

        public String Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Tipo de movimiento")]
        [EnumDataType(typeof(TipoMovimiento))]
        public TipoMovimiento TipoMovimiento { get; set; }

        public int CuentaId { get; set; }

        //Pasar CuentaID en Vista/Controller
        //Actualizar Saldo en Cuenta
        //Realizar validaciones (fecha no puede ser mayor a la actual, saldo)
    }

    
}
