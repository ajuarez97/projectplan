using System;
using System.Web.Mvc;
using ProjectPlan.Core;
using ProjectPlan.Models;

namespace ProjectPlan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Globals
            {
                Users = Mapper.GetUsers()
            };
            
            return View(model);
        }

        [HttpGet]
        public JsonResult GetUserInformation(string userId)
        {
            var userInformation = Mapper.GetProjectsByUserId(Convert.ToInt32(userId));

            return Json(userInformation, JsonRequestBehavior.AllowGet);
        }
    }
}