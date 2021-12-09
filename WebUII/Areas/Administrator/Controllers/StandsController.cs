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
    public class StandsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        StandService standService = new StandService();

        // GET: Administrator/Stands
        public ActionResult Index()
        {
            return View(standService.GetList());
        }

        // GET: Administrator/Stands/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stand stand =standService.GetById(id);
            if (stand == null)
            {
                return HttpNotFound();
            }
            return View(stand);
        }

        // GET: Administrator/Stands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Stands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StandNumber,M2,M2Price")] Stand stand)
        {
            if (ModelState.IsValid)
            {
                stand.ID = Guid.NewGuid();
                standService.Create(stand);
                return RedirectToAction("Index");
            }

            return View(stand);
        }

        // GET: Administrator/Stands/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stand stand =standService.GetById(id);
            if (stand == null)
            {
                return HttpNotFound();
            }
            return View(stand);
        }

        // POST: Administrator/Stands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StandNumber,M2,M2Price")] Stand stand)
        {
            if (ModelState.IsValid)
            {
                standService.Update(stand);
                return RedirectToAction("Index");
            }
            return View(stand);
        }

        // GET: Administrator/Stands/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stand stand = standService.GetById(id);
            if (stand == null)
            {
                return HttpNotFound();
            }
            return View(stand);
        }

        // POST: Administrator/Stands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Stand stand =standService.GetById(id);
            standService.RemoveForce(stand);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
           
            base.Dispose(disposing);
        }
    }
}
