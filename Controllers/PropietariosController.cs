using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inmobiliaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;

namespace Inmobiliaria.Controllers
{

    public class PropietariosController : Controller
    {
        RepositorioPropietarios repositorioPropietarios;
        public PropietariosController()
        {
            repositorioPropietarios = new RepositorioPropietarios();
        }

        // GET: PropietariosController
        public ActionResult Index()
        {
            var lista = repositorioPropietarios.ObtenerTodos();
            return View(lista);
        }

        // GET: PropietariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropietariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropietariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietarios p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = repositorioPropietarios.Alta(p);
                    TempData["Mensaje"] = "El Propietario ha sido Registrado";
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

        // GET: PropietariosController/Edit/5
        public ActionResult Edit(int id)
        {
            var p = repositorioPropietarios.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(p);
            
        }

        // POST: PropietariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            Propietarios p = null;
            try
            {
                p = repositorioPropietarios.ObtenerPorId(id);
                p.Nombre = collection["Nombre"];
                p.Apellido = collection["Apellido"];
                p.Dni = collection["Dni"];
                p.Email = collection["Email"];
                p.Telefono = collection["Telefono"];
                repositorioPropietarios.Modificacion(p);
                TempData["Mensaje"] = "Datos guardados correctamente";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(p);
            }
        }

        // GET: PropietariosController/Delete/5
        public ActionResult Delete(int id)
        {
            var p = repositorioPropietarios.ObtenerPorId(id);
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            if (TempData.ContainsKey("Error"))
                ViewBag.Error = TempData["Error"];
            return View(p);
            
        }

        // POST: PropietariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Propietarios entidad)
        {
            try
            {
                repositorioPropietarios.Baja(id);
                TempData["Mensaje"] = "El Propietario ha sido Eliminado";
                return RedirectToAction(nameof(Index));
                
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(entidad);
            }
        }
    }
}
