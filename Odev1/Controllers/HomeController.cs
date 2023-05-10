using Odev1.Data;
using Odev1.Entities;
using Odev1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Odev1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
           
            User model = db.Users.FirstOrDefault(i => i.UserName == user.UserName && i.Password == user.Password);
            if (model != null)
            {
                return RedirectToAction("Home");
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(i => i.UserName == model.UserName || i.Email == model.Email);
                if (user == null)
                {
                    user = new User()
                    {
                        UserName = model.UserName,
                        Password = model.RePassword,
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };
                    db.Users.Add(user);
                    db.SaveChanges();

                    return RedirectToAction("Login");
                }
                else
                {
                    return View(model);
                }

            }
            return View(model);

        }

    }
}