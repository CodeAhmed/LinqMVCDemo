using LinqMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinqMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public JsonResult Index()
        {
            List<Menu> demos = new List<Menu>(){
                new Menu(){ObjType = "OT1", ObjSubType = "OST1", ObjName= "ON1"},
                new Menu(){ObjType = "OT1", ObjSubType = "OST1.1", ObjName= "ON1.1"},
                new Menu(){ObjType = "OT1", ObjSubType = "OST1.2", ObjName= "ON1.2"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2", ObjName= "ON2"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2.1", ObjName= "ON2.1"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2.2", ObjName= "ON2.3"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3", ObjName= "ON3"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3.1", ObjName= "ON3.1"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3.2", ObjName= "ON3.2"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3.3", ObjName= "ON3.3"},
            };
            List<Menu> children = new List<Menu>();
            var query = from temp in demos
                        group temp by new { temp.ObjType, temp.ObjSubType,temp.ObjName } into newgrp
                        select new Menu()
                        {
                            ObjType= newgrp.Key.ObjType,
                            ObjSubType = newgrp.Key.ObjSubType,
                            ObjName = newgrp.Key.ObjName,
                            children = newgrp.ToList(),
                        };
            return Json(query, JsonRequestBehavior.AllowGet);
        }
	}
}