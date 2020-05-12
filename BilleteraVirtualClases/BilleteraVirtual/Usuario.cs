using System;
using System.Collections.Generic;
using System.Text;


namespace BilleteraVirtual
{
    class Usuario
    {
        public int UsuarioId { get; set; }
        public String Nombre{ get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
