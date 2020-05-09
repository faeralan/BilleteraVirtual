namespace BilleteraVirtual
{
    public class BilleteraContext : DbContext
    {
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JIESA0P\SQLEXPRESS;Database=BilleteraVirtual ;Trusted_Connection=True;");
        }
    }
}
