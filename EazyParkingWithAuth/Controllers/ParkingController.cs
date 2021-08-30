using EazyParkingWithAuth.Models;
using EazyParkingWithAuth.ViewModels;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EazyParkingWithAuth.Controllers
{
    public class ParkingController : Controller
    {
        private ApplicationDbContext _context;

        public ParkingController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("parking/index")]
        public ActionResult Index()
        {
            var parkingList = _context.ParkingSet.Include(p => p.Suburb).ToList();
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

        public ActionResult Details(int id)
        {
            var parking = _context.ParkingSet.Include(p => p.Suburb).SingleOrDefault(p => p.Id == id);
            if (parking == null) {
                return HttpNotFound();
            }
            return View(parking);
        }

        public ActionResult Save(Parking parking)
        {
            if (parking.Id == 0)
            {
                _context.ParkingSet.Add(parking);
            } else
            {
                var parkingInDb = _context.ParkingSet.Single(p => p.Id == parking.Id);
                parkingInDb.Name = parking.Name;
                parkingInDb.Address = parking.Address;
                parkingInDb.AvailableAmount = parking.AvailableAmount;
                parkingInDb.SuburbId = parking.SuburbId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Parking");
        }

        public ActionResult Edit(int id)
        {
            var parking = _context.ParkingSet.SingleOrDefault(p => p.Id == id);
            if (parking == null)
            {
                return HttpNotFound();
            }
            var viewModel = new ParkingFormViewModel
            {
                Parking = parking,
                Suburbs = _context.Suburbs.ToList()
            };
            return View("ParkingForm", viewModel);
        }

        public ActionResult New()
        {
            var viewmodel = new ParkingFormViewModel
            {
                Suburbs = _context.Suburbs.ToList()
            };
            return View("ParkingForm", viewmodel);
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