using System.Linq;
using login.Models;
using Microsoft.AspNetCore.Mvc;
namespace login.Controllers
{
    public class LoginController : Controller
    {        
        public IActionResult Login()
        {
            return View();
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
            var listado_usuarios = context.Usuarios.ToList();
            return View(listado_usuarios);                    
        }
        public IActionResult Ingresa()
        {
            return View();
        }
         public IActionResult Guardar()
        {
            var context = new loginContext();
            Usuarios nuevo = new Usuarios();
            nuevo.Userid = Request.Form["usuario_registra"].ToString();
            nuevo.Nombre = Request.Form["nombre_registra"].ToString();
            nuevo.Pass = Request.Form["pass_registra"].ToString();
            context.Add(new Usuarios{Userid=nuevo.Userid,Nombre=nuevo.Nombre,Pass=nuevo.Pass});
            context.SaveChanges();   
            return RedirectToAction("ViewSU");
        }

        public IActionResult Registrar()
        {
            var context = new loginContext();
            Usuarios nuevo = new Usuarios();
            nuevo.Userid = Request.Form["usuario_registra"].ToString();
            nuevo.Nombre = Request.Form["nombre_registra"].ToString();
            nuevo.Pass = Request.Form["pass_registra"].ToString();
            context.Add(new Usuarios{Userid=nuevo.Userid,Nombre=nuevo.Nombre,Pass=nuevo.Pass});
            context.SaveChanges();   
            return RedirectToAction("ViewSU");
        }

        public IActionResult Eliminar(int id)
        {
            var context = new loginContext();            
            context.Remove(new Usuarios{ Id = id});
            context.SaveChanges(); 
            return RedirectToAction("ViewSU");
        }


    }
}