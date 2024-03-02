using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using System.Diagnostics;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyecto().Take(3).ToList();
            var model = new HomeIndexViewModel() { Proyecto = proyectos };
            return View(model);
        }

        private List<Proyecto> ObtenerProyecto()
        {
            return new List<Proyecto>() {
                new Proyecto
                { Titulo = "App Para certificaciones Microsoft",
                    Descripcion = " Portal de entretenimiento tecnologias Microsoft",
                    Link = "https://learn.microsoft.com/es-es/certifications",
                    ImagenURL = "/imagenes/Microsoft.jpg"



                },
                    new Proyecto

                {
                    Titulo = "Grupo Bancolombia",
                    Descripcion = "Desarrollo App Clientes",
                    Link = "https://www.bancolombia.com/personas//",
                    ImagenURL = "/imagenes/Bancolombia.png"



                },
                     new Proyecto

                {
                    Titulo = "Desarrollo App Virtual Exito ",
                    Descripcion = "Desarrollo App compras Online Angular",
                    Link = "https://www.exito.com//",
                    ImagenURL = "/imagenes/exito.jpg"



                },
                      new Proyecto

                {
                      Titulo = "Desarrollo App Simulador de Prestamos",
                      Descripcion = "Desarrollo App de Prestamos",
                      Link = "https://www.bancoldex.com/",
                      ImagenURL = "/imagenes/bancoldex.png"



                },





            };
        }

            public IActionResult Privacy()
            {

                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
    }
}
