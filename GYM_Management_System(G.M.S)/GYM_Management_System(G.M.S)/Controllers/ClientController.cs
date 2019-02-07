using GYM_Management_System_G.M.S_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM_Management_System_G.M.S_.Controllers
{
    public class ClientController : Controller
    {
        Models.gym_managementEntities1 db = new Models.gym_managementEntities1();
        // GET: Client
        public ActionResult ClientRegistration() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult ClientRegistration(Models.Client client)
        {
            ViewBag.Message = "Your application description page.";
            //client.Attendences = new List<Attendence>();
            //client.ClientBills = new List<ClientBill>();
            //client.ClientServiceLists = new List< ClientServiceList >();
            //client.FoodPlans = new List< FoodPlan > ();
            //client.Schedules = new List< Schedule > ();
            //client.ScheduleTimes = new List< ScheduleTime > ();
            //client.Sells = new List<Sell>();


            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                try
                {
                    db.SaveChanges();
                    return RedirectToAction("ClientRegistration");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View();
        }

        public ActionResult ClientInformation()
        {
            return View(db.Clients.ToList());

        }
        

        public ActionResult ClientServieList() 
        {
            return View();
        }

        public ActionResult ClientBill()
        {
            return View();
        }

        public ActionResult BillTrangection()
        {
            return View();
        }
    }
}