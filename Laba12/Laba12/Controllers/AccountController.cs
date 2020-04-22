using Laba12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Laba12.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                User user = null;
                using (MyDbContext db = new MyDbContext())
                {
                    user = db.Users.FirstOrDefault(u => u.login == model.login && u.password == model.password);

                }
                if (user != null)
                {
                    Session["id"] = user.id;
                    FormsAuthentication.SetAuthCookie(model.login, true);
                    return RedirectToAction("Main", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }
            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                using (MyDbContext db = new MyDbContext())
                {
                    user = db.Users.FirstOrDefault(u => u.login == model.login);
                }
                if (user == null)
                {
                    // создаем нового пользователя
                    using (MyDbContext db = new MyDbContext())
                    {
                        db.Users.Add(new User { login = model.login, password = model.password, surname = model.surname, name = model.name, patronimyc = model.patronimyc });
                        db.SaveChanges();

                        user = db.Users.Where(u => u.login == model.login && u.password == model.password).FirstOrDefault();
                    }
                    // если пользователь удачно добавлен в бд
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.login, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}