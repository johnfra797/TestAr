using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAr.WebII.Controllers
{
    [Authorize()]
    public class ComentarioController : Controller
    {
        // GET: Comentario
        [Authorize(Roles = "Editor,Administrador,Visitante,Consulta,Usuario Autenticado")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Editor,Administrador")]
        // GET: Comentario/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }
        [Authorize(Roles = "Editor,Administrador,Usuario Autenticado")]
        // GET: Comentario/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Comentario/Create
        [HttpPost]
        [Authorize(Roles = "Editor,Administrador,Usuario Autenticado")]
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
        [Authorize(Roles = "Editor,Administrador")]
        public ActionResult Edit(int id)
        {
            return View(id);
        }
        [Authorize(Roles = "Editor,Administrador")]
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
        [Authorize(Roles = "Editor,Administrador")]
        public ActionResult Delete(int id)
        {
            return View(id);
        }
        [Authorize(Roles = "Editor,Administrador")]
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
