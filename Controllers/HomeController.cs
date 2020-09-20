using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Inmobiliaria.Models;

namespace Inmobiliaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioInmuebles repositorioInmuebles;
        private readonly RepositorioPropietarios repositorioPropietarios;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioInmuebles = new RepositorioInmuebles(configuration);
            repositorioPropietarios = new RepositorioPropietarios(configuration);
        }
        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult Galeria()
        {
            var lista = repositorioInmuebles.ObtenerTodos();
            return View(lista);
        }

        [Authorize(Policy = "Administrador")]
        public IActionResult SuperRestringido()
        {
            return View();
        }

        [Authorize(Policy = "Propietario")]
        public IActionResult Privado()
        {
            Propietarios p = repositorioPropietarios.ObtenerPorEmail(User.Identity.Name);
            var lista = repositorioInmuebles.BuscarPorPropietario(p.IdProp);
            return View(lista);

        }

        [Authorize(Policy = "Empleado")]
        public IActionResult AlgoRestringido()
        {
            return View();
        }
        public IActionResult Restringido()
        {
            return View();
        }

        
    }
}
