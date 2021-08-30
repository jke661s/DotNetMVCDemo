﻿using EazyParkingWithAuth.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EazyParkingWithAuth.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customerList = _context.CustomerSet.Include(c => c.MembershipType).ToList();
            return View(customerList);
            //return View();
        }

        // GET: customers/details/{id}
        public ActionResult Details(int id)
        {
            var customer = _context.CustomerSet.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            return View();
        }
    }
}