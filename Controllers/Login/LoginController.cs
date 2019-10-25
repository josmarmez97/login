using System.Linq;
using login.Models;
using Microsoft.AspNetCore.Mvc;
namespace login.Controllers
{
    public class LoginController : Controller
    {        
        public IActionResult Login()
        {
            var context = new loginContext();
            var listado_usuarios = context.Usuarios.ToList();
            var numero_usuarios = listado_usuarios.Count();
            Usuarios us_login = new Usuarios();
            us_login.userid = Request.Form["usuario"].ToString();
            us_login.pass = Request.Form["pass"].ToString();            
            return RedirectToAction("ViewSU");
        }

        public IActionResult ViewSU()
        {
            var context = new loginContext();
            var listado_usuarios = context.Usuarios.ToList();
            return View(listado_usuarios);
        }

        
         public IActionResult Detalles(int id)
        {            
            var context = new loginContext();
            var r = context.Usuarios.Single(Usuarios=>Usuarios.id==id);
            return View(r);
        }
        
        public IActionResult Ingresa()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Guardar()
        {
            var context = new loginContext();
            Usuarios nuevo = new Usuarios();            
            context.SaveChanges();   
            return RedirectToAction("ViewSU");
        }

        public IActionResult Registrar()
        {
            var context = new loginContext();
            Usuarios nuevo = new Usuarios();
            nuevo.userid = Request.Form["usuario_registra"].ToString();
            nuevo.nombre = Request.Form["nombre_registra"].ToString();
            nuevo.pass = Request.Form["pass_registra"].ToString();
            context.Add(new Usuarios{userid=nuevo.userid,nombre=nuevo.nombre,pass=nuevo.pass});
            context.SaveChanges();   
            return RedirectToAction("ViewSU");
        }

      
        public IActionResult Eliminar(int id)
        {            
            var context = new loginContext();            
            context.Remove(new Usuarios{id=id});
            context.SaveChanges(); 
            return RedirectToAction("ViewSU");
        }
        
        

    }
}