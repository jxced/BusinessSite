//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
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
    
        public virtual Category Category { get; set; }
    }
}
