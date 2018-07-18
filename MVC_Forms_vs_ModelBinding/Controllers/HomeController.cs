using MVC_Forms_vs_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Forms_vs_ModelBinding.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult PickAHouseForm()
		{
			return View();
		}

		[HttpPost]
		public ActionResult PickAHouseForm(FormCollection data)
		{
			bool garage = false;
			if (data["Garage"] == "true")
			{
				garage = true;
			}

			bool yard = false;
			if (data["Yard"] == "true")
			{
				yard = true;
			}

			House h = new House
			{
				City = data["City"],
				SquareFeet = data["SquareFeet"],
				Floors = Convert.ToByte(data["Floors"]),
				Garage = garage,
				Yard = yard,
				Color = data["Color"]
			};

			
			//Validate data for database
			if (HouseDBs.AddHouse(h))
			{
				ViewBag.HouseAdded = true;
				//add to database
			}
			
			return View();

			//HouseDB db = new HouseDB();

			//db.Add(h);
		}

		public ActionResult PickAHouseBinding()
		{
			return View();
		}
	}
}