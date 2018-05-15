using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codemasters.BusinessLogic;
using codemasters.BusinessLogic.Interfaces;
using codemasters.Domain.Entities.User;
using codemasters.Models;

namespace codemasters.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                // Initialize AutoMapper
                var data = new ULoginData // TODO: delete this initialization
                {
                    Credential = login.Credential,
                    Password = login.Password
                };
                // Mapper.Initialize(cfg => cfg.CreateMap<UserLogin, ULoginData>()); // TODO: restore AutoMapper
                //var data = Mapper.Map<ULoginData>(login);

                data.LoginIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    // Add cookie
                    //HttpCookie cookie = _session.GenCookie(login.Credential);
                    //ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }

            return View();
        }
    }
}