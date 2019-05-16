using MvcPatronRepo.Models;
using MvcPatronRepo.Services.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPatronRepo.Controllers
{
    public class ClientesController : Controller
    {

        private ServicesClientes _servicesClientes;

        public ClientesController()
        {
            _servicesClientes = new ServicesClientes();
        }
        // GET: Clientes
        public ActionResult Index()
        {
            var model = _servicesClientes.GetAll();

            return View(model);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicesClientes.Add(clientes);
                    return RedirectToAction("Index");


                }

                
            }
            catch
            {
                
            }
            return View();
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {

            var model = _servicesClientes.GetById(id);
            return View(model);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Clientes clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicesClientes.update(clientes);

                    return RedirectToAction("Index");
                }

                
            }
            catch
            {
                
            }
            return View();
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _servicesClientes.GetById(id);
            return View(model);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid) {

                    _servicesClientes.Delete(id);
                return RedirectToAction("Index");

                }
            }
            catch
            {
                
            }
            return View();
        }
    }
}
