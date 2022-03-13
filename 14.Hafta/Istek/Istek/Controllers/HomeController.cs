using Istek.Context;
using Istek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Istek.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MesajDbContext db = new MesajDbContext();
            var request = db.Mesajs.ToList();
            return View(request);
        }

        [HttpGet]
       public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Mesaj msgData)
        {
            MesajDbContext db = new MesajDbContext();
            db.Mesajs.Add(msgData);
            db.SaveChanges();

            return RedirectToAction("index");
            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            MesajDbContext db = new MesajDbContext();
            var mesaj = db.Mesajs.Find(id);
            return View(mesaj);

        }
        [HttpPost]
        public ActionResult Edit(Mesaj mesaj)
        {
            MesajDbContext db = new MesajDbContext();
            var data = db.Mesajs.Find(mesaj.Id);
            data.Name = mesaj.Name;
            data.Surname = mesaj.Surname;
            data.Phone = mesaj.Phone;
            data.Mail = mesaj.Mail;
            data.Request = mesaj.Request;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            MesajDbContext db = new MesajDbContext();
            var data = db.Mesajs.Find(id);
            db.Mesajs.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}