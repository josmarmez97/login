using System;
using System.Collections.Generic;

namespace login.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            RolUsuario = new HashSet<RolUsuario>();
        }

        public int Id { get; set; }
        public string Userid { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
    }
}
