﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISSControlProje.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iss_webEntities : DbContext
    {
        public iss_webEntities()
            : base("name=iss_webEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblMusteriler> tblMusteriler { get; set; }
        public virtual DbSet<tblPaketler> tblPaketler { get; set; }
        public virtual DbSet<tblYoneticiler> tblYoneticiler { get; set; }
    }
}
