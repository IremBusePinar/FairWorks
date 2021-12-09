using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.FW.Context;
using Model.FW.Entity;
using Service.FW.Concrete;

namespace WebUII.Areas.Administrator.Controllers
{
    //[Authorize(Roles = "admin")]
    public class SalloonsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        SalloonService salloonService = new SalloonService();

        // GET: Administrator/Salloons
        public ActionResult Index()
        {
            return View(salloonService.GetList());
        }

        // GET: Administrator/Salloons/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salloon salloon =salloonService.GetById(id);
            if (salloon == null)
            {
                return HttpNotFound();
            }
            return View(salloon);
        }

        // GET: Administrator/Salloons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Salloons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SalloonName,WhichSector,StandNumber")] Salloon salloon)
        {
            if (ModelState.IsValid)
            {
                salloon.ID = Guid.NewGuid();
                salloonService.Create(salloon);
                
                return RedirectToAction("Index");
            }

            return View(salloon);
        }

        // GET: Administrator/Salloons/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salloon salloon = salloonService.GetById(id);
            if (salloon == null)
            {
                return HttpNotFound();
            }
            return View(salloon);
        }

        // POST: Administrator/Salloons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SalloonName,WhichSector,StandNumber")] Salloon salloon)
        {
            if (ModelState.IsValid)
            {
                salloonService.Update(salloon);
                return RedirectToAction("Index");
            }
            return View(salloon);
        }

        // GET: Administrator/Salloons/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salloon salloon = salloonService.GetById(id);
            if (salloon == null)
            {
                return HttpNotFound();
            }
            return View(salloon);
        }

        // POST: Administrator/Salloons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Salloon salloon = salloonService.GetById(id);
            salloonService.RemoveForce(salloon);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
        
            base.Dispose(disposing);
        }
    }
}
