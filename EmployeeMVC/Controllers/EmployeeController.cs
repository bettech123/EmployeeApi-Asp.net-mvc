using EmployeeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployee> empList;
            // ("Employees") is for the name of Api controller.
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployee>>().Result;
            return View(empList);
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {

            return View(new mvcEmployee());
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcEmployee emp)
        {
            HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("Employees", emp).Result;
            TempData["SucessMessage"] = "Saved Succesfully";
            return RedirectToAction("Index");
        }
    }
}