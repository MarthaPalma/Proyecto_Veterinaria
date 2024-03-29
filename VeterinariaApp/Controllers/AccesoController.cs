﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinariaBL;
using VeterinariaBE;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using System.Configuration;
using VeterinariaApp.Helpers.Sesion;

namespace VeterinariaApp.Controllers
{
    public class AccesoController : Controller
    {

        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        
        public ActionResult RecuperarContraseña()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string correo, string contraseña)
        {
           
            try
            {
                var OUser = AccesoBL.Login2(correo,contraseña);

                if(OUser.idrol == null)
                {
                    ViewBag.Error = "Usuario o contraseña invalida";
                    return View();
                }
                else if (OUser.idrol == 1)      // administrador
                {
                    //Session["User"] = OUser;
                    AdministradorSesion.Usuario = OUser;
                    AdministradorSesion.SesionActiva = true;
                    FormsAuthentication.SetAuthCookie(OUser.dni, true);
                    return RedirectToAction("IndexAdmin", "Home");

                }
                else if (OUser.idrol == 2)      // personal
                {
                    //Session["User"] = OUser;
                    AdministradorSesion.Usuario = OUser;
                    AdministradorSesion.SesionActiva = true;
                    FormsAuthentication.SetAuthCookie(OUser.dni, true);
                    return RedirectToAction("IndexPersonal", "Home");

                }
                else if (OUser.idrol == 3)      // cliente
                {
                    //Session["User"] = OUser;
                    AdministradorSesion.Usuario = OUser;
                    AdministradorSesion.SesionActiva = true;
                    FormsAuthentication.SetAuthCookie(OUser.dni, true);
                    return RedirectToAction("IndexCliente", "Home");

                }
                else
                {
                    //Session["User"] = OUser;
                    AdministradorSesion.Usuario = OUser;
                    AdministradorSesion.SesionActiva = true;
                    FormsAuthentication.SetAuthCookie(OUser.dni, true);
                    return RedirectToAction("Index", "Tienda");

                }

            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                return View();
            }

        }

        [HttpPost]
        public ActionResult RecuperarContraseña(string correo,string dni,string contraseña)
        {
            try
            {
                AccesoBL.RecuperarContraseña(correo, dni, contraseña);
                
                ViewBag.MENSAJE = "Exito";
                return View();
            }
            catch 
            {
                return View();

            }
        }

        [AllowAnonymous]
        [OutputCache(NoStore = true, Duration = 0)]
        public ActionResult CerrarSesion()
        {
            AdministradorSesion.SesionActiva = false;
            AdministradorSesion.CerrarSession();
            return RedirectToAction("Login", "Acceso");
        }


    }
}