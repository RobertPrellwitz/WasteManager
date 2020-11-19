using GarbageCollection.Data;
using GarbageCollection.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace GarbageCollection.Controllers
{
    
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller

    {
        
        public static DateTime Today { get; }

        public DayOfWeek WeekDay { get; set; }
        


        // GET: EmployeeController

        private ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext context)
        {
            dbContext = context;
        }


        public ActionResult Index()
        {

            var employees = dbContext.Employees.Select(s => s);
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
           Employee NewEmployee = new Models.Employee();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            NewEmployee.IdentityUserId = userId;
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee NewEmployee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            NewEmployee.IdentityUserId = userId;
            try
            {
                dbContext.Employees.Add(NewEmployee);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
                //return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = dbContext.Employees.Where(employee => employee.IdentityUserId == userId).SingleOrDefault();
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee currentEmployee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            currentEmployee.IdentityUserId = userId;
            try
            {
                dbContext.Employees.Update(currentEmployee);
                dbContext.SaveChanges();
                //return RedirectToAction(nameof(Details));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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

        public ActionResult DailyPickup(string zip)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = dbContext.Employees.Where(employee => employee.IdentityUserId == userId).SingleOrDefault();
            zip = employee.Zip;
            DateTime thisDay = DateTime.Today;
            string day = thisDay.ToString("dddd");
            var todaysPickUps = dbContext.Customers.Where(s => s.PickupDay == day && s.LastPickUp.Value.Date != thisDay.Date && s.Zip == zip 
            || s.SpecialPickup.Value.Date==thisDay.Date && s.LastPickUp.Value.Date != thisDay.Date && s.Zip == zip);

            return View(todaysPickUps);
        }

        public ActionResult AllPickups()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = dbContext.Employees.Where(employee => employee.IdentityUserId == userId).SingleOrDefault();
            string zip = employee.Zip;
            var customerSites = dbContext.Customers.Where(s => s.Zip == zip);
            return View(customerSites);
        }


        public ActionResult CustomerList(string day)
        {
            var customerSites = dbContext.Customers;
            return View(customerSites);
        }


        public ActionResult FilteredCustomerList(string day)
        {
            var  customerSites = dbContext.Customers.Where(s => s.PickupDay == day);
            return View(customerSites);
        }
        // need customer id
        // chck for special pickup
        //chagrge to db
        public ActionResult LogPickup(string id)
            {
            
            var customer = dbContext.Customers.Where(customer => customer.IdentityUserId == id).SingleOrDefault();
            double charge = 25;
            customer.LastPickUp = DateTime.Today;
            dbContext.Customers.Update(customer);
            dbContext.SaveChanges();
            CollectionData data = new CollectionData();
            if (customer.SpecialPickup > Today ) 
            {
                charge = charge * 2;
            }
            data.IdentityUserId = id;
            data.Date = DateTime.Today;
            data.charge = charge;
            dbContext.Transactions.Add(data);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(DailyPickup));
        }

       
    }
}
