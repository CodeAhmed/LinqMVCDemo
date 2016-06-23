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

        //public JsonResult Index()
        public ActionResult Index()
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
            List<ObjectData> obj = new List<ObjectData>();
            var query = demos.GroupBy(m => m.ObjType).ToList();
            foreach (var subgroup in query)
            {
                obj.Add(new ObjectData() { ObjectType = subgroup.Key , ObjectName="Type"});
                //Console.WriteLine(subgroup.Key + ":");
                var query2 = subgroup.GroupBy(m => m.ObjSubType);
                    foreach(var subgroup2 in query2)
                    {
                        obj.Add(new ObjectData() { ObjectType = subgroup2.Key, ObjectName = "SubType" });
                        //Console.WriteLine(subgropu2.Key);
                        foreach (Menu m in subgroup2)
                            obj.Add(new ObjectData() { ObjectType = m.ObjName, ObjectName = "Object" });
                            //Console.WriteLine(m.ObjName);
                    }
                
                    
            }
           // return Json(obj, JsonRequestBehavior.AllowGet);
            return View(obj);
        }
    }
}