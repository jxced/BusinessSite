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
    public partial class ProductsView
    {
        public int Id { get; set; }
        public string PhothId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string ImgUrl { get; set; }
        public string Content { get; set; }
        public int SortId { get; set; }
        public int Clicks { get; set; }
        public System.DateTime AddTime { get; set; }
        public bool IsLock { get; set; }
    }
}
