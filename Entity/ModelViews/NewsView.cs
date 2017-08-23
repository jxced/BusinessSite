//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity.ModelViews
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class NewsView
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("分类名称")]
        public int CategoryId { get; set; }
        [DisplayName("管理员")]
        public int UserId { get; set; }
        [DisplayName("标题")]
        public string Title { get; set; }
        [DisplayName("作者")]
        public string Author { get; set; }
        [DisplayName("来源")]
        public string Form { get; set; }
        [DisplayName("正文")]
        public string Content { get; set; }
        public int SortId { get; set; }
        [DisplayName("点击数")]
        public Nullable<int> Clicks { get; set; }
        [DisplayName("审核")]
        public bool IsLock { get; set; }
        [DisplayName("加入时间")]
        public System.DateTime AddTime { get; set; }
    }
}
