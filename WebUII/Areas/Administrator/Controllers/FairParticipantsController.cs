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
    public class FairParticipantsController : Controller
    {
        //private AppDbContext db = new AppDbContext();
        FairParticipantService fairParticipantService = new FairParticipantService();

        // GET: Administrator/FairParticipants
        public ActionResult Index()
        {
            return View(fairParticipantService.GetList());
        }

        // GET: Administrator/FairParticipants/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FairParticipant fairParticipant =fairParticipantService.GetById(id);
            if (fairParticipant == null)
            {
                return HttpNotFound();
            }
            return View(fairParticipant);
        }

        // GET: Administrator/FairParticipants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/FairParticipants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SalesPerson,MeetingDate,CompanyProfile,ExtraNotes,OfferDate,LastOfferDate,ContractDate,ContractType,StandType,M2Price,DiscountRate,Price")] FairParticipant fairParticipant)
        {
            if (ModelState.IsValid)
            {
                fairParticipant.ID = Guid.NewGuid();
                fairParticipantService.Create(fairParticipant);
                return RedirectToAction("Index");
            }

            return View(fairParticipant);
        }

        // GET: Administrator/FairParticipants/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FairParticipant fairParticipant =fairParticipantService.GetById(id);
            if (fairParticipant == null)
            {
                return HttpNotFound();
            }
            return View(fairParticipant);
        }

        // POST: Administrator/FairParticipants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SalesPerson,MeetingDate,CompanyProfile,ExtraNotes,OfferDate,LastOfferDate,ContractDate,ContractType,StandType,M2Price,DiscountRate,Price")] FairParticipant fairParticipant)
        {
            if (ModelState.IsValid)
            {
                fairParticipantService.Update(fairParticipant);
                return RedirectToAction("Index");
            }
            return View(fairParticipant);
        }

        // GET: Administrator/FairParticipants/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FairParticipant fairParticipant =fairParticipantService.GetById(id);
            if (fairParticipant == null)
            {
                return HttpNotFound();
            }
            return View(fairParticipant);
        }

        // POST: Administrator/FairParticipants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            FairParticipant fairParticipant = fairParticipantService.GetById(id);
            fairParticipantService.RemoveForce(fairParticipant);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
          
            base.Dispose(disposing);
        }
    }
}
