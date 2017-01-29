using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wedd.Models.Home;
using Wedd.Utils;

namespace Wedd.Controllers {
	[RoutePrefix("")]
	public class HomeController : BaseController {

		private GuestHelper _guestHelper;

		public HomeController() {
			_guestHelper = new GuestHelper { };
		}

		[Route("{id?}")]
		public ActionResult Index(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			if(guest.Id != id) {
				return RedirectToAction("Index", "Home", new { id = "" });
			}
			return View(guest);
		}

		[Route("Ceremony/{id?}")]
		public ActionResult Ceremony(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			if(guest.Id != id) {
				return RedirectToAction("Ceremony", "Home", new { id = "" });
			}
			return View(guest);
		}

		[Route("Restaurant/{id?}")]
		public ActionResult Restaurant(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			if(guest.Id != id) {
				return RedirectToAction("Restaurant", "Home", new { id = "" });
			}
			return View(guest);
		}

		[Route("InvitationCard/{id?}")]
		public ActionResult InvitationCard(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			if(guest.Id != id) {
				return RedirectToAction("InvitationCard", "Home", new { id = "" });
			}
			return View(guest);
		}

		[Route("GuestTable/{id?}")]
		public ActionResult GuestTable(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			if(string.IsNullOrEmpty(guest.Id) || guest.Id != id) {
				return RedirectToAction("Index", "Home", new { id = "" });
			}
			return View(guest);
		}

		[Route("CountDown/{id?}"), HttpGet]
		public ActionResult CountDown(string id) {
			var guest = (GuestViewModel)_guestHelper.GetGuest(id);
			ViewBag.userId = guest.Id;
			return View(guest);
		}
	}
}