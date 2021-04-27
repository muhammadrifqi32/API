using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Models;

namespace TemplateNetCore.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profiling> Profilings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to one relation
            modelBuilder.Entity<Person>()
                .HasOne(account => account.Account)
                .WithOne(person => person.Person)
                .HasForeignKey<Account>(account => account.NIK);

            //one to one relation
            modelBuilder.Entity<Account>()
                .HasOne(profiling => profiling.Profiling)
                .WithOne(account => account.Account)
                .HasForeignKey<Profiling>(account => account.NIK);

            //one to many
            modelBuilder.Entity<Profiling>()
                .HasOne(education => education.Education)
                .WithMany(profiling => profiling.Profilings);

            //one to many
            modelBuilder.Entity<University>()
                .HasMany(education => education.Educations)
                .WithOne(university => university.University);

            //set primary key
            modelBuilder.Entity<AccountRole>()
                .HasKey(ar => new { ar.NIK, ar.RoleId });

            //many to many
            modelBuilder.Entity<AccountRole>()
                .HasOne(account => account.Account)
                .WithMany(ar => ar.AccountRoles)
                .HasForeignKey(account => account.NIK);

            modelBuilder.Entity<AccountRole>()
                .HasOne(role => role.Role)
                .WithMany(ar => ar.AccountRoles)
                .HasForeignKey(role => role.RoleId);
        }
    }
}
