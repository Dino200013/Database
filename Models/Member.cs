//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjDBHomework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Member
    {
        public int fId { get; set; }
        [DisplayName("帳號")]
        [Required]
        public string fUserId { get; set; }
        [DisplayName("密碼")]
        [Required]
        public string fPwd { get; set; }
        [DisplayName("姓名")]
        [Required]
        public string fName { get; set; }
        [DisplayName("信箱")]
        [Required]
        public string fEmail { get; set; }
    }
}
