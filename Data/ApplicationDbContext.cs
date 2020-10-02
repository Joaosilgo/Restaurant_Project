using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using retaurant_info.Models;

namespace retaurant_info.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
            

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
            //Configure domain classes using modelBuilder here..
          //  modelBuilder.Entity<ApplicationUser>()
       //.HasMany(u => u.Links)
       //.WithOne(l => l.ApplicationUser);

      //  }
    }
}
