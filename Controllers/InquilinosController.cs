using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inmobiliaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inmobiliaria.Controllers
{
    public class InquilinosController : Controller
    {
        RepositorioInquilinos repositorioInquilinos;

        public InquilinosController()
        {
            repositorioInquilinos = new RepositorioInquilinos();
        }
        // GET: InquilinosController1
        public ActionResult Index()
        {
            var lista = repositorioInquilinos.ObtenerTodos();
            return View(lista);
            
        }

        // GET: InquilinosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InquilinosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InquilinosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inquilinos i)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = repositorioInquilinos.Alta(i);
                    TempData["Mensaje"] = "El Inquilino ha sido Registrado";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["Mensaje"] = "Error de registro Verifique datos!!!";
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: InquilinosController1/Edit/5
        public ActionResult Edit(int id)
        {
            var i = repositorioInquilinos.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(i);
            
        }

        // POST: InquilinosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            Inquilinos i = null;
            try
            {
                i = repositorioInquilinos.ObtenerPorId(id);
                i.Nombre = collection["Nombre"];
                i.Apellido = collection["Apellido"];
                i.Dni = collection["Dni"];
                i.Telefono = collection["Telefono"];
                i.DireccionTrabajo = collection["DireccionTrabajo"];
                repositorioInquilinos.Modificacion(i);
                TempData["Mensaje"] = "Datos guardados con Exito!!";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(i);
                
            }
        }

        // GET: InquilinosController1/Delete/5
        public ActionResult Delete(int id)
        {
            var i = repositorioInquilinos.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(i);
        }

        // POST: InquilinosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Inquilinos entidad)
        {
            try
            {
                repositorioInquilinos.Baja(id);
                TempData["Mensaje"] = "El Inquilino ha sido Eliminado";
                return RedirectToAction(nameof(Index));


            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(entidad);
                
            }
        }
    }
}
