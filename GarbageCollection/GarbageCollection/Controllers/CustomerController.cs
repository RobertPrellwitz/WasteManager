using GarbageCollection.Data;
using GarbageCollection.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GarbageCollection.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public DayOfWeek DayOfWeek { get; set; }

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
            var customerList = dbContext.Customers.Select(c => c);

            return View(customerList);
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
            //if (userId == null)
            //{
            //    //return new 
            //    // return new RedirectResult(https://localhost:44399/Identity/Account/Register)
            //    //return new RedirectToPageResult("localhost:44399/Identity/Account/Register")

            //    return new RedirectToPageResult("/Areas/Identity/Pages/Account",new { area = "Register" } );
             //return new RedirectToPageResult("/Identity/Pages/Account/Register");

            //    //return new RedirectToActionResult("Register","/Identity/Account",null);
            //}
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
                GetCoordinates(NewCustomer);
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer currentCustomer) 
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentCustomer.IdentityUserId = userId;
            try
            {
                dbContext.Customers.Update(currentCustomer);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult EditChangeSvcDt()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditChangeSvcDt(int id, Customer currentCustomer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentCustomer.IdentityUserId = userId;
            try
            {
                dbContext.Customers.Update(currentCustomer);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
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

        public ActionResult Bill(int id,Customer currentCustomer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentCustomer.IdentityUserId = userId;
            // need to add sum function
            var currentBill = dbContext.Transactions.Where(t => t.IdentityUserId == userId);
            return View(currentBill);
        }

       
        
        public ActionResult EditSuspendSvc()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == userId).SingleOrDefault();
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditChangeSvc(int id, Customer currentCustomer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentCustomer.IdentityUserId = userId;
            try
            {
                dbContext.Customers.Update(currentCustomer);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        public async void GetCoordinates(Customer currentCustomer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentCustomer.IdentityUserId = userId;

            string address = currentCustomer.Street + "+" + currentCustomer.City + "+" + currentCustomer.State + "+" + currentCustomer.Zip;
            string baseUrl = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key=AIzaSyCrZa-p1sVQEWYQhN2vRdCQwEpadzlcq2k";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }

            }


        }
    }
}
