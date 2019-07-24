using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinicalServicesDashboard.Models;
using Newtonsoft.Json;

namespace ClinicalServicesDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetServicesTally(string target)
        {
            if (target == null)
            {
                target = "clinic";
            }

            target = char.ToUpper(target[0]) + target.Substring(1);
            var targetServer = ConfigurationManager.AppSettings["ServiceTallyServer"];
            var bag = new TallySetupBag
            {
                Target = target,
                TallyServicesServer=targetServer
            };


            
            return View(bag);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}