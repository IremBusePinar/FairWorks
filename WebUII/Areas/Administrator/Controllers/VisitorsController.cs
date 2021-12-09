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
    public class VisitorsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        VisitorService visitorService = new VisitorService();

        // GET: Administrator/Visitors
        public ActionResult Index()
        {
            return View(visitorService.GetList());
        }

        // GET: Administrator/Visitors/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
                Visitor visitor = visitorService.GetById(id);

                if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // GET: Administrator/Visitors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Visitors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,CompanyName,PhoneNumber,MailAdress,Occupation")] Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                visitor.ID = Guid.NewGuid();
               visitorService.Create(visitor);
               
                return RedirectToAction("Index");
            }

            return View(visitor);
        }

        // GET: Administrator/Visitors/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor =visitorService.GetById(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Administrator/Visitors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,CompanyName,PhoneNumber,MailAdress,Occupation")] Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                visitorService.Update(visitor);
                return RedirectToAction("Index");
            }
            return View(visitor);
        }

        // GET: Administrator/Visitors/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = visitorService.GetById(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Administrator/Visitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Visitor visitor =visitorService.GetById(id);
            visitorService.RemoveForce(visitor);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
          
            base.Dispose(disposing);
        }
    }
}
