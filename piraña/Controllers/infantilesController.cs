using System.Linq;
using Microsoft.AspNetCore.Mvc;
using piraña.Data;
using piraña.Models;

namespace piraña.Controllers
{
        public class infantilesController : Controller
        {
            private infantilesContext _context;

            public infantilesController(infantilesContext context)
            {
                _context = context;
            }
            public IActionResult Contacto(){
            return View();
        }
             [HttpPost]
       public IActionResult Nuevo(Usuario u) {
           if (ModelState.IsValid) {
               //Guardar objeto pueblo en la BD
               _context.Add(u);
               _context.SaveChanges();

               return RedirectToAction("Lista");
           }
            return View(u);
        }
        public IActionResult Lista() {
            var infantiles = _context.infantiles.OrderBy(x => x.Usuarios).ToList();
            return View(infantiles);
        }
    }
}