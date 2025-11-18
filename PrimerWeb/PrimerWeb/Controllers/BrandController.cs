using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrimerWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


// Aqui lo que se hace es configurar el controlador de la tabla de Producto. Se crea una clase controlador que hereda el codigo del controlador principal (HomeController)
namespace PrimerWeb.Controllers
{
    public class BrandController : Controller
    {
        //Por asi decirlo, aqui se hace mención a la conexión de la base de datos
        private readonly PracticaDbContext _appDbContext;

        public BrandController(PracticaDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task <IActionResult> Lista()
        {
            List<Producto> lista = await _appDbContext.Productos.ToListAsync();
            return View(lista);
        }
    }
}
