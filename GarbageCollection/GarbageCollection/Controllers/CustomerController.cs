using GarbageCollection.Data;
using GarbageCollection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GarbageCollection.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        private ApplicationDbContext dbContext;

        public CustomerController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public ActionResult Customer()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            if (customer == null)
            {
                return new RedirectToActionResult("Create", "Customer", null);  
            }
          // may need to create new customer
            return View(customer);
        }
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(userId);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details()
        {
            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            Customer NewCustomer = new Customer();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            NewCustomer.IdentityUserId = userId;
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer NewCustomer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            NewCustomer.IdentityUserId = userId;

            try
            {
                dbContext.Customers.Add(NewCustomer);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
