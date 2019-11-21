using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using TestAr.Aplicacion.Definiciones;
using TestAr.DTO;
using TestAr.IoC;
using TestAr.Web.Models;

namespace TestAr.Web.Controllers
{
    public class UsuarioController : Controller
    {
        IServicioAplicacionUsuario servicioAplicacionUsuario = FactoryContainer.Resolver<IServicioAplicacionUsuario>();
        IServicioAplicacionRole servicioAplicacionRole = FactoryContainer.Resolver<IServicioAplicacionRole>();
        // GET: Usuario
        [Authorize]
        public ActionResult Index()
        {
            return View(new List<Usuario>());
        }
        [Authorize]
        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }
        [Authorize]
        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
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
        [Authorize]
        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View(id);
        }
        [Authorize]
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
        [Authorize]
        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View(id);
        }
        [Authorize]
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
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var usuarioLogin = servicioAplicacionUsuario.Login(login.Email, login.Password);
                if (usuarioLogin != null)
                {
                    CreateTicket(usuarioLogin);
                    return View();
                }
                else
                {
                    return View();
                }
            }
            
            return View();
        }
        private void CreateTicket(UsuarioDTO usuario)
        {
            var userData = new JavaScriptSerializer().Serialize(usuario);

            var authenticationTicket = new FormsAuthenticationTicket(1, usuario.Email, DateTime.Now, DateTime.Now.AddDays(0.5), false, userData);
            var encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);
            FormsAuthentication.SetAuthCookie(usuario.Email, true);
            var theCookie = new HttpCookie(".ckTestAr", encryptedTicket);
            Response.Cookies.Add(theCookie);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
