﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BIMS.Models;

namespace BIMS.Controllers
{
    public class BookingDetailsController : Controller
    {
        private BIMSEntities1 db = new BIMSEntities1();

        // GET: BookingDetails
        public ActionResult Index()
        {
            return View(db.BookingDetails.ToList());
        }

        // GET: BookingDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingDetail bookingDetail = db.BookingDetails.Find(id);
            if (bookingDetail == null)
            {
                return HttpNotFound();
            }
            return View(bookingDetail);
        }

        // GET: BookingDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BookingNumber,NameOfClient,Nationality,Detonation,HotelName,CheckIn,CheckOut,TotalNights,NetPrice,SellingRate,Markup,NumberOfPax,Contact,Remarks,SpecialOcassion,Supplier,TotalNumberOfBookings,TotalSelling,TotalNumberOfNights,TotalNetRate")] BookingDetail bookingDetail)
        {
            if (ModelState.IsValid)
            {
                db.BookingDetails.Add(bookingDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookingDetail);
        }

        // GET: BookingDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingDetail bookingDetail = db.BookingDetails.Find(id);
            if (bookingDetail == null)
            {
                return HttpNotFound();
            }
            return View(bookingDetail);
        }

        // POST: BookingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BookingNumber,NameOfClient,Nationality,Detonation,HotelName,CheckIn,CheckOut,TotalNights,NetPrice,SellingRate,Markup,NumberOfPax,Contact,Remarks,SpecialOcassion,Supplier,TotalNumberOfBookings,TotalSelling,TotalNumberOfNights,TotalNetRate")] BookingDetail bookingDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingDetail);
        }

        // GET: BookingDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingDetail bookingDetail = db.BookingDetails.Find(id);
            if (bookingDetail == null)
            {
                return HttpNotFound();
            }
            return View(bookingDetail);
        }

        // POST: BookingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookingDetail bookingDetail = db.BookingDetails.Find(id);
            db.BookingDetails.Remove(bookingDetail);
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
