using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.FW.Context;
using Model.FW.DesignPattern;
using Model.FW.Entity;
using Service.FW.Concrete;

namespace WebUII.Areas.Administrator.Controllers
{
    //[Authorize(Roles = "admin")]
    public class CompaniesController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        CompanyService companyService = new CompanyService();

        //AppDbContext db = Singleton.Context;

        // GET: Administrator/Companies
        public ActionResult Index()
        {
            return View(companyService.GetList());
        }

        // GET: Administrator/Companies/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = companyService.GetById(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Administrator/Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CompanyName,Sector,Adress,City,Country")] Company company)
        {
            if (ModelState.IsValid)
            {
                company.ID = Guid.NewGuid();
                companyService.Create(company);
                return RedirectToAction("Index");
            }

            return View(company);
        }

        // GET: Administrator/Companies/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = companyService.GetById(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Administrator/Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CompanyName,Sector,Adress,City,Country")] Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Update(company);
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Administrator/Companies/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company =companyService.GetById(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Administrator/Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Company company = companyService.GetById(id);
            companyService.RemoveForce(company);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
          
            base.Dispose(disposing);
        }
    }
}
