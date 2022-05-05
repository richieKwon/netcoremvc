using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetCore.Data.DataModels;

namespace NetCore.Services.Data
{
    // fluent API
    public class CodeFirstDbContext : DbContext
    {
        // Inheritance of constructor from DbContext
        // In C#, base keyword is used to access fields, constructors and methods of base class.
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {
        }

        // Db table List
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