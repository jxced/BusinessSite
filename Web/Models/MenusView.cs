//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models//Entity.ModelViews
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class MenusView
    {
        public int MenusId { get; set; }
        public int MenusParentId { get; set; }
        public string MenusName { get; set; }
        public string MenusUrl { get; set; }
        public int MenusSortId { get; set; }
        public bool MenusStatus { get; set; }
        public string MenusIco { get; set; }
        public int MenusLevel { get; set; }
        public string MenusRemark { get; set; }
        public string exp1 { get; set; }
        public Nullable<int> exp2 { get; set; }
        public System.DateTime MenusAddTime { get; set; }
    }
}
