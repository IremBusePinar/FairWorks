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
    public class FairsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        FairService fairService = new FairService();

        // GET: Administrator/Fairs
        public ActionResult Index()
        {
            return View(fairService.GetList());
        }

        // GET: Administrator/Fairs/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fair fair = fairService.GetById(id);
            if (fair == null)
            {
                return HttpNotFound();
            }
            return View(fair);
        }

        // GET: Administrator/Fairs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Fairs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FairName,FirstDay,LastDay,TheNumberOfParticipant")] Fair fair)
        {
            if (ModelState.IsValid)
            {
                fair.ID = Guid.NewGuid();
                fairService.Create(fair);
                return RedirectToAction("Index");
            }

            return View(fair);
        }

        // GET: Administrator/Fairs/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fair fair = fairService.GetById(id);
            if (fair == null)
            {
                return HttpNotFound();
            }
            return View(fair);
        }

        // POST: Administrator/Fairs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FairName,FirstDay,LastDay,TheNumberOfParticipant")] Fair fair)
        {
            if (ModelState.IsValid)
            {
                fairService.Update(fair);
                return RedirectToAction("Index");
            }
            return View(fair);
        }

        // GET: Administrator/Fairs/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fair fair = fairService.GetById(id);
            if (fair == null)
            {
                return HttpNotFound();
            }
            return View(fair);
        }

        // POST: Administrator/Fairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Fair fair = fairService.GetById(id);
            fairService.RemoveForce(fair);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            
            base.Dispose(disposing);
        }
    }
}
