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
    
    public partial class Category
    {
        public int CategoryId { get; set; }
        public int CategoryTypeId { get; set; }
        public string CategroyTitle { get; set; }
        public int ParentId { get; set; }
    }
}