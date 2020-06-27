using Microsoft.EntityFrameworkCore;
using BilleteraVirtualMVC.Models;

namespace BilleteraVirtualMVC.Context
{
    public class BilleteraContext : DbContext
    {
        public BilleteraContext(DbContextOptions<BilleteraContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }
        
        public DbSet<Cuenta> Cuentas { get; set; }
    }
}
