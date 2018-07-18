using MVC_Forms_vs_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Forms_vs_ModelBinding.Controllers
{
    public class BindingFormController : Controller
    {
        // GET: BindingForm
		[HttpGet]
        public ActionResult FormWithBinding()
        {
            return View();
        }
		[HttpPost]
		public ActionResult FormWithBinding(Models.House h)
		{
			if (ModelState.IsValid)
			{
				HouseDBs.AddHouse(h);
			}
			return View();
		}
    }
}