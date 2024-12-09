using System;
using Microsoft.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using fa24group8finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace fa24group8finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }

        //TODO: Add Dbsets here.  Products is included as an example.
        public DbSet<Property> Properties { get; set; }         // mimics product or course class               // mimics order details (hw5) or registration details (github) class
        public DbSet<Reservation> Reservations { get; set; }    // mimics order class
        public DbSet<Category> Categories { get; set; }

        public DbSet<PropertyReview> PropertyReviews { get; set; }

    }
}
