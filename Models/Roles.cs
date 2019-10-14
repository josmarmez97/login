using System;
using System.Collections.Generic;

namespace login.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolUsuario = new HashSet<RolUsuario>();
        }

        public int Id { get; set; }
        public string NombreRol { get; set; }

        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
    }
}
