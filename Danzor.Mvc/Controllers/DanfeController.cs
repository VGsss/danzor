using Danzor.Print;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Danzor.Mvc.Controllers
{
    public class DanfeController : Controller
    {
        // GET: Danfe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Danfe()
        {
            string path = HttpContext.Server.MapPath("~/Content/NFe28090708060730000190550020000001762000007303procNFe.xml");
            DanzorPrintViewer model = new DanzorPrintViewer(path);

            return View("~/Views/Danfe/Danfe.cshtml", model);
        }
    }
}