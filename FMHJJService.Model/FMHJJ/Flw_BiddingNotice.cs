//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FMHJJService.Model.FMHJJ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flw_BiddingNotice
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> NoticeType { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public string Publisher { get; set; }
        public string PublishContent { get; set; }
        public string PublishCompany { get; set; }
    }
}
