﻿using EazyParkingWithAuth.Models;
using EazyParkingWithAuth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EazyParkingWithAuth.Controllers
{
    public class ParkingController : Controller
    {
        [Route("parking/index")]
        public ActionResult Index()
        {
            var parkingList = new List<Parking>
            {
                new Parking { Name = "Caulfied" },
                new Parking { Name = "Clayton" }
            };
            return View(parkingList);
        }

        // GET: Parking/Random
        public ActionResult Random()
        {
            var parking = new Parking { Name = "Caulfield" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };
            var viewModel = new RandomParkingViewModel
            {
                Customers = customers,
                Parking = parking
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0} and sortBy = {1}", pageIndex, sortBy));
        }

        [Route("parking/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}