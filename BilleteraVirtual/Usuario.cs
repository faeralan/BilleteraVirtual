﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilleteraVirtual
{
    class Usuario
    {
        public String Nombre{ get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Cuenta cuenta { get; set; }
    }
}
