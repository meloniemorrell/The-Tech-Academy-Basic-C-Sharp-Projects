using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //calculate quote
                var quote = CalcQuote(insuree);
                insuree.Quote = quote > 0 ? quote : insuree.Quote;
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        private decimal CalcQuote(Insuree insuree)
        {
            decimal baseRate = 50m;
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-age)) age--;

            var ageAddition = 0m;
            if (age < 18)
            {
                ageAddition = 100m;
            } else if (age > 18 && age < 26) {
                ageAddition = 50m;
            } else if (age > 25)
            {
                ageAddition = 25m;
            }

            var carAddition = 0m;
            if (insuree.CarYear < 2000)
            {
                carAddition = 25m;
            } else if (insuree.CarYear > 2015)
            {
                carAddition = 25m;
            }

            var makeAddition = 0m;
            if (insuree.CarMake.Trim().ToLower() == "Porsche")
            {
                makeAddition = 25m;

                if (insuree.CarModel.Trim().ToLower() == "911 Carrera")
                {
                    makeAddition += 25m;
                }
            }

            var ticketAddition = 0m;
            if (insuree.SpeedingTickets > 0)
            {
                ticketAddition = insuree.SpeedingTickets * 10;
            }

            var subTotal = baseRate + ageAddition + carAddition + makeAddition + ticketAddition;

            if (insuree.DUI)
            {
                subTotal += (subTotal * .25m);
            }

            if (insuree.CoverageType)
            {
                subTotal += (subTotal * .50m);
            }

            return subTotal;
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
