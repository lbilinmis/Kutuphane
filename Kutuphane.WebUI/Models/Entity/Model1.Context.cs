﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane.WebUI.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KutuphaneDBEntities : DbContext
    {
        public KutuphaneDBEntities()
            : base("name=KutuphaneDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCeza> TblCeza { get; set; }
        public virtual DbSet<TblHareket> TblHareket { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblKitap> TblKitap { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblUye> TblUye { get; set; }
        public virtual DbSet<TblYazar> TblYazar { get; set; }
        public virtual DbSet<TblHakkimizda> TblHakkimizda { get; set; }
        public virtual DbSet<TblIletisim> TblIletisim { get; set; }
        public virtual DbSet<TblMesajlar> TblMesajlar { get; set; }
    
        public virtual ObjectResult<EnFazlaKitapOlanYazar_Result> EnFazlaKitapOlanYazar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnFazlaKitapOlanYazar_Result>("EnFazlaKitapOlanYazar");
        }
    }
}
