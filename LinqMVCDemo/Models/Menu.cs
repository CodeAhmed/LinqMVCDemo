using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqMVCDemo.Models
{
    public class Menu
    {
        public string ObjType { get; set; }
        public string ObjSubType { get; set; }
        public string ObjName { get; set; }
        public List<Menu> children { get; set; }
    }

    public class ObjectData
    {
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
    }

    public class MenuData
    {
        public string ObjType { get; set; }
        public string ObjSubType { get; set; }
        public string ObjName { get; set; }
        //public List<MenuData> list { get; set; }
    }
}