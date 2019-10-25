﻿using System;
using System.Collections.Generic;

namespace login.Models
{
    public class Usuarios
    {        
        public int id { get; set; }
        public string userid { get; set; }
        public string nombre { get; set; }
        public string pass { get; set; }

        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
        public Usuarios()
        {
            RolUsuario = new HashSet<RolUsuario>();
        }
    }
}
