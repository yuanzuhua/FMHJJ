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
    
    public partial class Data_BidManage
    {
        public int ID { get; set; }
        public Nullable<int> ProductType { get; set; }
        public Nullable<System.DateTime> BidDate { get; set; }
        public Nullable<System.DateTime> BidStartTime { get; set; }
        public Nullable<System.DateTime> BidEndTime { get; set; }
        public Nullable<decimal> EstimateAmount { get; set; }
        public Nullable<decimal> CurrentPriceLower { get; set; }
        public Nullable<decimal> CurrentPriceUpper { get; set; }
        public Nullable<int> BidCount { get; set; }
        public Nullable<decimal> AmountMin { get; set; }
        public Nullable<int> BidManner { get; set; }
        public string Publisher { get; set; }
        public Nullable<System.DateTime> PublishTime { get; set; }
        public Nullable<int> State { get; set; }
    }
}
