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
    public partial class FeedbackView
    {
        public int FeedbackId { get; set; }
        public string FeedbackTitle { get; set; }
        public string FeefbackContent { get; set; }
        public string FUserName { get; set; }
        public string FUserTel { get; set; }
        public string FUserqq { get; set; }
        public string Email { get; set; }
        public System.DateTime AddTime { get; set; }
        public string Replies { get; set; }
        public Nullable<System.DateTime> ReplyTime { get; set; }
        public bool IsLock { get; set; }
    }
}
