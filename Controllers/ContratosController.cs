using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Inmobiliaria.Models;

namespace Inmobiliaria.Controllers
{
    public class ContratosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioInmuebles repositorioInmuebles;
        private readonly RepositorioInquilinos repositorioInquilinos;
        private readonly RepositorioContratos repositorioContratos;

        public ContratosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioInmuebles = new RepositorioInmuebles(configuration);
            repositorioInquilinos = new RepositorioInquilinos(configuration);
            repositorioContratos = new RepositorioContratos(configuration);
        }
        // GET: ContratosController
        public ActionResult Index()
        {
            var lista = repositorioContratos.ObtenerTodos();
            if (TempData.ContainsKey("Id"))
                ViewBag.Id = TempData["Id"];
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            return View(lista);
        }

        // GET: ContratosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContratosController/Create
        public ActionResult Create(int id)
        {
            ViewBag.Inmuebles = repositorioInmuebles.ObtenerPorId(id);
            ViewBag.Inquilinos = repositorioInquilinos.ObtenerTodos();
            return View();
        }

        // POST: ContratosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contratos c)
        {
            try
            {
                // TODO: Add insert logic here
                int res = repositorioContratos.Alta(c);
                Inmuebles inm = repositorioInmuebles.ObtenerPorId(c.IdInm);
                repositorioContratos.Vigente(c);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Inquilinos = repositorioInquilinos.ObtenerTodos();
                ViewBag.Error = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: ContratosController/Edit/5
        public ActionResult Edit(int id)
        {
            var i = repositorioContratos.ObtenerPorId(id);
            ViewBag.Inquilinos = repositorioInquilinos.ObtenerTodos();
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(i);
        }

        // POST: ContratosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Contratos c)
        {
            try
            {
                c.IdContr = id;
                repositorioContratos.Modificacion(c);
                TempData["Mensaje"] = "Datos guardados con exito!!!!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Inquilinos = repositorioInquilinos.ObtenerTodos();
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(c);
            }
        }

        // GET: ContratosController/Delete/5
        public ActionResult Delete(int id)
        {
            var c = repositorioContratos.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(c);
        }

        // POST: ContratosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Contratos c)
        {
            try
            {
                repositorioContratos.Baja(id);
                TempData["Mensaje"] = "El Contrato fue eliminado!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(c);
            }
        }
    }
}
