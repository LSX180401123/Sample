﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManager.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourseManagerEntities : DbContext
    {
        public CourseManagerEntities()
            : base("name=CourseManagerEntities")
        {
        }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<CourseManagements> CourseManagements { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<ActionLink> ActionLink { get; set; }
        public DbSet<SideBars> SideBars { get; set; }
    }
}
