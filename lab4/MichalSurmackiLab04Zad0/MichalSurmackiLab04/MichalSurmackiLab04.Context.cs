﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MichalSurmackiLab04
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RegistrationSystemApprenticeEntities : DbContext
    {
        public RegistrationSystemApprenticeEntities()
            : base("name=RegistrationSystemApprenticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<InformationAboutStudent> InformationAboutStudent { get; set; }
        public virtual DbSet<StudentLogInSystem> StudentLogInSystem { get; set; }
    }
}