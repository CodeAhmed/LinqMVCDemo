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

        public ActionResult Index()
        {
            List<Menu> demos = new List<Menu>(){
                new Menu(){ObjType = "OT1", ObjSubType = "OST1", ObjName= "ON1"},
                new Menu(){ObjType = "OT1", ObjSubType = "OST1", ObjName= "ON2"},
                new Menu(){ObjType = "OT1", ObjSubType = "OST1.1", ObjName= "ON1.1"},
                new Menu(){ObjType = "OT1", ObjSubType = "OST1.2", ObjName= "ON1.2"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2", ObjName= "ON2"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2.1", ObjName= "ON2.1"},
                new Menu(){ObjType = "OT2", ObjSubType = "OST2.2", ObjName= "ON2.2"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3", ObjName= "ON3"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3", ObjName= "ON4"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3.1", ObjName= "ON3.1"},
                new Menu(){ObjType = "OT3", ObjSubType = "OST3.2", ObjName= "ON3.2"},
            };

            var query = demos.GroupBy(m => m.ObjType).ToList();
            foreach (var item in query)
            {
                var result = item.GroupBy(m => m.ObjSubType).ToList();
            }
            return View(query);

        }
    }
}