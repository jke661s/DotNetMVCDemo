using EazyParkingWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EazyParkingWithAuth.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer { Id = 1, Name = "Jackie" },
                new Customer { Id = 2, Name = "Allen" }
            };
            return customerList;
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customerList = GetCustomers();
            return View(customerList);
            //return View();
        }

        // GET: customers/details/{id}
        public ActionResult Details(Customer customer)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == customerId);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}