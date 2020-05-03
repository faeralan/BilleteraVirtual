using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BilleteraVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario();

            u.Nombre = "Alan";
            u.Apellido = "Faerverguer";
            u.Email = "faeralan@gmail.com";
            u.Password = "123456";
            
            Cuenta micuenta = new Cuenta();
            
            micuenta.Saldo = 0;
            micuenta.Movimiento = new List<Movimiento>();

            u.cuenta = micuenta;

            Movimiento m = new Movimiento();

            m.Importe = 10;
            m.Descripcion = "Primer movimiento";
            m.Fecha = new DateTime(2020,04,30);
            m.TipoMovimiento=TipoMovimiento.Ingreso;

            micuenta.Movimiento.Add(m);


            micuenta.Saldo += m.Importe;
            
            Console.WriteLine(micuenta.Movimiento[0].Importe);
            Console.ReadKey();
        }
    }
}
