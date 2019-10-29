using System;
using System.Linq;
using login.Models;
using login_martin.Models;
using Microsoft.AspNetCore.Mvc;
namespace login.Controllers
{
    public class LoginController : Controller
    {          
        public IActionResult ViewG()
        {
            var context = new loginContext();
            var usuarios =(
                    from e in context.Usuarios
                    join p in context.RolUsuario on e.id equals p.id_usuarios
                    join r in context.Roles on p.id_rol equals r.id
                        select new Vistas(){
                            id =e.id,
                            userid = e.userid,
                            nombre = e.nombre,
                            privilegio = r.nombre_rol,
                            pass = e.pass
                        }
            ).ToList();
            return View(usuarios);            
        }      
        public IActionResult ViewSU()
        {
            var context = new loginContext();
           //var listado_usuarios = context.Usuarios.ToList();
            var usuarios =(
                    from e in context.Usuarios
                    join p in context.RolUsuario on e.id equals p.id_usuarios
                    join r in context.Roles on p.id_rol equals r.id
                        select new Vistas(){
                            id =e.id,
                            userid = e.userid,
                            nombre = e.nombre,
                            privilegio = r.nombre_rol,
                            pass = e.pass
                        }
            ).ToList();
            return View(usuarios);            
        }
        

         public IActionResult Detalles(int id)
        {            
            var context = new loginContext();
            var r = context.Usuarios.Single(Usuarios=>Usuarios.id==id);
            return View(r);
        }
        
        public IActionResult IngresarUsuario()
        {
            return View();
        }
        public IActionResult Ingresa()
        {
            
           var context = new loginContext();
           var roles = context.Roles.ToList();
            return View(roles);
        }
        
        [HttpPost]
        public IActionResult Guardar()
        {                        
               // var context = new loginContext();
                //var r = context.Usuarios.Single(Usuarios=>Usuarios.userid==);            
                //var x = context.Usuarios.Update(nuevos_datos);
               // context.SaveChanges(); 
                return RedirectToAction("ViewSU");
        }

        [HttpPost]
        public IActionResult Registrar()
        {   
            //ESTO FUNKA (no mover)
            var context = new loginContext();                        
            Usuarios nuevo = new Usuarios();                                     
            nuevo.userid = Request.Form["usuario_registra"].ToString();
            nuevo.nombre = Request.Form["nombre_registra"].ToString();
            nuevo.pass = Request.Form["pass_registra"].ToString();
            context.Add(new Usuarios{userid=nuevo.userid,nombre=nuevo.nombre,pass=nuevo.pass});             
             context.SaveChanges();
            var r = context.Usuarios.Last();
            var id_usuario = r.id.ToString();

            RolUsuario nuevoRolUsuario = new RolUsuario();  

            nuevoRolUsuario.id_rol=Int32.Parse(Request.Form["rol"]);

            Console.WriteLine( "\n El id_rol es: "+nuevoRolUsuario.id_rol + "\n");

            nuevoRolUsuario.id_usuarios=Int32.Parse(id_usuario);

            Console.WriteLine("\n El Id_Usuario es: "+ nuevoRolUsuario.id_usuarios+ "\n");
            context.Add(new RolUsuario{id_rol=nuevoRolUsuario.id_rol , id_usuarios=nuevoRolUsuario.id_usuarios});            
            context.SaveChanges();
            return RedirectToAction("ViewSU");            
            
        }

        [HttpPost]   
         public IActionResult Eliminar(int id)
        {           
            Console.WriteLine("El id es: "+id);                    
           using(var context = new loginContext())           
           {
                var eliminarRol = new RolUsuario()
                {
                    id_usuarios=id
                };
                var eliminarUsuario = new Usuarios()
                {
                    id=id
                };
                var roles = context.RolUsuario.Remove(eliminarRol);
                var usuarios = context.Usuarios.Remove(eliminarUsuario);
                context.SaveChanges();
                return RedirectToAction("ViewSU"); 
           }
        }
        
        [HttpPost]
        public IActionResult Login(string usuario, string pass)
        {                
            var context = new loginContext();            
            var r = context.Usuarios.Single(Usuarios=>Usuarios.userid==usuario);  
            var rol = context.RolUsuario.Single(RolUsuario=>RolUsuario.id_usuarios==r.id);
            if (r.userid == usuario && r.pass == pass && rol.id_rol== 1)
            {
                return RedirectToAction("ViewSU");
            }
            else
            {return RedirectToAction("IngresarUsuario");}
                  
        }

    }
}