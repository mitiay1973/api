﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sfera_IT_PPEntities3 : DbContext
    {
        public Sfera_IT_PPEntities3()
            : base("name=Sfera_IT_PPEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<active_user> active_user { get; set; }
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<glavnaya> glavnaya { get; set; }
        public virtual DbSet<licensii> licensii { get; set; }
        public virtual DbSet<licensii1> licensii1 { get; set; }
        public virtual DbSet<licensii2> licensii2 { get; set; }
        public virtual DbSet<licensii3> licensii3 { get; set; }
        public virtual DbSet<licensii4> licensii4 { get; set; }
        public virtual DbSet<licensii5> licensii5 { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<zakazi> zakazi { get; set; }
    }
}
