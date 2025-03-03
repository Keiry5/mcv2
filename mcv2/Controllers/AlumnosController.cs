using mcv2.Db;
using mcv2.Models;
using Microsoft.AspNetCore.Mvc;

namespace mcv2.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AppDbContext _dbConn;
        public AlumnosController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }
        public IActionResult Index()
        {
            List<Alumnos> alumnos = _dbConn.Alumnos.ToList();
            return View(alumnos);
        }
    }
}
