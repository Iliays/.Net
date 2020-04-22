using Laba12.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laba12.Controllers
{
	public class HomeController : Controller
	{
        MyDbContext db = new MyDbContext();

        public ActionResult Index(string data)
		{
            ViewBag.Message = data;
            return View();
		}

        public ActionResult Main()
        {
            int query = Convert.ToInt32(Session["id"]);
            var result = db.Users.ToList().Where(x => x.id == query).Select(x => x.surname + " " + x.name + " " + x.patronimyc).First();
            var res1 = from pl in db.Users
                       join fromWho in db.Messages on pl.id equals fromWho.@from
                       where fromWho.to == query
                       select new List { Title = fromWho.header, login = pl.login, date = fromWho.date };
            ViewBag.res = result;
            return View("Main", res1);
        }

        public ActionResult Message(string Title, string login)
        {
            int idUser = Convert.ToInt32(Session["id"]);
            int query = db.Users.Where(x => x.login.Equals(login)).Select(x => x.id).First();
            var result = db.Messages.Where(x => x.to == idUser && x.from == query && x.header.Equals(Title)).Select(x => x.text).FirstOrDefault();
            ViewBag.Message = result;
            return View();
        }

        public ActionResult Chat()
        {
            string idUser = Convert.ToString(Session["id"]);
            if (string.IsNullOrEmpty(idUser))
                return View("Index");
            else
            {
                return View("Chat");
            }
        }


        [HttpPost]
        public ActionResult SendTheNewMessage(string User, Message model)
        {
            int idUser = Convert.ToInt32(Session["id"]);
            if (string.IsNullOrEmpty(User))
            {
                ModelState.AddModelError("Person", "Некорректный адресант");
            }
            if (string.IsNullOrEmpty(model.header))
            {
                ModelState.AddModelError("header", "Некорректный заголовок");
            }
            if (string.IsNullOrEmpty(model.text))
            {
                ModelState.AddModelError("text", "Некорректный текс");
            }

            if (ModelState.IsValid)
            {
                model.from = idUser;
                model.to = db.Users.Where(x => x.login.Equals(User)).Select(x => x.id).FirstOrDefault();
                model.date = DateTime.Now;
                db.Entry(model).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Main");
            }
            else
            {
                ViewBag.Message = "Не верный ввод";
                return RedirectToAction("Chat");
            }
        }
    }
}