using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codemasters.Controllers
{
    class links
    {
        public String pageLink;
        public String resource;
        public links(String new_pageLink, String new_resource)
        {
            pageLink = new_pageLink;
            resource = new_resource;
        }
    }
    public class linksController : Controller
    {
        // GET: links
        public ActionResult websites()
        {
            return View();
        }
    }
}