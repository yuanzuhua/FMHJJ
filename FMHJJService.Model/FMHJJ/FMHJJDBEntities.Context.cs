﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FMHJJDBEntities : DbContext
    {
        public FMHJJDBEntities()
            : base("name=FMHJJDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Base_UserInfo_Grant> Base_UserInfo_Grant { get; set; }
        public virtual DbSet<Dict_FunctionMenu> Dict_FunctionMenu { get; set; }
        public virtual DbSet<Dict_System> Dict_System { get; set; }
        public virtual DbSet<Flw_BiddingNotice> Flw_BiddingNotice { get; set; }
        public virtual DbSet<Data_SmsManage> Data_SmsManage { get; set; }
        public virtual DbSet<Data_Parameters> Data_Parameters { get; set; }
        public virtual DbSet<Base_ProductInfo> Base_ProductInfo { get; set; }
        public virtual DbSet<Base_ProductInfo_Detail> Base_ProductInfo_Detail { get; set; }
        public virtual DbSet<Base_UserInfo> Base_UserInfo { get; set; }
        public virtual DbSet<Data_BidManage> Data_BidManage { get; set; }
        public virtual DbSet<Flw_BiddingInfo> Flw_BiddingInfo { get; set; }
    }
}