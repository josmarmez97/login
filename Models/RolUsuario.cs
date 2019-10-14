using System;
using System.Collections.Generic;

namespace login.Models
{
    public partial class RolUsuario
    {
        public int IdRolUsuarios { get; set; }
        public int? IdUsuarios { get; set; }
        public int? IdRol { get; set; }

        public virtual Roles IdRolNavigation { get; set; }
        public virtual Usuarios IdUsuariosNavigation { get; set; }
    }
}
