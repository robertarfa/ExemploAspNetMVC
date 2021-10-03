using ExemploAspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recode.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAspNetMVC.Controllers
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
            return View();
        }

        public IActionResult Cursos()
        {
            return View(cursos);
        }

        private static IList<Curso> cursos = new List<Curso>()
        {
            new Curso()
            {
                ID = 1,
                Descricao = "Asp Net MVC",
                CargaHoraria = 40
            },
                new Curso()
            {
                ID = 2,
                Descricao = "Banco de dados",
                CargaHoraria = 30
            },
                    new Curso()
            {
                ID = 3,
                Descricao = "React",
                CargaHoraria = 60
            },
                        new Curso()
            {
                ID = 4,
                Descricao = "HTML e CSS",
                CargaHoraria = 20
            },

        };

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
