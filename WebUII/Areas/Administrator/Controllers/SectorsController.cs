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
    public class SectorsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        SectorService sectorService = new SectorService();

        // GET: Administrator/Sectors
        public ActionResult Index()
        {
            return View(sectorService.GetList());
        }

        // GET: Administrator/Sectors/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sector sector =sectorService.GetById(id);
            if (sector == null)
            {
                return HttpNotFound();
            }
            return View(sector);
        }

        // GET: Administrator/Sectors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Sectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SectorName")] Sector sector)
        {
            if (ModelState.IsValid)
            {
                sector.ID = Guid.NewGuid();
                sectorService.Create(sector);
                return RedirectToAction("Index");
            }

            return View(sector);
        }

        // GET: Administrator/Sectors/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sector sector =sectorService.GetById(id);
            if (sector == null)
            {
                return HttpNotFound();
            }
            return View(sector);
        }

        // POST: Administrator/Sectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SectorName")] Sector sector)
        {
            if (ModelState.IsValid)
            {
                sectorService.Update(sector);
                return RedirectToAction("Index");
            }
            return View(sector);
        }

        // GET: Administrator/Sectors/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sector sector = sectorService.GetById(id);
            if (sector == null)
            {
                return HttpNotFound();
            }
            return View(sector);
        }

        // POST: Administrator/Sectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Sector sector =sectorService.GetById(id);
            sectorService.RemoveForce(sector);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
          
            base.Dispose(disposing);
        }
    }
}
