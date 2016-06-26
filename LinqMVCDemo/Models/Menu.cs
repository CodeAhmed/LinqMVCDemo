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
}