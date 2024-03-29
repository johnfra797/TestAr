﻿using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using TestAr.Aplicacion.Definiciones;
using TestAr.DTO;
using TestAr.IoC;
using TestAr.WebII.Models;

namespace TestAr.WebII.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class UsuarioController : Controller
    {
        IServicioAplicacionUsuario servicioAplicacionUsuario = FactoryContainer.Resolver<IServicioAplicacionUsuario>();
        IServicioAplicacionRole servicioAplicacionRole = FactoryContainer.Resolver<IServicioAplicacionRole>();

        

        // GET: Usuario
        public ActionResult Index()
        {
            return View(new List<Usuario>());
        }
       
        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }
        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View(id);
        }
        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View(id);
        }
        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       
    }
}
