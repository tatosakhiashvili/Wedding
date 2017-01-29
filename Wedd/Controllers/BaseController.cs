using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Wedd.Controllers {
	public class BaseController : Controller {
		protected internal JsonResult JsonResult(object model) {
			return Json(new { data = model }, JsonRequestBehavior.AllowGet);
		}
	}
}
