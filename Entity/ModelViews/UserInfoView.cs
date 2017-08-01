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
    public partial class UserInfoView
    {
        public int UserId { get; set; }
        [DisplayName("用户名")]
        [Required(ErrorMessage ="用户名不能为空")]
        public string UserName { get; set; }
        [DisplayName("密   码")]
        [Required(ErrorMessage = "密码不能为空")]
        [MinLength(6,ErrorMessage ="密码长度必须大于等于6")]
        public string UserPwd { get; set; }
        public string RealName { get; set; }
        public string UserTelphone { get; set; }
        public string UserEmail { get; set; }
        public bool UserIsLock { get; set; }
        public System.DateTime UserAddTime { get; set; }
    }
}