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
    public class PagosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioContratos repositorioContratos;
        private readonly RepositorioPagos repositorioPagos;
        private readonly RepositorioInmuebles repositorioInmuebles;

        public PagosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioContratos = new RepositorioContratos(configuration);
            repositorioPagos = new RepositorioPagos(configuration);
            repositorioInmuebles = new RepositorioInmuebles(configuration);
        }
        // GET: PagosController
        public ActionResult Index()
        {
            var lista = repositorioPagos.ObtenerTodos();
            return View(lista);
        }

        // GET: PagosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        
        // GET: PagosController/Create
        public ActionResult Create(int id)
        {
            ViewBag.Contratos = repositorioContratos.ObtenerPorInm(id);
            Contratos c = repositorioContratos.ObtenerPorInm(id);
            IList<Pagos> pagos = repositorioPagos.ObtenerPorContr(c.IdContr);
            if (pagos.Count == 0)
            {
                ViewBag.NumPago = 1;
            }
            else
            {
                int np = pagos.Count;
                ViewBag.NumPago = np + 1;
            }

            return View();
        }

        // POST: PagosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pagos p)
        {
            try
            {
                int res = repositorioPagos.Alta(p);
                return RedirectToAction(nameof(Ver), new {id=p.IdContr});
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
        public ActionResult Ver(int id)
        {
            ViewBag.Contratos = repositorioContratos.ObtenerPorId(id);
            IList<Pagos> pagos = repositorioPagos.ObtenerPorContr(id);
            return View(pagos);
        }

        // GET: PagosController/Edit/5
        public ActionResult Edit(int id)
        {
            var p = repositorioPagos.ObtenerPorId(id);
            return View(p);

        }

        // POST: PagosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pagos p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = repositorioPagos.Modificacion(p);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }


        // GET: PagosController/Delete/5
        public ActionResult Delete(int id)
        {
            var p = repositorioPagos.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(p);
        }

        // POST: PagosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pagos p)
        {
            try
            {
                repositorioPagos.Baja(id);
                return RedirectToAction(nameof(Index));
                
                
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(p);
            }
        }
    }
}
