using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCore.Data.DataModels;

namespace InfrelearnMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Db table name change Users -> User
            modelBuilder.Entity<User>().ToTable(name: "User");
            
            // Combination key
            modelBuilder.Entity<UserRolesByUser>().HasKey(c => new { c.UserId, c.RoleId });

            // default value in column
            modelBuilder.Entity<User>(
                e=>
                {
                    e.Property(c => c.IsMembershipWithdrawn).HasDefaultValue(value: false);
                });
            
            // indexing
            modelBuilder.Entity<User>().HasIndex(c => new { c.UserEmail });
        }
    }
}